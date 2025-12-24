using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Windows.Forms;
using Tyuiu.Kazhahmetov.Sprint7.V4.Lib;

namespace Tyuiu.Kazhahmetov.Sprint7.V4
{
    public partial class FormMain_KAE : Form
    {
        private LibraryService libraryService; // Работа с библиотекой

        public FormMain_KAE()
        {
            InitializeComponent();

            libraryService = new LibraryService();


            string savedPath = LoadLibraryPath();

            bool loaded = false;

            if (!string.IsNullOrEmpty(savedPath) && File.Exists(savedPath))
            {
                try
                {
                    libraryService.LoadFromCSV(savedPath);
                    loaded = true;
                }
                catch
                {

                }
            }


            if (!loaded)
            {
                libraryService.AddTestBooks();
            }


            ShowBooks();
            UpdateBookCount();

            this.KeyPreview = true;
            this.KeyDown += FormMain_KeyDown;
            textBoxSearch_KAE.TextChanged += textBoxSearch_KAE_TextChanged;
        } // Инициализация

        private void ShowBooks()
        {
            ShowSortedBooks(libraryService.GetAllBooks());


        } // Показывает книги

        private void UpdateBookCount() // Обновляет счетчик книг
        {
            int count = libraryService.GetBookCount();
            labelBookCount_KAE.Text = $"Всего книг: {count}";
        }



        private void FormMain_Load(object sender, EventArgs e)
        {

        }


        private void buttonAddBook_KAE_Click(object sender, EventArgs e)
        {
            using (var inputForm = new AddBookForm_KAE())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    libraryService.AddBook(inputForm.NewBook);

                    UpdateBookCount();
                    ShowBooksWithSearch();
                }
            }
        } // Добавление новой книги (кнопка)
        private void booksMenuAdd_KAE_Click(object sender, EventArgs e)
        {
            buttonAddBook_KAE_Click(sender, e);
        } // Добавление новой книги (меню)


        private void загрузитьБиблиотекуCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileMenuExit_KAE_Click(object sender, EventArgs e) // Выход из приложения
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите выйти?",
                  "Подтверждение выхода",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void DeleteSelectedBook() // Удаление выбранной книги
        {
            if (listBoxBooks_KAE.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите книгу для удаления!",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                return;
            }

            string selectedBookText = listBoxBooks_KAE.SelectedItem.ToString();

            var currentBooks = GetCurrentDisplayedBooks();
            Book bookToDelete = currentBooks.FirstOrDefault(b => b.ToString() == selectedBookText);

            if (bookToDelete == null)
            {
                MessageBox.Show("Ошибка: книга не найдена!", "Ошибка");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Удалить книгу: \n\"{bookToDelete.Title}\" ({bookToDelete.Author})?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool removed = libraryService.RemoveBook(bookToDelete);

                if (removed)
                {
                    ShowBooksWithSearch();
                    UpdateBookCount();
                    MessageBox.Show("Книга удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не удалось удалить книгу!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void buttonDeleteBook_KAE_Click(object sender, EventArgs e)
        {
            DeleteSelectedBook();
        }
        private void booksMenuDelete_KAE_Click(object sender, EventArgs e)
        {
            DeleteSelectedBook();
        }


        private void FormMain_KeyDown(object sender, KeyEventArgs e) // Обработка горячих клавиш
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedBook();
                e.Handled = true;
            }

            else if (e.KeyCode == Keys.N && e.Control)
            {
                buttonAddBook_KAE_Click(sender, e);
                e.Handled = true;
            }

            else if (e.KeyCode == Keys.S && e.Control)
            {
                fileMenuSave_KAE_Click(sender, e);
                e.Handled = true;
            }

            else if (e.KeyCode == Keys.O && e.Control)
            {
                fileMenuLoad_KAE_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.E && e.Control)
            {
                EditSelectedBook();
                e.Handled = true;
            }
        }

        private void fileMenuSave_KAE_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveDialog.Title = "Сохранить библиотеку";
            saveDialog.DefaultExt = "csv";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    libraryService.SaveToCSV(saveDialog.FileName);
                    SaveLibraryPath(saveDialog.FileName);
                    MessageBox.Show($"Библиотека сохранена!", "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
                }
            }


        } // Сохранение

        private void fileMenuLoad_KAE_Click(object sender, EventArgs e) // Загрузка
        {
            if (libraryService.GetBookCount() > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Текущие книги будут удалены. Продолжить?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            openDialog.Title = "Загрузить библиотеку";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    libraryService.LoadFromCSV(openDialog.FileName);
                    SaveLibraryPath(openDialog.FileName);

                    ShowBooksWithSearch();
                    UpdateBookCount();

                    MessageBox.Show($"Библиотека загружена!", "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
                }
            }
        }

        private void buttonSave_KAE_Click(object sender, EventArgs e)
        {
            fileMenuSave_KAE_Click(sender, e);
        }

        private void buttonLoad_KAE_Click(object sender, EventArgs e)
        {
            fileMenuLoad_KAE_Click(sender, e);
        }

        private void SaveLibraryPath(string path) // Путь файла
        {
            try
            {
                File.WriteAllText("config.txt", path);
            }
            catch { }
        }

        private string LoadLibraryPath()
        {
            try
            {
                if (File.Exists("config.txt"))
                {
                    return File.ReadAllText("config.txt");
                }
            }
            catch { }
            return "";
        }

        private void comboBoxSort_KAE_SelectedIndexChanged(object sender, EventArgs e) // Сортировка
        {
            if (comboBoxSort_KAE.SelectedIndex == -1)
            {
                return;
            }

            switch (comboBoxSort_KAE.SelectedIndex)
            {
                case 1: // По дате добавления (старые → новые)
                    libraryService.SortBooksByDateAdded(true);
                    break;

                case 0: // По дате добавления (новые → старые)
                    libraryService.SortBooksByDateAdded(false);
                    break;

                case 2: // По названию (А-Я)
                    libraryService.SortBooksByTitle(true);
                    break;

                case 3: // По названию (Я-А)
                    libraryService.SortBooksByTitle(false);
                    break;

                case 4: // По автору (А-Я)
                    libraryService.SortBooksByAuthor(true);
                    break;

                case 5: // По автору (Я-А)
                    libraryService.SortBooksByAuthor(false);
                    break;

                case 6: // По году (старые → новые)
                    libraryService.SortBooksByYear(true);
                    break;

                case 7: // По году (новые → старые)
                    libraryService.SortBooksByYear(false);
                    break;
            }

            ShowBooksWithSearch();

        }
        private void ShowSortedBooks(List<Book> booksToShow) // Отображение
        {
            listBoxBooks_KAE.Items.Clear();

            foreach (var book in booksToShow)
            {
                listBoxBooks_KAE.Items.Add(book.ToString());
            }

            UpdateBookCount();
        }

        private void radioButtonDesc_KAE_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void EditSelectedBook() // Редактирование
        {
            if (listBoxBooks_KAE.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите книгу для редактирования!",
                                 "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            string selectedBookText = listBoxBooks_KAE.SelectedItem.ToString();
            var allBooks = libraryService.GetAllBooks();
            Book bookToEdit = allBooks.FirstOrDefault(b => b.ToString() == selectedBookText);

            if (bookToEdit == null)
            {
                MessageBox.Show("Ошибка: книга не найдена!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var editForm = new FormEditBook_KAE(bookToEdit))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    bool succes = libraryService.UpdateBook(bookToEdit, editForm.EditedBook);

                    if (succes)
                    {
                        RefreshBookList();
                        MessageBox.Show("Книга успешно обновлена!", "Успех",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось обновить книгу!", "Ошибка",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void RefreshBookList()
        {
            if (comboBoxSort_KAE.SelectedIndex != -1)
            {
                comboBoxSort_KAE_SelectedIndexChanged(null, null);
            }
            else
            {
                ShowSortedBooks(libraryService.GetAllBooks());
            }
        } // Обновление после изменений

        private void buttonEditBook_KAE_Click(object sender, EventArgs e)
        {
            EditSelectedBook();
        }

        private void listBoxBooks_KAE_DoubleClick(object sender, EventArgs e)
        {
            EditSelectedBook();
        }

        private void редактироватьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelectedBook();
        }


        private void ShowBooksWithSearch() // Поиск
        {
            string searchText = textBoxSearch_KAE.Text.Trim().ToLower();
            var allBooks = libraryService.GetAllBooks();

            if (!string.IsNullOrEmpty(searchText))
            {
                allBooks = allBooks.Where(b =>
                                  b.Title.ToLower().Contains(searchText) ||
                                  b.Author.ToLower().Contains(searchText)).ToList();
            }

            ShowBooksInListBox(allBooks);
        }

        private void ShowBooksInListBox(List<Book> books) // Отображение после поиска
        {
            listBoxBooks_KAE.Items.Clear();

            foreach (var book in books)
            {
                listBoxBooks_KAE.Items.Add(book.ToString());
            }

            UpdateBookCount();

        }

        private void textBoxSearch_KAE_TextChanged(object sender, EventArgs e)
        {
            ShowBooksWithSearch();

        } 


        private List<Book> GetCurrentDisplayedBooks() // Отображение текущего списка
        {
            string searchText = textBoxSearch_KAE.Text.Trim().ToLower();
            var allBooks = libraryService.GetAllBooks();

            if (!string.IsNullOrEmpty(searchText))
            {
                allBooks = allBooks.Where(b =>
                                  b.Title.ToLower().Contains(searchText) ||
                                  b.Author.ToLower().Contains(searchText)).ToList();
            }

            return allBooks;
        }

        private void helpMenuAbout_KAE_Click(object sender, EventArgs e) // О программе
        {
            FormAbout_KAE fm = new FormAbout_KAE(); 
            fm.ShowDialog();
        }

        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e) // Инструкция
        {
            FormInfo_KAE fi = new FormInfo_KAE();
            fi.ShowDialog();
        }
    }

}
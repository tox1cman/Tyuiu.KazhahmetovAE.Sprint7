using System;
using System.Diagnostics.SymbolStore;
using System.Windows.Forms;
using Tyuiu.Kazhahmetov.Sprint7.V4.Lib;

namespace Tyuiu.Kazhahmetov.Sprint7.V4
{
    public partial class FormMain_KAE : Form
    {
        private LibraryService libraryService;
        public FormMain_KAE()
        {
            InitializeComponent();

            libraryService = new LibraryService();
            libraryService.AddTestBooks();

            ShowBooks();
            UpdateBookCount();

            this.KeyPreview = true;
            this.KeyDown += FormMain_KeyDown;
        }

        private void ShowBooks()
        {
            listBoxBooks_KAE.Items.Clear();

            var books = libraryService.GetAllBooks();

            foreach (var book in books)
            {
                listBoxBooks_KAE.Items.Add(book.ToString());
            }
        }

        private void UpdateBookCount()
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

                    ShowBooks();
                    UpdateBookCount();
                }
            }
        }
        private void booksMenuAdd_KAE_Click(object sender, EventArgs e)
        {
            buttonAddBook_KAE_Click(sender, e);
        }


        private void загрузитьБиблиотекуCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileMenuExit_KAE_Click(object sender, EventArgs e)
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



        private void DeleteSelectedBook()
        {
            if (listBoxBooks_KAE.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите книгу для удаления!",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = listBoxBooks_KAE.SelectedIndex;

            Book bookToDelete = libraryService.GetBookAt(selectedIndex);

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
                libraryService.RemoveBookAt(selectedIndex);

                ShowBooks();
                UpdateBookCount();

                MessageBox.Show("Книга удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void FormMain_KeyDown(object sender, KeyEventArgs e)
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
        }

    }

}

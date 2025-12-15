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
    }
}

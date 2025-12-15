using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.Kazhahmetov.Sprint7.V4.Lib;

namespace Tyuiu.Kazhahmetov.Sprint7.V4
{
    public partial class AddBookForm_KAE : Form
    {
        public Book NewBook { get; private set; }

        public AddBookForm_KAE()
        {
            InitializeComponent();
            NewBook = new Book();
        }

        private void AddBookForm_KAE_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_KAE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle_KAE.Text))
            {
                MessageBox.Show("Введите название книги!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxAuthor_KAE.Text))
            {
                MessageBox.Show("Введите автора книги!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewBook.Title = textBoxTitle_KAE.Text;
            NewBook.Author = textBoxAuthor_KAE.Text;
            NewBook.Year = (int)numericYear_KAE.Value;
            NewBook.Genre = textBoxGenre_KAE.Text;

            this.DialogResult |= DialogResult.OK;
        }
    }
}

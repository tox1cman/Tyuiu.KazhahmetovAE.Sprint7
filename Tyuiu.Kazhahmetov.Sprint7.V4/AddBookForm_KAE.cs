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
        public Book NewBook { get; private set; } // Свойство передачи книги в главную форму

        public AddBookForm_KAE() // Конструктор формы
        {
            InitializeComponent();
            NewBook = new Book();

            textBoxTitle_KAE.TextChanged += CheckedFieldsTitle;
            textBoxAuthor_KAE.TextChanged += CheckedFieldsAuthor;
        }

        private void UpdateAddButtonState() // Состояние кнопки добавления
        {
            bool titleOk = !string.IsNullOrWhiteSpace(textBoxTitle_KAE.Text);
            bool authorOk = !string.IsNullOrWhiteSpace(textBoxAuthor_KAE.Text);

            buttonOk_KAE.Enabled = titleOk && authorOk;

            if (buttonOk_KAE.Enabled)
            {
                buttonOk_KAE.Text = "✅ Добавить";
            }
            else if (titleOk)
            {
                buttonOk_KAE.Text = "❌ Добавьте Автора";
            }
            else if (authorOk)
            {
                buttonOk_KAE.Text = "❌ Добавьте Название";
            }
            else
            {
                buttonOk_KAE.Text = "❌ Заполните поля";
            }
        }


        private void CheckedFieldsTitle(object sender, EventArgs e) // Валидация поля с названием
        {
            bool titleOk = !string.IsNullOrWhiteSpace(textBoxTitle_KAE.Text);
            textBoxTitle_KAE.BackColor = titleOk ? Color.White : Color.LightPink;
            UpdateAddButtonState();
        }

        private void CheckedFieldsAuthor(object sender, EventArgs e) // Валидация поля с автором
        {
            bool authorOk = !string.IsNullOrWhiteSpace(textBoxAuthor_KAE.Text);
            textBoxAuthor_KAE.BackColor = authorOk ? Color.White : Color.LightPink;
            UpdateAddButtonState();
        }

        private void AddBookForm_KAE_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_KAE_Click(object sender, EventArgs e) // Обработчик кнопки
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle_KAE.Text))
            {
                MessageBox.Show("Введите Название и Автора книги!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewBook.Title = textBoxTitle_KAE.Text;
            NewBook.Author = textBoxAuthor_KAE.Text;
            NewBook.Year = (int)numericYear_KAE.Value;
            NewBook.Genre = textBoxGenre_KAE.Text;

            this.DialogResult = DialogResult.OK;
        }
    }
}

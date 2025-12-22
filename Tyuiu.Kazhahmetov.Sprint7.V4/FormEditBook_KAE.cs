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
    public partial class FormEditBook_KAE : Form
    {
        public Book EditedBook { get; private set; }


        public FormEditBook_KAE(Book bookToEdit)
        {
            InitializeComponent();
            EditedBook = bookToEdit;
            LoadBookData();
            WireUpEvents();
            UpdateSaveButtonState();
        }

        private void LoadBookData()
        {
            textBoxTitle_KAE.Text = EditedBook.Title;
            textBoxAuthor_KAE.Text = EditedBook.Author;
            numericYear_KAE.Value = EditedBook.Year;
            textBoxGenre_KAE.Text = EditedBook.Genre;
            textBoxDateAdded_KAE.Text = EditedBook.DateAdded.ToString("HH:mm dd-MM-yyyy");
            richTextBoxNotes_KAE.Text = EditedBook.Notes ?? "";
        }

        private void WireUpEvents()
        {
            textBoxTitle_KAE.TextChanged += ValidateFields;
            textBoxAuthor_KAE.TextChanged += ValidateFields;
            buttonSave_KAE.Click += buttonSave_KAE_Click;
            buttonCancel_KAE.Click += buttonCancel_KAE_Click;
        }

        private void ValidateFields(object sender, EventArgs e)
        {
            bool titleOk = !string.IsNullOrWhiteSpace(textBoxTitle_KAE.Text);
            bool authorOk = !string.IsNullOrWhiteSpace(textBoxAuthor_KAE.Text);

            // Визуальная обратная связь
            textBoxTitle_KAE.BackColor = titleOk ? Color.White : Color.LightPink;
            textBoxAuthor_KAE.BackColor = authorOk ? Color.White : Color.LightPink;

            UpdateSaveButtonState();
        }

        private void UpdateSaveButtonState()
        {
            bool titleOk = !string.IsNullOrWhiteSpace(textBoxTitle_KAE.Text);
            bool authorOk = !string.IsNullOrWhiteSpace(textBoxAuthor_KAE.Text);

            buttonSave_KAE.Enabled = titleOk && authorOk;

            if (buttonSave_KAE.Enabled)
            {
                buttonSave_KAE.BackColor = Color.LightGreen;
                buttonSave_KAE.Text = "💾 СОХРАНИТЬ";
            }
            else if (titleOk)
            {
                buttonSave_KAE.BackColor = Color.LightGray;
                buttonSave_KAE.Text = "❌ Добавьте Автора";
            }
            else if (authorOk)
            {
                buttonSave_KAE.BackColor = Color.LightGray;
                buttonSave_KAE.Text = "❌ Добавьте Название";
            }
            else
            {
                buttonSave_KAE.BackColor = Color.LightGray;
                buttonSave_KAE.Text = "❌ Заполните поля";
            }
        }

        private void FormEditBook_KAE_Load(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_KAE_Click(object sender, EventArgs e)
        {
            EditedBook.Title = textBoxTitle_KAE.Text.Trim();
            EditedBook.Author = textBoxAuthor_KAE.Text.Trim();
            EditedBook.Year = (int)numericYear_KAE.Value;
            EditedBook.Genre = textBoxGenre_KAE.Text.Trim();
            EditedBook.Notes = richTextBoxNotes_KAE.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_KAE_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void numericYear_KAE_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

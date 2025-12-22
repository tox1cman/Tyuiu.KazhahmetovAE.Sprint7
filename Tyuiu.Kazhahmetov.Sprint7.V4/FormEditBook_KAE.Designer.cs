namespace Tyuiu.Kazhahmetov.Sprint7.V4
{
    partial class FormEditBook_KAE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle_KAE = new Label();
            labelAuthor_KAE = new Label();
            labelYear_KAE = new Label();
            labelGenre_KAE = new Label();
            labelDateAdded_KAE = new Label();
            labelNotes_KAE = new Label();
            textBoxTitle_KAE = new TextBox();
            textBoxAuthor_KAE = new TextBox();
            textBoxGenre_KAE = new TextBox();
            textBoxDateAdded_KAE = new TextBox();
            numericYear_KAE = new NumericUpDown();
            richTextBoxNotes_KAE = new RichTextBox();
            buttonSave_KAE = new Button();
            buttonCancel_KAE = new Button();
            ((System.ComponentModel.ISupportInitialize)numericYear_KAE).BeginInit();
            SuspendLayout();
            // 
            // labelTitle_KAE
            // 
            labelTitle_KAE.Location = new Point(20, 20);
            labelTitle_KAE.Name = "labelTitle_KAE";
            labelTitle_KAE.Size = new Size(100, 25);
            labelTitle_KAE.TabIndex = 0;
            labelTitle_KAE.Text = "Название:";
            // 
            // labelAuthor_KAE
            // 
            labelAuthor_KAE.Location = new Point(20, 60);
            labelAuthor_KAE.Name = "labelAuthor_KAE";
            labelAuthor_KAE.Size = new Size(100, 25);
            labelAuthor_KAE.TabIndex = 1;
            labelAuthor_KAE.Text = "Автор:";
            // 
            // labelYear_KAE
            // 
            labelYear_KAE.Location = new Point(20, 100);
            labelYear_KAE.Name = "labelYear_KAE";
            labelYear_KAE.Size = new Size(100, 25);
            labelYear_KAE.TabIndex = 2;
            labelYear_KAE.Text = "Год издания:";
            // 
            // labelGenre_KAE
            // 
            labelGenre_KAE.Location = new Point(20, 140);
            labelGenre_KAE.Name = "labelGenre_KAE";
            labelGenre_KAE.Size = new Size(100, 25);
            labelGenre_KAE.TabIndex = 3;
            labelGenre_KAE.Text = "Жанр:";
            // 
            // labelDateAdded_KAE
            // 
            labelDateAdded_KAE.Location = new Point(20, 180);
            labelDateAdded_KAE.Name = "labelDateAdded_KAE";
            labelDateAdded_KAE.Size = new Size(120, 25);
            labelDateAdded_KAE.TabIndex = 4;
            labelDateAdded_KAE.Text = "Дата добавления:";
            // 
            // labelNotes_KAE
            // 
            labelNotes_KAE.Location = new Point(20, 220);
            labelNotes_KAE.Name = "labelNotes_KAE";
            labelNotes_KAE.Size = new Size(100, 25);
            labelNotes_KAE.TabIndex = 5;
            labelNotes_KAE.Text = "ЗАМЕТКИ:";
            labelNotes_KAE.Click += label4_Click;
            // 
            // textBoxTitle_KAE
            // 
            textBoxTitle_KAE.Location = new Point(130, 20);
            textBoxTitle_KAE.MaxLength = 200;
            textBoxTitle_KAE.Name = "textBoxTitle_KAE";
            textBoxTitle_KAE.Size = new Size(299, 23);
            textBoxTitle_KAE.TabIndex = 6;
            // 
            // textBoxAuthor_KAE
            // 
            textBoxAuthor_KAE.Location = new Point(130, 60);
            textBoxAuthor_KAE.MaxLength = 100;
            textBoxAuthor_KAE.Name = "textBoxAuthor_KAE";
            textBoxAuthor_KAE.Size = new Size(299, 23);
            textBoxAuthor_KAE.TabIndex = 7;
            // 
            // textBoxGenre_KAE
            // 
            textBoxGenre_KAE.Location = new Point(130, 140);
            textBoxGenre_KAE.MaxLength = 50;
            textBoxGenre_KAE.Name = "textBoxGenre_KAE";
            textBoxGenre_KAE.Size = new Size(300, 23);
            textBoxGenre_KAE.TabIndex = 8;
            // 
            // textBoxDateAdded_KAE
            // 
            textBoxDateAdded_KAE.BorderStyle = BorderStyle.FixedSingle;
            textBoxDateAdded_KAE.Location = new Point(130, 180);
            textBoxDateAdded_KAE.Name = "textBoxDateAdded_KAE";
            textBoxDateAdded_KAE.ReadOnly = true;
            textBoxDateAdded_KAE.Size = new Size(299, 23);
            textBoxDateAdded_KAE.TabIndex = 9;
            textBoxDateAdded_KAE.TabStop = false;
            // 
            // numericYear_KAE
            // 
            numericYear_KAE.Location = new Point(130, 100);
            numericYear_KAE.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numericYear_KAE.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericYear_KAE.Name = "numericYear_KAE";
            numericYear_KAE.Size = new Size(100, 23);
            numericYear_KAE.TabIndex = 10;
            numericYear_KAE.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            numericYear_KAE.ValueChanged += numericYear_KAE_ValueChanged;
            // 
            // richTextBoxNotes_KAE
            // 
            richTextBoxNotes_KAE.AcceptsTab = true;
            richTextBoxNotes_KAE.Location = new Point(20, 250);
            richTextBoxNotes_KAE.Name = "richTextBoxNotes_KAE";
            richTextBoxNotes_KAE.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxNotes_KAE.Size = new Size(410, 200);
            richTextBoxNotes_KAE.TabIndex = 11;
            richTextBoxNotes_KAE.Text = "";
            // 
            // buttonSave_KAE
            // 
            buttonSave_KAE.BackColor = Color.LightGreen;
            buttonSave_KAE.DialogResult = DialogResult.OK;
            buttonSave_KAE.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSave_KAE.Location = new Point(130, 468);
            buttonSave_KAE.Name = "buttonSave_KAE";
            buttonSave_KAE.Size = new Size(184, 35);
            buttonSave_KAE.TabIndex = 12;
            buttonSave_KAE.Text = "💾 СОХРАНИТЬ";
            buttonSave_KAE.UseVisualStyleBackColor = false;
            buttonSave_KAE.Click += buttonSave_KAE_Click;
            // 
            // buttonCancel_KAE
            // 
            buttonCancel_KAE.BackColor = Color.LightGray;
            buttonCancel_KAE.DialogResult = DialogResult.Cancel;
            buttonCancel_KAE.Location = new Point(348, 468);
            buttonCancel_KAE.Name = "buttonCancel_KAE";
            buttonCancel_KAE.Size = new Size(80, 35);
            buttonCancel_KAE.TabIndex = 13;
            buttonCancel_KAE.Text = "ОТМЕНА";
            buttonCancel_KAE.UseVisualStyleBackColor = false;
            buttonCancel_KAE.Click += buttonCancel_KAE_Click;
            // 
            // FormEditBook_KAE
            // 
            AcceptButton = buttonSave_KAE;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel_KAE;
            ClientSize = new Size(447, 524);
            Controls.Add(buttonCancel_KAE);
            Controls.Add(buttonSave_KAE);
            Controls.Add(richTextBoxNotes_KAE);
            Controls.Add(numericYear_KAE);
            Controls.Add(textBoxDateAdded_KAE);
            Controls.Add(textBoxGenre_KAE);
            Controls.Add(textBoxAuthor_KAE);
            Controls.Add(textBoxTitle_KAE);
            Controls.Add(labelNotes_KAE);
            Controls.Add(labelDateAdded_KAE);
            Controls.Add(labelGenre_KAE);
            Controls.Add(labelYear_KAE);
            Controls.Add(labelAuthor_KAE);
            Controls.Add(labelTitle_KAE);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditBook_KAE";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактирование книги";
            Load += FormEditBook_KAE_Load;
            ((System.ComponentModel.ISupportInitialize)numericYear_KAE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle_KAE;
        private Label labelAuthor_KAE;
        private Label labelYear_KAE;
        private Label labelGenre_KAE;
        private Label labelDateAdded_KAE;
        private Label labelNotes_KAE;
        private TextBox textBoxTitle_KAE;
        private TextBox textBoxAuthor_KAE;
        private TextBox textBoxGenre_KAE;
        private TextBox textBoxDateAdded_KAE;
        private NumericUpDown numericYear_KAE;
        private RichTextBox richTextBoxNotes_KAE;
        private Button buttonSave_KAE;
        private Button buttonCancel_KAE;
    }
}
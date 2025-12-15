namespace Tyuiu.Kazhahmetov.Sprint7.V4
{
    partial class AddBookForm_KAE
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
            textBoxTitle_KAE = new TextBox();
            textBoxAuthor_KAE = new TextBox();
            textBoxGenre_KAE = new TextBox();
            numericYear_KAE = new NumericUpDown();
            buttonOk_KAE = new Button();
            buttonCancel_KAE = new Button();
            ((System.ComponentModel.ISupportInitialize)numericYear_KAE).BeginInit();
            SuspendLayout();
            // 
            // labelTitle_KAE
            // 
            labelTitle_KAE.AutoSize = true;
            labelTitle_KAE.Location = new Point(20, 20);
            labelTitle_KAE.Name = "labelTitle_KAE";
            labelTitle_KAE.Size = new Size(62, 15);
            labelTitle_KAE.TabIndex = 0;
            labelTitle_KAE.Text = "Название:";
            // 
            // labelAuthor_KAE
            // 
            labelAuthor_KAE.AutoSize = true;
            labelAuthor_KAE.Location = new Point(20, 60);
            labelAuthor_KAE.Name = "labelAuthor_KAE";
            labelAuthor_KAE.Size = new Size(43, 15);
            labelAuthor_KAE.TabIndex = 1;
            labelAuthor_KAE.Text = "Автор:";
            // 
            // labelYear_KAE
            // 
            labelYear_KAE.AutoSize = true;
            labelYear_KAE.Location = new Point(20, 100);
            labelYear_KAE.Name = "labelYear_KAE";
            labelYear_KAE.Size = new Size(29, 15);
            labelYear_KAE.TabIndex = 2;
            labelYear_KAE.Text = "Год:";
            // 
            // labelGenre_KAE
            // 
            labelGenre_KAE.AutoSize = true;
            labelGenre_KAE.Location = new Point(20, 140);
            labelGenre_KAE.Name = "labelGenre_KAE";
            labelGenre_KAE.Size = new Size(41, 15);
            labelGenre_KAE.TabIndex = 3;
            labelGenre_KAE.Text = "Жанр:";
            // 
            // textBoxTitle_KAE
            // 
            textBoxTitle_KAE.Location = new Point(100, 17);
            textBoxTitle_KAE.Name = "textBoxTitle_KAE";
            textBoxTitle_KAE.Size = new Size(200, 23);
            textBoxTitle_KAE.TabIndex = 4;
            // 
            // textBoxAuthor_KAE
            // 
            textBoxAuthor_KAE.Location = new Point(100, 57);
            textBoxAuthor_KAE.Name = "textBoxAuthor_KAE";
            textBoxAuthor_KAE.Size = new Size(200, 23);
            textBoxAuthor_KAE.TabIndex = 5;
            // 
            // textBoxGenre_KAE
            // 
            textBoxGenre_KAE.Location = new Point(100, 137);
            textBoxGenre_KAE.Name = "textBoxGenre_KAE";
            textBoxGenre_KAE.Size = new Size(200, 23);
            textBoxGenre_KAE.TabIndex = 6;
            // 
            // numericYear_KAE
            // 
            numericYear_KAE.Location = new Point(100, 97);
            numericYear_KAE.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numericYear_KAE.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericYear_KAE.Name = "numericYear_KAE";
            numericYear_KAE.Size = new Size(100, 23);
            numericYear_KAE.TabIndex = 7;
            numericYear_KAE.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // buttonOk_KAE
            // 
            buttonOk_KAE.Location = new Point(100, 180);
            buttonOk_KAE.Name = "buttonOk_KAE";
            buttonOk_KAE.Size = new Size(75, 23);
            buttonOk_KAE.TabIndex = 8;
            buttonOk_KAE.Text = "Добавить";
            buttonOk_KAE.UseVisualStyleBackColor = true;
            buttonOk_KAE.Click += buttonOk_KAE_Click;
            // 
            // buttonCancel_KAE
            // 
            buttonCancel_KAE.DialogResult = DialogResult.Cancel;
            buttonCancel_KAE.Location = new Point(200, 180);
            buttonCancel_KAE.Name = "buttonCancel_KAE";
            buttonCancel_KAE.Size = new Size(75, 23);
            buttonCancel_KAE.TabIndex = 9;
            buttonCancel_KAE.Text = "Отмена";
            buttonCancel_KAE.UseVisualStyleBackColor = true;
            // 
            // AddBookForm_KAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 211);
            Controls.Add(buttonCancel_KAE);
            Controls.Add(buttonOk_KAE);
            Controls.Add(numericYear_KAE);
            Controls.Add(textBoxGenre_KAE);
            Controls.Add(textBoxAuthor_KAE);
            Controls.Add(textBoxTitle_KAE);
            Controls.Add(labelGenre_KAE);
            Controls.Add(labelYear_KAE);
            Controls.Add(labelAuthor_KAE);
            Controls.Add(labelTitle_KAE);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddBookForm_KAE";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить книгу - Кажахметов А.Е.";
            Load += AddBookForm_KAE_Load;
            ((System.ComponentModel.ISupportInitialize)numericYear_KAE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle_KAE;
        private Label labelAuthor_KAE;
        private Label labelYear_KAE;
        private Label labelGenre_KAE;
        private TextBox textBoxTitle_KAE;
        private TextBox textBoxAuthor_KAE;
        private TextBox textBoxGenre_KAE;
        private NumericUpDown numericYear_KAE;
        private Button buttonOk_KAE;
        private Button buttonCancel_KAE;
    }
}
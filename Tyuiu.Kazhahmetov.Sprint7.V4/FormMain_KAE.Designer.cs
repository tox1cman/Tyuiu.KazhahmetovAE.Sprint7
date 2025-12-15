namespace Tyuiu.Kazhahmetov.Sprint7.V4
{
    partial class FormMain_KAE
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitleBooks_KAE = new Label();
            listBoxBooks_KAE = new ListBox();
            buttonAddBook_KAE = new Button();
            labelBookCount_KAE = new Label();
            SuspendLayout();
            // 
            // labelTitleBooks_KAE
            // 
            labelTitleBooks_KAE.AutoSize = true;
            labelTitleBooks_KAE.Font = new Font("Arial", 14F, FontStyle.Bold);
            labelTitleBooks_KAE.Location = new Point(20, 20);
            labelTitleBooks_KAE.Name = "labelTitleBooks_KAE";
            labelTitleBooks_KAE.Size = new Size(121, 22);
            labelTitleBooks_KAE.TabIndex = 0;
            labelTitleBooks_KAE.Text = "Мои книги: ";
            // 
            // listBoxBooks_KAE
            // 
            listBoxBooks_KAE.FormattingEnabled = true;
            listBoxBooks_KAE.ItemHeight = 15;
            listBoxBooks_KAE.Location = new Point(20, 60);
            listBoxBooks_KAE.Name = "listBoxBooks_KAE";
            listBoxBooks_KAE.Size = new Size(400, 244);
            listBoxBooks_KAE.TabIndex = 1;
            // 
            // buttonAddBook_KAE
            // 
            buttonAddBook_KAE.Location = new Point(20, 320);
            buttonAddBook_KAE.Name = "buttonAddBook_KAE";
            buttonAddBook_KAE.Size = new Size(150, 30);
            buttonAddBook_KAE.TabIndex = 2;
            buttonAddBook_KAE.Text = "➕ Добавить книгу";
            buttonAddBook_KAE.UseVisualStyleBackColor = true;
            buttonAddBook_KAE.Click += buttonAddBook_KAE_Click;
            // 
            // labelBookCount_KAE
            // 
            labelBookCount_KAE.AutoSize = true;
            labelBookCount_KAE.Location = new Point(200, 325);
            labelBookCount_KAE.Name = "labelBookCount_KAE";
            labelBookCount_KAE.Size = new Size(78, 15);
            labelBookCount_KAE.TabIndex = 3;
            labelBookCount_KAE.Text = "Всего книг: 0";
            // 
            // FormMain_KAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(labelBookCount_KAE);
            Controls.Add(buttonAddBook_KAE);
            Controls.Add(listBoxBooks_KAE);
            Controls.Add(labelTitleBooks_KAE);
            Name = "FormMain_KAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Моя библиотека - Кажахметов А.Е.";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitleBooks_KAE;
        private ListBox listBoxBooks_KAE;
        private Button buttonAddBook_KAE;
        private Label labelBookCount_KAE;
    }
}

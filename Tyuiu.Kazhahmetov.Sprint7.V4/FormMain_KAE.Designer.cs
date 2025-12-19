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
            menuStrip1 = new MenuStrip();
            сохранитьБиблиоткуToolStripMenuItem = new ToolStripMenuItem();
            fileMenuSave_KAE = new ToolStripMenuItem();
            fileMenuLoad_KAE = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            fileMenuExit_KAE = new ToolStripMenuItem();
            книгиToolStripMenuItem = new ToolStripMenuItem();
            booksMenuAdd_KAE = new ToolStripMenuItem();
            booksMenuDelete_KAE = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            helpMenuAbout_KAE = new ToolStripMenuItem();
            buttonDeleteBook_KAE = new Button();
            buttonSave_KAE = new Button();
            buttonLoad_KAE = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitleBooks_KAE
            // 
            labelTitleBooks_KAE.AutoSize = true;
            labelTitleBooks_KAE.Font = new Font("Arial", 14F, FontStyle.Bold);
            labelTitleBooks_KAE.Location = new Point(20, 29);
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
            labelBookCount_KAE.Location = new Point(21, 400);
            labelBookCount_KAE.Name = "labelBookCount_KAE";
            labelBookCount_KAE.Size = new Size(78, 15);
            labelBookCount_KAE.TabIndex = 3;
            labelBookCount_KAE.Text = "Всего книг: 0";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { сохранитьБиблиоткуToolStripMenuItem, книгиToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьБиблиоткуToolStripMenuItem
            // 
            сохранитьБиблиоткуToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileMenuSave_KAE, fileMenuLoad_KAE, toolStripMenuItem1, fileMenuExit_KAE });
            сохранитьБиблиоткуToolStripMenuItem.Name = "сохранитьБиблиоткуToolStripMenuItem";
            сохранитьБиблиоткуToolStripMenuItem.Size = new Size(48, 20);
            сохранитьБиблиоткуToolStripMenuItem.Text = "&Файл";
            // 
            // fileMenuSave_KAE
            // 
            fileMenuSave_KAE.Name = "fileMenuSave_KAE";
            fileMenuSave_KAE.ShortcutKeys = Keys.Control | Keys.S;
            fileMenuSave_KAE.Size = new Size(241, 22);
            fileMenuSave_KAE.Text = "&Сохранить библиотеку";
            fileMenuSave_KAE.Click += fileMenuSave_KAE_Click;
            // 
            // fileMenuLoad_KAE
            // 
            fileMenuLoad_KAE.Name = "fileMenuLoad_KAE";
            fileMenuLoad_KAE.ShortcutKeys = Keys.Control | Keys.O;
            fileMenuLoad_KAE.Size = new Size(241, 22);
            fileMenuLoad_KAE.Text = "&Загрузить библиотеку";
            fileMenuLoad_KAE.Click += fileMenuLoad_KAE_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(238, 6);
            // 
            // fileMenuExit_KAE
            // 
            fileMenuExit_KAE.Name = "fileMenuExit_KAE";
            fileMenuExit_KAE.ShortcutKeys = Keys.Alt | Keys.F4;
            fileMenuExit_KAE.Size = new Size(241, 22);
            fileMenuExit_KAE.Text = "&Выход";
            fileMenuExit_KAE.Click += fileMenuExit_KAE_Click;
            // 
            // книгиToolStripMenuItem
            // 
            книгиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { booksMenuAdd_KAE, booksMenuDelete_KAE });
            книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            книгиToolStripMenuItem.Size = new Size(52, 20);
            книгиToolStripMenuItem.Text = "&Книги";
            книгиToolStripMenuItem.Click += книгиToolStripMenuItem_Click;
            // 
            // booksMenuAdd_KAE
            // 
            booksMenuAdd_KAE.Name = "booksMenuAdd_KAE";
            booksMenuAdd_KAE.ShortcutKeys = Keys.Control | Keys.N;
            booksMenuAdd_KAE.Size = new Size(203, 22);
            booksMenuAdd_KAE.Text = "&Добавить книгу";
            booksMenuAdd_KAE.Click += booksMenuAdd_KAE_Click;
            // 
            // booksMenuDelete_KAE
            // 
            booksMenuDelete_KAE.Name = "booksMenuDelete_KAE";
            booksMenuDelete_KAE.ShortcutKeys = Keys.Delete;
            booksMenuDelete_KAE.Size = new Size(203, 22);
            booksMenuDelete_KAE.Text = "&Удалить книгу";
            booksMenuDelete_KAE.Click += booksMenuDelete_KAE_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpMenuAbout_KAE });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "&Справка";
            // 
            // helpMenuAbout_KAE
            // 
            helpMenuAbout_KAE.Name = "helpMenuAbout_KAE";
            helpMenuAbout_KAE.Size = new Size(149, 22);
            helpMenuAbout_KAE.Text = "&О программе";
            // 
            // buttonDeleteBook_KAE
            // 
            buttonDeleteBook_KAE.BackColor = Color.LightCoral;
            buttonDeleteBook_KAE.Location = new Point(176, 320);
            buttonDeleteBook_KAE.Name = "buttonDeleteBook_KAE";
            buttonDeleteBook_KAE.Size = new Size(85, 30);
            buttonDeleteBook_KAE.TabIndex = 5;
            buttonDeleteBook_KAE.Text = "🗑️ Удалить";
            buttonDeleteBook_KAE.UseVisualStyleBackColor = false;
            buttonDeleteBook_KAE.Click += buttonDeleteBook_KAE_Click;
            // 
            // buttonSave_KAE
            // 
            buttonSave_KAE.BackColor = Color.FromArgb(128, 255, 128);
            buttonSave_KAE.Location = new Point(20, 361);
            buttonSave_KAE.Name = "buttonSave_KAE";
            buttonSave_KAE.Size = new Size(100, 30);
            buttonSave_KAE.TabIndex = 6;
            buttonSave_KAE.Text = "💾 Сохранить";
            buttonSave_KAE.UseVisualStyleBackColor = false;
            buttonSave_KAE.Click += buttonSave_KAE_Click;
            // 
            // buttonLoad_KAE
            // 
            buttonLoad_KAE.BackColor = Color.FromArgb(128, 255, 255);
            buttonLoad_KAE.Location = new Point(126, 361);
            buttonLoad_KAE.Name = "buttonLoad_KAE";
            buttonLoad_KAE.Size = new Size(100, 30);
            buttonLoad_KAE.TabIndex = 7;
            buttonLoad_KAE.Text = "📂 Загрузить";
            buttonLoad_KAE.UseVisualStyleBackColor = false;
            buttonLoad_KAE.Click += buttonLoad_KAE_Click;
            // 
            // FormMain_KAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 427);
            Controls.Add(buttonLoad_KAE);
            Controls.Add(buttonSave_KAE);
            Controls.Add(buttonDeleteBook_KAE);
            Controls.Add(labelBookCount_KAE);
            Controls.Add(buttonAddBook_KAE);
            Controls.Add(listBoxBooks_KAE);
            Controls.Add(labelTitleBooks_KAE);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain_KAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Моя библиотека - Кажахметов А.Е.";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitleBooks_KAE;
        private ListBox listBoxBooks_KAE;
        private Button buttonAddBook_KAE;
        private Label labelBookCount_KAE;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem сохранитьБиблиоткуToolStripMenuItem;
        private ToolStripMenuItem загрузитьБиблиотекуCtrlOToolStripMenuItem;
        private ToolStripMenuItem fileMenuSave_KAE;
        private ToolStripMenuItem книгиToolStripMenuItem;
        private ToolStripMenuItem booksMenuAdd_KAE;
        private ToolStripMenuItem booksMenuDelete_KAE;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem helpMenuAbout_KAE;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem fileMenuExit_KAE;
        private Button buttonDeleteBook_KAE;
        private ToolStripMenuItem fileMenuLoad_KAE;
        private Button buttonSave_KAE;
        private Button buttonLoad_KAE;
    }
}

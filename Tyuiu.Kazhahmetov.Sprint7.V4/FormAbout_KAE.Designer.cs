namespace Tyuiu.Kazhahmetov.Sprint7.V4
{
    partial class FormAbout_KAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_KAE));
            pictureBox1 = new PictureBox();
            labelTitle_KAE = new Label();
            label1 = new Label();
            label2 = new Label();
            buttonAcceptForm_KAE = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 142);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelTitle_KAE
            // 
            labelTitle_KAE.AutoSize = true;
            labelTitle_KAE.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle_KAE.Location = new Point(66, 8);
            labelTitle_KAE.Name = "labelTitle_KAE";
            labelTitle_KAE.Size = new Size(250, 25);
            labelTitle_KAE.TabIndex = 1;
            labelTitle_KAE.Text = "📚 Библиотечная система";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 68);
            label1.Name = "label1";
            label1.Size = new Size(211, 60);
            label1.TabIndex = 2;
            label1.Text = "Версия: 1.0.0\r\nАвтор: Кажахметов Амир Ерболович\r\nГруппа: ПИНб-25-1\r\nВариант: 4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 206);
            label2.Name = "label2";
            label2.Size = new Size(314, 45);
            label2.TabIndex = 3;
            label2.Text = "Приложение для учета книг в библиотеке\r\nИспользует Windows Forms и CSV для хранения данных\r\n© 2025 Все права защищены. #mna";
            // 
            // buttonAcceptForm_KAE
            // 
            buttonAcceptForm_KAE.DialogResult = DialogResult.OK;
            buttonAcceptForm_KAE.Location = new Point(225, 152);
            buttonAcceptForm_KAE.Name = "buttonAcceptForm_KAE";
            buttonAcceptForm_KAE.Size = new Size(75, 23);
            buttonAcceptForm_KAE.TabIndex = 4;
            buttonAcceptForm_KAE.Text = "ОК";
            buttonAcceptForm_KAE.UseVisualStyleBackColor = true;
            buttonAcceptForm_KAE.Click += button1_Click;
            // 
            // FormAbout_KAE
            // 
            AcceptButton = buttonAcceptForm_KAE;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(buttonAcceptForm_KAE);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelTitle_KAE);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAbout_KAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelTitle_KAE;
        private Label label1;
        private Label label2;
        private Button buttonAcceptForm_KAE;
    }
}
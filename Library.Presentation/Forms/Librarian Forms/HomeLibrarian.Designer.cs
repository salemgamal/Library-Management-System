namespace Library.Presentation.Forms.Librarian_Forms
{
    partial class HomeLibrarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeLibrarian));
            btn_managment_HL = new Button();
            btn_reports_HL = new Button();
            btn_back = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_managment_HL
            // 
            btn_managment_HL.BackColor = Color.BurlyWood;
            btn_managment_HL.Cursor = Cursors.Hand;
            btn_managment_HL.FlatStyle = FlatStyle.Flat;
            btn_managment_HL.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn_managment_HL.Location = new Point(205, 126);
            btn_managment_HL.Name = "btn_managment_HL";
            btn_managment_HL.Size = new Size(419, 69);
            btn_managment_HL.TabIndex = 0;
            btn_managment_HL.Text = "Book Managment";
            btn_managment_HL.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_managment_HL.UseVisualStyleBackColor = false;
            btn_managment_HL.Click += btn_managment_HL_Click;
            // 
            // btn_reports_HL
            // 
            btn_reports_HL.BackColor = Color.BurlyWood;
            btn_reports_HL.Cursor = Cursors.Hand;
            btn_reports_HL.FlatStyle = FlatStyle.Flat;
            btn_reports_HL.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn_reports_HL.Location = new Point(205, 229);
            btn_reports_HL.Name = "btn_reports_HL";
            btn_reports_HL.Size = new Size(419, 69);
            btn_reports_HL.TabIndex = 1;
            btn_reports_HL.Text = "Borrow-Return";
            btn_reports_HL.UseVisualStyleBackColor = false;
            btn_reports_HL.Click += btn_reports_HL_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ActiveCaptionText;
            btn_back.Cursor = Cursors.Hand;
            btn_back.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn_back.ForeColor = SystemColors.ButtonFace;
            btn_back.Location = new Point(12, 391);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(125, 47);
            btn_back.TabIndex = 2;
            btn_back.Text = "Logout";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(536, 258);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.BurlyWood;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(754, 13);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // HomeLibrarian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(btn_reports_HL);
            Controls.Add(btn_managment_HL);
            Controls.Add(pictureBox1);
            Controls.Add(btn_back);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeLibrarian";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeLibrarian";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_managment_HL;
        private Button btn_reports_HL;
        private Button btn_back;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
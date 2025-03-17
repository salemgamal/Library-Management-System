namespace Library.Presentation.Admin
{
    partial class AdminDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoard));
            btn_Manage_Librarian_AD = new Button();
            btn_ManageMembers_AD = new Button();
            btn_ManageBooks_AD = new Button();
            btn_back_AD = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_Manage_Librarian_AD
            // 
            btn_Manage_Librarian_AD.BackColor = Color.BurlyWood;
            btn_Manage_Librarian_AD.Cursor = Cursors.Hand;
            btn_Manage_Librarian_AD.FlatStyle = FlatStyle.Flat;
            btn_Manage_Librarian_AD.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Manage_Librarian_AD.Location = new Point(82, 220);
            btn_Manage_Librarian_AD.Margin = new Padding(3, 4, 3, 4);
            btn_Manage_Librarian_AD.Name = "btn_Manage_Librarian_AD";
            btn_Manage_Librarian_AD.Size = new Size(270, 69);
            btn_Manage_Librarian_AD.TabIndex = 0;
            btn_Manage_Librarian_AD.Text = "Manage Librarian";
            btn_Manage_Librarian_AD.UseVisualStyleBackColor = false;
            btn_Manage_Librarian_AD.Click += btn_Manage_Librarian_AD_Click;
            // 
            // btn_ManageMembers_AD
            // 
            btn_ManageMembers_AD.BackColor = Color.BurlyWood;
            btn_ManageMembers_AD.Cursor = Cursors.Hand;
            btn_ManageMembers_AD.FlatStyle = FlatStyle.Flat;
            btn_ManageMembers_AD.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn_ManageMembers_AD.Location = new Point(82, 356);
            btn_ManageMembers_AD.Margin = new Padding(3, 4, 3, 4);
            btn_ManageMembers_AD.Name = "btn_ManageMembers_AD";
            btn_ManageMembers_AD.Size = new Size(270, 69);
            btn_ManageMembers_AD.TabIndex = 1;
            btn_ManageMembers_AD.Text = "Manage Members";
            btn_ManageMembers_AD.UseVisualStyleBackColor = false;
            btn_ManageMembers_AD.Click += btn_ManageMembers_AD_Click;
            // 
            // btn_ManageBooks_AD
            // 
            btn_ManageBooks_AD.BackColor = Color.BurlyWood;
            btn_ManageBooks_AD.Cursor = Cursors.Hand;
            btn_ManageBooks_AD.FlatStyle = FlatStyle.Flat;
            btn_ManageBooks_AD.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn_ManageBooks_AD.Location = new Point(391, 356);
            btn_ManageBooks_AD.Margin = new Padding(3, 4, 3, 4);
            btn_ManageBooks_AD.Name = "btn_ManageBooks_AD";
            btn_ManageBooks_AD.Size = new Size(270, 69);
            btn_ManageBooks_AD.TabIndex = 2;
            btn_ManageBooks_AD.Text = "Manage Books";
            btn_ManageBooks_AD.UseVisualStyleBackColor = false;
            btn_ManageBooks_AD.Click += btn_ManageBooks_AD_Click;
            // 
            // btn_back_AD
            // 
            btn_back_AD.BackColor = SystemColors.ActiveCaptionText;
            btn_back_AD.Cursor = Cursors.Hand;
            btn_back_AD.FlatStyle = FlatStyle.Flat;
            btn_back_AD.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn_back_AD.ForeColor = SystemColors.ButtonFace;
            btn_back_AD.Location = new Point(25, 520);
            btn_back_AD.Margin = new Padding(3, 4, 3, 4);
            btn_back_AD.Name = "btn_back_AD";
            btn_back_AD.Size = new Size(86, 43);
            btn_back_AD.TabIndex = 3;
            btn_back_AD.Text = "back";
            btn_back_AD.UseVisualStyleBackColor = false;
            btn_back_AD.Click += btn_back_AD_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.BurlyWood;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            button1.Location = new Point(391, 220);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(270, 69);
            button1.TabIndex = 4;
            button1.Text = "Manage Admins";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(190, 107);
            label1.Name = "label1";
            label1.Size = new Size(401, 53);
            label1.TabIndex = 5;
            label1.Text = "Admin DashBoard";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Tan;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(58, 107);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(621, 377);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Peru;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(658, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(706, 579);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btn_back_AD);
            Controls.Add(btn_ManageBooks_AD);
            Controls.Add(btn_ManageMembers_AD);
            Controls.Add(btn_Manage_Librarian_AD);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashBoard";
            Load += AdminDashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Manage_Librarian_AD;
        private Button btn_ManageMembers_AD;
        private Button btn_ManageBooks_AD;
        private Button btn_back_AD;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
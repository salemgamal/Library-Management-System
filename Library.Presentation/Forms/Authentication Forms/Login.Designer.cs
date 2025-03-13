namespace Library.Presentation.Forms.Authentication_Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btn_login_L = new Button();
            lbl_userName = new Label();
            lbl_pass = new Label();
            txt_userName_L = new TextBox();
            txt_pass_L = new TextBox();
            pictureBox_passEye = new PictureBox();
            btn_back_L = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_passEye).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login_L
            // 
            btn_login_L.BackColor = Color.Black;
            btn_login_L.FlatStyle = FlatStyle.Flat;
            btn_login_L.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login_L.ForeColor = SystemColors.ControlLightLight;
            btn_login_L.Location = new Point(139, 226);
            btn_login_L.Margin = new Padding(3, 2, 3, 2);
            btn_login_L.Name = "btn_login_L";
            btn_login_L.Size = new Size(103, 38);
            btn_login_L.TabIndex = 0;
            btn_login_L.Text = "Login";
            btn_login_L.UseVisualStyleBackColor = false;
            btn_login_L.Click += btn_login_L_Click;
            // 
            // lbl_userName
            // 
            lbl_userName.AutoSize = true;
            lbl_userName.BackColor = Color.Transparent;
            lbl_userName.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_userName.Location = new Point(21, 114);
            lbl_userName.Name = "lbl_userName";
            lbl_userName.Size = new Size(100, 24);
            lbl_userName.TabIndex = 1;
            lbl_userName.Text = "Username";
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.BackColor = Color.Transparent;
            lbl_pass.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            lbl_pass.Location = new Point(25, 170);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(96, 24);
            lbl_pass.TabIndex = 2;
            lbl_pass.Text = "Password";
            // 
            // txt_userName_L
            // 
            txt_userName_L.BackColor = Color.SeaShell;
            txt_userName_L.Location = new Point(139, 114);
            txt_userName_L.Margin = new Padding(3, 2, 3, 2);
            txt_userName_L.Name = "txt_userName_L";
            txt_userName_L.Size = new Size(174, 23);
            txt_userName_L.TabIndex = 3;
            // 
            // txt_pass_L
            // 
            txt_pass_L.BackColor = Color.SeaShell;
            txt_pass_L.Location = new Point(139, 171);
            txt_pass_L.Margin = new Padding(3, 2, 3, 2);
            txt_pass_L.Name = "txt_pass_L";
            txt_pass_L.PasswordChar = '●';
            txt_pass_L.Size = new Size(174, 23);
            txt_pass_L.TabIndex = 4;
            // 
            // pictureBox_passEye
            // 
            pictureBox_passEye.BackColor = Color.Transparent;
            pictureBox_passEye.Cursor = Cursors.Hand;
            pictureBox_passEye.Image = Properties.Resources.eyeclosed;
            pictureBox_passEye.Location = new Point(319, 174);
            pictureBox_passEye.Margin = new Padding(3, 2, 3, 2);
            pictureBox_passEye.Name = "pictureBox_passEye";
            pictureBox_passEye.Size = new Size(24, 20);
            pictureBox_passEye.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_passEye.TabIndex = 5;
            pictureBox_passEye.TabStop = false;
            pictureBox_passEye.Click += pictureBox_passEye_Click;
            // 
            // btn_back_L
            // 
            btn_back_L.BackColor = SystemColors.ActiveCaptionText;
            btn_back_L.FlatStyle = FlatStyle.Flat;
            btn_back_L.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back_L.ForeColor = SystemColors.ControlLightLight;
            btn_back_L.Location = new Point(24, 346);
            btn_back_L.Margin = new Padding(3, 2, 3, 2);
            btn_back_L.Name = "btn_back_L";
            btn_back_L.Size = new Size(104, 38);
            btn_back_L.TabIndex = 6;
            btn_back_L.Text = "Back";
            btn_back_L.UseVisualStyleBackColor = false;
            btn_back_L.Click += btn_back_L_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_login_L);
            panel1.Controls.Add(txt_pass_L);
            panel1.Controls.Add(lbl_pass);
            panel1.Controls.Add(pictureBox_passEye);
            panel1.Controls.Add(lbl_userName);
            panel1.Controls.Add(txt_userName_L);
            panel1.Location = new Point(152, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 279);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 55);
            label1.TabIndex = 6;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Peru;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(605, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(647, 404);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btn_back_L);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox_passEye).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_login_L;
        private Label lbl_userName;
        private Label lbl_pass;
        private TextBox txt_userName_L;
        private TextBox txt_pass_L;
        private PictureBox pictureBox_passEye;
        private Button btn_back_L;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
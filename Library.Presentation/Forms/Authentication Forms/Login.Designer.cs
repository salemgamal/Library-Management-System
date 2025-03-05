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
            btn_login_L = new Button();
            lbl_userName = new Label();
            lbl_pass = new Label();
            txt_userName_L = new TextBox();
            txt_pass_L = new TextBox();
            pictureBox_passEye = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_passEye).BeginInit();
            SuspendLayout();
            // 
            // btn_login_L
            // 
            btn_login_L.Location = new Point(324, 328);
            btn_login_L.Name = "btn_login_L";
            btn_login_L.Size = new Size(198, 37);
            btn_login_L.TabIndex = 0;
            btn_login_L.Text = "Login";
            btn_login_L.UseVisualStyleBackColor = true;
            btn_login_L.Click += btn_login_L_Click;
            // 
            // lbl_userName
            // 
            lbl_userName.AutoSize = true;
            lbl_userName.Location = new Point(204, 155);
            lbl_userName.Name = "lbl_userName";
            lbl_userName.Size = new Size(75, 20);
            lbl_userName.TabIndex = 1;
            lbl_userName.Text = "Username";
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Location = new Point(207, 229);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(70, 20);
            lbl_pass.TabIndex = 2;
            lbl_pass.Text = "Password";
            // 
            // txt_userName_L
            // 
            txt_userName_L.Location = new Point(324, 155);
            txt_userName_L.Name = "txt_userName_L";
            txt_userName_L.Size = new Size(198, 27);
            txt_userName_L.TabIndex = 3;
            // 
            // txt_pass_L
            // 
            txt_pass_L.Location = new Point(324, 216);
            txt_pass_L.Name = "txt_pass_L";
            txt_pass_L.PasswordChar = '●';
            txt_pass_L.Size = new Size(198, 27);
            txt_pass_L.TabIndex = 4;
            // 
            // pictureBox_passEye
            // 
            pictureBox_passEye.BackColor = Color.Transparent;
            pictureBox_passEye.Cursor = Cursors.Hand;
            pictureBox_passEye.Image = Properties.Resources.eyeclosed;
            pictureBox_passEye.Location = new Point(528, 216);
            pictureBox_passEye.Name = "pictureBox_passEye";
            pictureBox_passEye.Size = new Size(27, 27);
            pictureBox_passEye.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_passEye.TabIndex = 5;
            pictureBox_passEye.TabStop = false;
            pictureBox_passEye.Click += pictureBox_passEye_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox_passEye);
            Controls.Add(txt_pass_L);
            Controls.Add(txt_userName_L);
            Controls.Add(lbl_pass);
            Controls.Add(lbl_userName);
            Controls.Add(btn_login_L);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox_passEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login_L;
        private Label lbl_userName;
        private Label lbl_pass;
        private TextBox txt_userName_L;
        private TextBox txt_pass_L;
        private PictureBox pictureBox_passEye;
    }
}
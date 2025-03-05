namespace Library.Presentation.Forms.Authentication_Forms
{
    partial class Register
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
            lbl_name = new Label();
            lbl_userName_R = new Label();
            lbl_email_R = new Label();
            lbl_phone_R = new Label();
            lbl_pass_R = new Label();
            lbl_confirmPass_R = new Label();
            txt_name = new TextBox();
            txt_userName_R = new TextBox();
            txt_email_R = new TextBox();
            txt_phone_R = new TextBox();
            txt_pass_R = new TextBox();
            txt_confirmPass_R = new TextBox();
            btn_register_R = new Button();
            pictureBox_passEye = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_passEye).BeginInit();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(69, 44);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(49, 20);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Name";
            // 
            // lbl_userName_R
            // 
            lbl_userName_R.AutoSize = true;
            lbl_userName_R.Location = new Point(69, 101);
            lbl_userName_R.Name = "lbl_userName_R";
            lbl_userName_R.Size = new Size(75, 20);
            lbl_userName_R.TabIndex = 1;
            lbl_userName_R.Text = "Username";
            // 
            // lbl_email_R
            // 
            lbl_email_R.AutoSize = true;
            lbl_email_R.Location = new Point(69, 163);
            lbl_email_R.Name = "lbl_email_R";
            lbl_email_R.Size = new Size(46, 20);
            lbl_email_R.TabIndex = 2;
            lbl_email_R.Text = "Email";
            // 
            // lbl_phone_R
            // 
            lbl_phone_R.AutoSize = true;
            lbl_phone_R.Location = new Point(69, 221);
            lbl_phone_R.Name = "lbl_phone_R";
            lbl_phone_R.Size = new Size(50, 20);
            lbl_phone_R.TabIndex = 3;
            lbl_phone_R.Text = "Phone";
            // 
            // lbl_pass_R
            // 
            lbl_pass_R.AutoSize = true;
            lbl_pass_R.Location = new Point(69, 271);
            lbl_pass_R.Name = "lbl_pass_R";
            lbl_pass_R.Size = new Size(70, 20);
            lbl_pass_R.TabIndex = 4;
            lbl_pass_R.Text = "Password";
            // 
            // lbl_confirmPass_R
            // 
            lbl_confirmPass_R.AutoSize = true;
            lbl_confirmPass_R.Location = new Point(43, 318);
            lbl_confirmPass_R.Name = "lbl_confirmPass_R";
            lbl_confirmPass_R.Size = new Size(127, 20);
            lbl_confirmPass_R.TabIndex = 5;
            lbl_confirmPass_R.Text = "Confirm Password";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(176, 45);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(248, 27);
            txt_name.TabIndex = 6;
            // 
            // txt_userName_R
            // 
            txt_userName_R.Location = new Point(176, 98);
            txt_userName_R.Name = "txt_userName_R";
            txt_userName_R.Size = new Size(248, 27);
            txt_userName_R.TabIndex = 7;
            // 
            // txt_email_R
            // 
            txt_email_R.Location = new Point(176, 163);
            txt_email_R.Name = "txt_email_R";
            txt_email_R.Size = new Size(248, 27);
            txt_email_R.TabIndex = 8;
            // 
            // txt_phone_R
            // 
            txt_phone_R.Location = new Point(176, 221);
            txt_phone_R.Name = "txt_phone_R";
            txt_phone_R.Size = new Size(248, 27);
            txt_phone_R.TabIndex = 9;
            // 
            // txt_pass_R
            // 
            txt_pass_R.Location = new Point(176, 271);
            txt_pass_R.Name = "txt_pass_R";
            txt_pass_R.PasswordChar = '●';
            txt_pass_R.Size = new Size(248, 27);
            txt_pass_R.TabIndex = 10;
            // 
            // txt_confirmPass_R
            // 
            txt_confirmPass_R.Location = new Point(176, 318);
            txt_confirmPass_R.Name = "txt_confirmPass_R";
            txt_confirmPass_R.PasswordChar = '●';
            txt_confirmPass_R.Size = new Size(248, 27);
            txt_confirmPass_R.TabIndex = 11;
            // 
            // btn_register_R
            // 
            btn_register_R.Location = new Point(176, 379);
            btn_register_R.Name = "btn_register_R";
            btn_register_R.Size = new Size(248, 34);
            btn_register_R.TabIndex = 12;
            btn_register_R.Text = "Register";
            btn_register_R.UseVisualStyleBackColor = true;
            btn_register_R.Click += btn_register_R_Click;
            // 
            // pictureBox_passEye
            // 
            pictureBox_passEye.BackColor = Color.Transparent;
            pictureBox_passEye.Image = Properties.Resources.eyeclosed;
            pictureBox_passEye.Location = new Point(430, 271);
            pictureBox_passEye.Name = "pictureBox_passEye";
            pictureBox_passEye.Size = new Size(29, 24);
            pictureBox_passEye.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_passEye.TabIndex = 13;
            pictureBox_passEye.TabStop = false;
            pictureBox_passEye.Click += pictureBox_passEye_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox_passEye);
            Controls.Add(btn_register_R);
            Controls.Add(txt_confirmPass_R);
            Controls.Add(txt_pass_R);
            Controls.Add(txt_phone_R);
            Controls.Add(txt_email_R);
            Controls.Add(txt_userName_R);
            Controls.Add(txt_name);
            Controls.Add(lbl_confirmPass_R);
            Controls.Add(lbl_pass_R);
            Controls.Add(lbl_phone_R);
            Controls.Add(lbl_email_R);
            Controls.Add(lbl_userName_R);
            Controls.Add(lbl_name);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox_passEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_userName_R;
        private Label lbl_email_R;
        private Label lbl_phone_R;
        private Label lbl_pass_R;
        private Label lbl_confirmPass_R;
        private TextBox txt_name;
        private TextBox txt_userName_R;
        private TextBox txt_email_R;
        private TextBox txt_phone_R;
        private TextBox txt_pass_R;
        private TextBox txt_confirmPass_R;
        private Button btn_register_R;
        private PictureBox pictureBox_passEye;
    }
}
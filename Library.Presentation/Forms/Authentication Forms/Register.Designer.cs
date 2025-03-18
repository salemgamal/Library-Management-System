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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
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
            btn_back_R = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btn_clear_RF = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_passEye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.BackColor = Color.Transparent;
            lbl_name.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(405, 145);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(82, 31);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Name";
            // 
            // lbl_userName_R
            // 
            lbl_userName_R.AutoSize = true;
            lbl_userName_R.BackColor = Color.Transparent;
            lbl_userName_R.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            lbl_userName_R.Location = new Point(405, 196);
            lbl_userName_R.Name = "lbl_userName_R";
            lbl_userName_R.Size = new Size(132, 31);
            lbl_userName_R.TabIndex = 1;
            lbl_userName_R.Text = "Username";
            // 
            // lbl_email_R
            // 
            lbl_email_R.AutoSize = true;
            lbl_email_R.BackColor = Color.Transparent;
            lbl_email_R.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            lbl_email_R.Location = new Point(405, 260);
            lbl_email_R.Name = "lbl_email_R";
            lbl_email_R.Size = new Size(84, 31);
            lbl_email_R.TabIndex = 2;
            lbl_email_R.Text = "Email";
            // 
            // lbl_phone_R
            // 
            lbl_phone_R.AutoSize = true;
            lbl_phone_R.BackColor = Color.Transparent;
            lbl_phone_R.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            lbl_phone_R.Location = new Point(405, 319);
            lbl_phone_R.Name = "lbl_phone_R";
            lbl_phone_R.Size = new Size(87, 31);
            lbl_phone_R.TabIndex = 3;
            lbl_phone_R.Text = "Phone";
            // 
            // lbl_pass_R
            // 
            lbl_pass_R.AutoSize = true;
            lbl_pass_R.BackColor = Color.Transparent;
            lbl_pass_R.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            lbl_pass_R.Location = new Point(405, 367);
            lbl_pass_R.Name = "lbl_pass_R";
            lbl_pass_R.Size = new Size(127, 31);
            lbl_pass_R.TabIndex = 4;
            lbl_pass_R.Text = "Password";
            // 
            // lbl_confirmPass_R
            // 
            lbl_confirmPass_R.AutoSize = true;
            lbl_confirmPass_R.BackColor = Color.Transparent;
            lbl_confirmPass_R.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_confirmPass_R.Location = new Point(376, 416);
            lbl_confirmPass_R.Name = "lbl_confirmPass_R";
            lbl_confirmPass_R.Size = new Size(202, 26);
            lbl_confirmPass_R.TabIndex = 5;
            lbl_confirmPass_R.Text = "Confirm Password";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(575, 143);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(189, 27);
            txt_name.TabIndex = 6;
            // 
            // txt_userName_R
            // 
            txt_userName_R.Location = new Point(575, 196);
            txt_userName_R.Name = "txt_userName_R";
            txt_userName_R.Size = new Size(189, 27);
            txt_userName_R.TabIndex = 7;
            // 
            // txt_email_R
            // 
            txt_email_R.Location = new Point(575, 260);
            txt_email_R.Name = "txt_email_R";
            txt_email_R.Size = new Size(189, 27);
            txt_email_R.TabIndex = 8;
            // 
            // txt_phone_R
            // 
            txt_phone_R.Location = new Point(575, 319);
            txt_phone_R.Name = "txt_phone_R";
            txt_phone_R.Size = new Size(189, 27);
            txt_phone_R.TabIndex = 9;
            // 
            // txt_pass_R
            // 
            txt_pass_R.Location = new Point(575, 368);
            txt_pass_R.Name = "txt_pass_R";
            txt_pass_R.PasswordChar = '●';
            txt_pass_R.Size = new Size(189, 27);
            txt_pass_R.TabIndex = 10;
            // 
            // txt_confirmPass_R
            // 
            txt_confirmPass_R.Location = new Point(575, 415);
            txt_confirmPass_R.Name = "txt_confirmPass_R";
            txt_confirmPass_R.PasswordChar = '●';
            txt_confirmPass_R.Size = new Size(189, 27);
            txt_confirmPass_R.TabIndex = 11;
            // 
            // btn_register_R
            // 
            btn_register_R.BackColor = SystemColors.ActiveCaptionText;
            btn_register_R.Cursor = Cursors.Hand;
            btn_register_R.FlatStyle = FlatStyle.Flat;
            btn_register_R.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register_R.ForeColor = SystemColors.ControlLightLight;
            btn_register_R.Location = new Point(575, 479);
            btn_register_R.Name = "btn_register_R";
            btn_register_R.Size = new Size(121, 48);
            btn_register_R.TabIndex = 12;
            btn_register_R.Text = "Register";
            btn_register_R.UseVisualStyleBackColor = false;
            btn_register_R.Click += btn_register_R_Click;
            // 
            // pictureBox_passEye
            // 
            pictureBox_passEye.BackColor = Color.Transparent;
            pictureBox_passEye.Cursor = Cursors.Hand;
            pictureBox_passEye.Image = Properties.Resources.eyeclosed;
            pictureBox_passEye.Location = new Point(769, 368);
            pictureBox_passEye.Name = "pictureBox_passEye";
            pictureBox_passEye.Size = new Size(29, 31);
            pictureBox_passEye.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_passEye.TabIndex = 13;
            pictureBox_passEye.TabStop = false;
            pictureBox_passEye.Click += pictureBox_passEye_Click;
            // 
            // btn_back_R
            // 
            btn_back_R.BackColor = SystemColors.ActiveCaptionText;
            btn_back_R.Cursor = Cursors.Hand;
            btn_back_R.FlatStyle = FlatStyle.Flat;
            btn_back_R.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back_R.ForeColor = SystemColors.ControlLightLight;
            btn_back_R.Location = new Point(14, 504);
            btn_back_R.Name = "btn_back_R";
            btn_back_R.Size = new Size(95, 39);
            btn_back_R.TabIndex = 14;
            btn_back_R.Text = "Back";
            btn_back_R.UseVisualStyleBackColor = false;
            btn_back_R.Click += btn_back_R_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 560);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(478, 25);
            label1.Name = "label1";
            label1.Size = new Size(243, 68);
            label1.TabIndex = 16;
            label1.Text = "Register";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(758, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btn_clear_RF
            // 
            btn_clear_RF.BackColor = SystemColors.ActiveCaptionText;
            btn_clear_RF.Cursor = Cursors.Hand;
            btn_clear_RF.FlatStyle = FlatStyle.Flat;
            btn_clear_RF.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_clear_RF.ForeColor = SystemColors.ControlLightLight;
            btn_clear_RF.Location = new Point(702, 479);
            btn_clear_RF.Name = "btn_clear_RF";
            btn_clear_RF.Size = new Size(81, 45);
            btn_clear_RF.TabIndex = 18;
            btn_clear_RF.Text = "Clear";
            btn_clear_RF.UseVisualStyleBackColor = false;
            btn_clear_RF.Click += btn_clear_RF_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 557);
            Controls.Add(btn_clear_RF);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btn_back_R);
            Controls.Add(pictureBox1);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox_passEye).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button btn_back_R;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btn_clear_RF;
    }
}
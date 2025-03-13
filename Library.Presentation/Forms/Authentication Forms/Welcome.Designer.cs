namespace Library.Presentation.Forms.Authentication_Forms
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            btn_login_W = new Button();
            btn_register_W = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login_W
            // 
            btn_login_W.BackColor = Color.Wheat;
            btn_login_W.FlatStyle = FlatStyle.Flat;
            btn_login_W.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login_W.ForeColor = Color.FromArgb(128, 64, 0);
            btn_login_W.Location = new Point(579, 367);
            btn_login_W.Margin = new Padding(3, 2, 3, 2);
            btn_login_W.Name = "btn_login_W";
            btn_login_W.Size = new Size(101, 36);
            btn_login_W.TabIndex = 0;
            btn_login_W.Text = "Login";
            btn_login_W.UseVisualStyleBackColor = false;
            btn_login_W.Click += btn_login_W_Click;
            // 
            // btn_register_W
            // 
            btn_register_W.BackColor = Color.Wheat;
            btn_register_W.FlatStyle = FlatStyle.Flat;
            btn_register_W.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn_register_W.ForeColor = Color.FromArgb(128, 64, 0);
            btn_register_W.Location = new Point(29, 367);
            btn_register_W.Margin = new Padding(3, 2, 3, 2);
            btn_register_W.Name = "btn_register_W";
            btn_register_W.Size = new Size(105, 36);
            btn_register_W.TabIndex = 1;
            btn_register_W.Text = "Register";
            btn_register_W.UseVisualStyleBackColor = false;
            btn_register_W.Click += btn_register_W_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_register_W);
            panel1.Controls.Add(btn_login_W);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-7, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 444);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(645, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Linen;
            label1.Location = new Point(159, 26);
            label1.Name = "label1";
            label1.Size = new Size(376, 110);
            label1.TabIndex = 3;
            label1.Text = "WELCOME TO \r\nOUR LIBRARY\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(80, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(552, 408);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 429);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Welcome";
            Text = "Welcome";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_login_W;
        private Button btn_register_W;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
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
            btn_login_W.Location = new Point(662, 489);
            btn_login_W.Name = "btn_login_W";
            btn_login_W.Size = new Size(115, 48);
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
            btn_register_W.Location = new Point(33, 489);
            btn_register_W.Name = "btn_register_W";
            btn_register_W.Size = new Size(138, 48);
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
            panel1.Location = new Point(-8, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 592);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(737, 12);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 35);
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
            label1.Location = new Point(182, 35);
            label1.Name = "label1";
            label1.Size = new Size(471, 136);
            label1.TabIndex = 3;
            label1.Text = "WELCOME TO \r\nOUR LIBRARY\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(91, 113);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(631, 544);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 572);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
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
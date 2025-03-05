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
            btn_login_W = new Button();
            btn_register_W = new Button();
            SuspendLayout();
            // 
            // btn_login_W
            // 
            btn_login_W.Location = new Point(237, 137);
            btn_login_W.Name = "btn_login_W";
            btn_login_W.Size = new Size(312, 48);
            btn_login_W.TabIndex = 0;
            btn_login_W.Text = "Login";
            btn_login_W.UseVisualStyleBackColor = true;
            btn_login_W.Click += btn_login_W_Click;
            // 
            // btn_register_W
            // 
            btn_register_W.Location = new Point(237, 227);
            btn_register_W.Name = "btn_register_W";
            btn_register_W.Size = new Size(312, 48);
            btn_register_W.TabIndex = 1;
            btn_register_W.Text = "Register";
            btn_register_W.UseVisualStyleBackColor = true;
            btn_register_W.Click += btn_register_W_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_register_W);
            Controls.Add(btn_login_W);
            Name = "Welcome";
            Text = "Welcome";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_login_W;
        private Button btn_register_W;
    }
}
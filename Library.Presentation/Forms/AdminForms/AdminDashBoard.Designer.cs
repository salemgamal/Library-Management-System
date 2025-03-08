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
            btn_Manage_Librarian_AD = new Button();
            btn_ManageMembers_AD = new Button();
            btn_ManageBooks_AD = new Button();
            btn_back_AD = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_Manage_Librarian_AD
            // 
            btn_Manage_Librarian_AD.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Manage_Librarian_AD.Location = new Point(185, 95);
            btn_Manage_Librarian_AD.Margin = new Padding(3, 4, 3, 4);
            btn_Manage_Librarian_AD.Name = "btn_Manage_Librarian_AD";
            btn_Manage_Librarian_AD.Size = new Size(270, 69);
            btn_Manage_Librarian_AD.TabIndex = 0;
            btn_Manage_Librarian_AD.Text = "Manage Librarian";
            btn_Manage_Librarian_AD.UseVisualStyleBackColor = true;
            btn_Manage_Librarian_AD.Click += btn_Manage_Librarian_AD_Click;
            // 
            // btn_ManageMembers_AD
            // 
            btn_ManageMembers_AD.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ManageMembers_AD.Location = new Point(185, 289);
            btn_ManageMembers_AD.Margin = new Padding(3, 4, 3, 4);
            btn_ManageMembers_AD.Name = "btn_ManageMembers_AD";
            btn_ManageMembers_AD.Size = new Size(270, 69);
            btn_ManageMembers_AD.TabIndex = 1;
            btn_ManageMembers_AD.Text = "Manage Members";
            btn_ManageMembers_AD.UseVisualStyleBackColor = true;
            btn_ManageMembers_AD.Click += btn_ManageMembers_AD_Click;
            // 
            // btn_ManageBooks_AD
            // 
            btn_ManageBooks_AD.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ManageBooks_AD.Location = new Point(185, 395);
            btn_ManageBooks_AD.Margin = new Padding(3, 4, 3, 4);
            btn_ManageBooks_AD.Name = "btn_ManageBooks_AD";
            btn_ManageBooks_AD.Size = new Size(270, 69);
            btn_ManageBooks_AD.TabIndex = 2;
            btn_ManageBooks_AD.Text = "Manage Books";
            btn_ManageBooks_AD.UseVisualStyleBackColor = true;
            btn_ManageBooks_AD.Click += btn_ManageBooks_AD_Click;
            // 
            // btn_back_AD
            // 
            btn_back_AD.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back_AD.Location = new Point(25, 520);
            btn_back_AD.Margin = new Padding(3, 4, 3, 4);
            btn_back_AD.Name = "btn_back_AD";
            btn_back_AD.Size = new Size(86, 43);
            btn_back_AD.TabIndex = 3;
            btn_back_AD.Text = "back";
            btn_back_AD.UseVisualStyleBackColor = true;
            btn_back_AD.Click += btn_back_AD_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(185, 187);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(270, 69);
            button1.TabIndex = 4;
            button1.Text = "Manage Admins";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 579);
            Controls.Add(button1);
            Controls.Add(btn_back_AD);
            Controls.Add(btn_ManageBooks_AD);
            Controls.Add(btn_ManageMembers_AD);
            Controls.Add(btn_Manage_Librarian_AD);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminDashBoard";
            Text = "AdminDashBoard";
            Load += AdminDashBoard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Manage_Librarian_AD;
        private Button btn_ManageMembers_AD;
        private Button btn_ManageBooks_AD;
        private Button btn_back_AD;
        private Button button1;
    }
}
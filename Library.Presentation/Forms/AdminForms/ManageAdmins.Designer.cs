namespace Library.Presentation.Admin
{
    partial class ManageAdmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAdmins));
            hideIcon = new PictureBox();
            btn_back_ML = new Button();
            btn_delete_MA = new Button();
            btn_update_MA = new Button();
            btn_add_MA = new Button();
            cb_Role = new ComboBox();
            txt_Phone_MA = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txt_userPass_MA = new TextBox();
            label5 = new Label();
            txt_userEmail_MA = new TextBox();
            label4 = new Label();
            txt_Name_MA = new TextBox();
            label3 = new Label();
            txt_userName_MA = new TextBox();
            label2 = new Label();
            dgv_Admins = new DataGridView();
            label1 = new Label();
            showIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)hideIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Admins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showIcon).BeginInit();
            SuspendLayout();
            // 
            // hideIcon
            // 
            hideIcon.Image = (Image)resources.GetObject("hideIcon.Image");
            hideIcon.Location = new Point(646, 126);
            hideIcon.Name = "hideIcon";
            hideIcon.Size = new Size(24, 22);
            hideIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            hideIcon.TabIndex = 38;
            hideIcon.TabStop = false;
            hideIcon.Click += hideIcon_Click;
            // 
            // btn_back_ML
            // 
            btn_back_ML.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back_ML.Location = new Point(20, 381);
            btn_back_ML.Name = "btn_back_ML";
            btn_back_ML.Size = new Size(82, 29);
            btn_back_ML.TabIndex = 37;
            btn_back_ML.Text = "back";
            btn_back_ML.UseVisualStyleBackColor = true;
            btn_back_ML.Click += btn_back_ML_Click;
            // 
            // btn_delete_MA
            // 
            btn_delete_MA.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete_MA.Location = new Point(596, 379);
            btn_delete_MA.Name = "btn_delete_MA";
            btn_delete_MA.Size = new Size(75, 31);
            btn_delete_MA.TabIndex = 36;
            btn_delete_MA.Text = "Delete";
            btn_delete_MA.UseVisualStyleBackColor = true;
            btn_delete_MA.Click += btn_delete_MA_Click;
            // 
            // btn_update_MA
            // 
            btn_update_MA.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_MA.Location = new Point(501, 379);
            btn_update_MA.Name = "btn_update_MA";
            btn_update_MA.Size = new Size(75, 31);
            btn_update_MA.TabIndex = 35;
            btn_update_MA.Text = "update";
            btn_update_MA.UseVisualStyleBackColor = true;
            btn_update_MA.Click += btn_update_MA_Click;
            // 
            // btn_add_MA
            // 
            btn_add_MA.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_MA.Location = new Point(411, 379);
            btn_add_MA.Name = "btn_add_MA";
            btn_add_MA.Size = new Size(75, 31);
            btn_add_MA.TabIndex = 34;
            btn_add_MA.Text = "Add";
            btn_add_MA.UseVisualStyleBackColor = true;
            btn_add_MA.Click += btn_add_MA_Click;
            // 
            // cb_Role
            // 
            cb_Role.FormattingEnabled = true;
            cb_Role.Items.AddRange(new object[] { "Librarian", "Admin" });
            cb_Role.Location = new Point(515, 308);
            cb_Role.Name = "cb_Role";
            cb_Role.Size = new Size(155, 23);
            cb_Role.TabIndex = 33;
            // 
            // txt_Phone_MA
            // 
            txt_Phone_MA.Location = new Point(512, 263);
            txt_Phone_MA.Name = "txt_Phone_MA";
            txt_Phone_MA.Size = new Size(158, 23);
            txt_Phone_MA.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(420, 262);
            label7.Name = "label7";
            label7.Size = new Size(52, 19);
            label7.TabIndex = 31;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(424, 312);
            label6.Name = "label6";
            label6.Size = new Size(40, 19);
            label6.TabIndex = 30;
            label6.Text = "Role";
            // 
            // txt_userPass_MA
            // 
            txt_userPass_MA.Location = new Point(512, 125);
            txt_userPass_MA.Name = "txt_userPass_MA";
            txt_userPass_MA.PasswordChar = '●';
            txt_userPass_MA.Size = new Size(158, 23);
            txt_userPass_MA.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(420, 124);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 28;
            label5.Text = "Password";
            // 
            // txt_userEmail_MA
            // 
            txt_userEmail_MA.Location = new Point(512, 169);
            txt_userEmail_MA.Name = "txt_userEmail_MA";
            txt_userEmail_MA.Size = new Size(158, 23);
            txt_userEmail_MA.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(424, 217);
            label4.Name = "label4";
            label4.Size = new Size(49, 19);
            label4.TabIndex = 26;
            label4.Text = "Name";
            // 
            // txt_Name_MA
            // 
            txt_Name_MA.Location = new Point(512, 217);
            txt_Name_MA.Name = "txt_Name_MA";
            txt_Name_MA.Size = new Size(158, 23);
            txt_Name_MA.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(424, 169);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 24;
            label3.Text = "Email";
            // 
            // txt_userName_MA
            // 
            txt_userName_MA.Location = new Point(512, 82);
            txt_userName_MA.Name = "txt_userName_MA";
            txt_userName_MA.Size = new Size(158, 23);
            txt_userName_MA.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(420, 81);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 22;
            label2.Text = "UserName";
            // 
            // dgv_Admins
            // 
            dgv_Admins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Admins.Location = new Point(20, 90);
            dgv_Admins.Name = "dgv_Admins";
            dgv_Admins.Size = new Size(373, 256);
            dgv_Admins.TabIndex = 21;
            dgv_Admins.RowHeaderMouseDoubleClick += dgv_Admins_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 35);
            label1.TabIndex = 20;
            label1.Text = "Manage Admins";
            // 
            // showIcon
            // 
            showIcon.Image = (Image)resources.GetObject("showIcon.Image");
            showIcon.Location = new Point(646, 126);
            showIcon.Name = "showIcon";
            showIcon.Size = new Size(23, 22);
            showIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            showIcon.TabIndex = 39;
            showIcon.TabStop = false;
            showIcon.Click += showIcon_Click;
            // 
            // ManageAdmins
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 445);
            Controls.Add(showIcon);
            Controls.Add(hideIcon);
            Controls.Add(btn_back_ML);
            Controls.Add(btn_delete_MA);
            Controls.Add(btn_update_MA);
            Controls.Add(btn_add_MA);
            Controls.Add(cb_Role);
            Controls.Add(txt_Phone_MA);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txt_userPass_MA);
            Controls.Add(label5);
            Controls.Add(txt_userEmail_MA);
            Controls.Add(label4);
            Controls.Add(txt_Name_MA);
            Controls.Add(label3);
            Controls.Add(txt_userName_MA);
            Controls.Add(label2);
            Controls.Add(dgv_Admins);
            Controls.Add(label1);
            Name = "ManageAdmins";
            Text = "ManageAdmins";
            Load += ManageAdmins_Load;
            ((System.ComponentModel.ISupportInitialize)hideIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Admins).EndInit();
            ((System.ComponentModel.ISupportInitialize)showIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox hideIcon;
        private Button btn_back_ML;
        private Button btn_delete_MA;
        private Button btn_update_MA;
        private Button btn_add_MA;
        private ComboBox cb_Role;
        private TextBox txt_Phone_MA;
        private Label label7;
        private Label label6;
        private TextBox txt_userPass_MA;
        private Label label5;
        private TextBox txt_userEmail_MA;
        private Label label4;
        private TextBox txt_Name_MA;
        private Label label3;
        private TextBox txt_userName_MA;
        private Label label2;
        private DataGridView dgv_Admins;
        private Label label1;
        private PictureBox showIcon;
    }
}
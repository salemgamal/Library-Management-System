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
            btn_clear_MAF = new Button();
            ((System.ComponentModel.ISupportInitialize)hideIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Admins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showIcon).BeginInit();
            SuspendLayout();
            // 
            // hideIcon
            // 
            hideIcon.Image = (Image)resources.GetObject("hideIcon.Image");
            hideIcon.Location = new Point(738, 168);
            hideIcon.Margin = new Padding(3, 4, 3, 4);
            hideIcon.Name = "hideIcon";
            hideIcon.Size = new Size(27, 29);
            hideIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            hideIcon.TabIndex = 38;
            hideIcon.TabStop = false;
            hideIcon.Click += hideIcon_Click;
            // 
            // btn_back_ML
            // 
            btn_back_ML.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back_ML.Location = new Point(23, 508);
            btn_back_ML.Margin = new Padding(3, 4, 3, 4);
            btn_back_ML.Name = "btn_back_ML";
            btn_back_ML.Size = new Size(94, 39);
            btn_back_ML.TabIndex = 37;
            btn_back_ML.Text = "back";
            btn_back_ML.UseVisualStyleBackColor = true;
            btn_back_ML.Click += btn_back_ML_Click;
            // 
            // btn_delete_MA
            // 
            btn_delete_MA.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete_MA.Location = new Point(681, 505);
            btn_delete_MA.Margin = new Padding(3, 4, 3, 4);
            btn_delete_MA.Name = "btn_delete_MA";
            btn_delete_MA.Size = new Size(86, 41);
            btn_delete_MA.TabIndex = 36;
            btn_delete_MA.Text = "Delete";
            btn_delete_MA.UseVisualStyleBackColor = true;
            btn_delete_MA.Click += btn_delete_MA_Click;
            // 
            // btn_update_MA
            // 
            btn_update_MA.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_MA.Location = new Point(573, 505);
            btn_update_MA.Margin = new Padding(3, 4, 3, 4);
            btn_update_MA.Name = "btn_update_MA";
            btn_update_MA.Size = new Size(86, 41);
            btn_update_MA.TabIndex = 35;
            btn_update_MA.Text = "update";
            btn_update_MA.UseVisualStyleBackColor = true;
            btn_update_MA.Click += btn_update_MA_Click;
            // 
            // btn_add_MA
            // 
            btn_add_MA.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_MA.Location = new Point(470, 505);
            btn_add_MA.Margin = new Padding(3, 4, 3, 4);
            btn_add_MA.Name = "btn_add_MA";
            btn_add_MA.Size = new Size(86, 41);
            btn_add_MA.TabIndex = 34;
            btn_add_MA.Text = "Add";
            btn_add_MA.UseVisualStyleBackColor = true;
            btn_add_MA.Click += btn_add_MA_Click;
            // 
            // cb_Role
            // 
            cb_Role.FormattingEnabled = true;
            cb_Role.Items.AddRange(new object[] { "Librarian", "Admin" });
            cb_Role.Location = new Point(589, 411);
            cb_Role.Margin = new Padding(3, 4, 3, 4);
            cb_Role.Name = "cb_Role";
            cb_Role.Size = new Size(177, 28);
            cb_Role.TabIndex = 33;
            // 
            // txt_Phone_MA
            // 
            txt_Phone_MA.Location = new Point(585, 351);
            txt_Phone_MA.Margin = new Padding(3, 4, 3, 4);
            txt_Phone_MA.Name = "txt_Phone_MA";
            txt_Phone_MA.Size = new Size(180, 27);
            txt_Phone_MA.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(480, 349);
            label7.Name = "label7";
            label7.Size = new Size(67, 24);
            label7.TabIndex = 31;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(485, 416);
            label6.Name = "label6";
            label6.Size = new Size(50, 24);
            label6.TabIndex = 30;
            label6.Text = "Role";
            // 
            // txt_userPass_MA
            // 
            txt_userPass_MA.Location = new Point(585, 167);
            txt_userPass_MA.Margin = new Padding(3, 4, 3, 4);
            txt_userPass_MA.Name = "txt_userPass_MA";
            txt_userPass_MA.PasswordChar = '●';
            txt_userPass_MA.Size = new Size(180, 27);
            txt_userPass_MA.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(480, 165);
            label5.Name = "label5";
            label5.Size = new Size(98, 24);
            label5.TabIndex = 28;
            label5.Text = "Password";
            // 
            // txt_userEmail_MA
            // 
            txt_userEmail_MA.Location = new Point(585, 225);
            txt_userEmail_MA.Margin = new Padding(3, 4, 3, 4);
            txt_userEmail_MA.Name = "txt_userEmail_MA";
            txt_userEmail_MA.Size = new Size(180, 27);
            txt_userEmail_MA.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(485, 289);
            label4.Name = "label4";
            label4.Size = new Size(62, 24);
            label4.TabIndex = 26;
            label4.Text = "Name";
            // 
            // txt_Name_MA
            // 
            txt_Name_MA.Location = new Point(585, 289);
            txt_Name_MA.Margin = new Padding(3, 4, 3, 4);
            txt_Name_MA.Name = "txt_Name_MA";
            txt_Name_MA.Size = new Size(180, 27);
            txt_Name_MA.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(485, 225);
            label3.Name = "label3";
            label3.Size = new Size(63, 24);
            label3.TabIndex = 24;
            label3.Text = "Email";
            // 
            // txt_userName_MA
            // 
            txt_userName_MA.Location = new Point(585, 109);
            txt_userName_MA.Margin = new Padding(3, 4, 3, 4);
            txt_userName_MA.Name = "txt_userName_MA";
            txt_userName_MA.Size = new Size(180, 27);
            txt_userName_MA.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(480, 108);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 22;
            label2.Text = "UserName";
            // 
            // dgv_Admins
            // 
            dgv_Admins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Admins.Location = new Point(23, 120);
            dgv_Admins.Margin = new Padding(3, 4, 3, 4);
            dgv_Admins.Name = "dgv_Admins";
            dgv_Admins.RowHeadersWidth = 51;
            dgv_Admins.Size = new Size(426, 341);
            dgv_Admins.TabIndex = 21;
            dgv_Admins.RowHeaderMouseDoubleClick += dgv_Admins_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 12);
            label1.Name = "label1";
            label1.Size = new Size(276, 43);
            label1.TabIndex = 20;
            label1.Text = "Manage Admins";
            // 
            // showIcon
            // 
            showIcon.Image = (Image)resources.GetObject("showIcon.Image");
            showIcon.Location = new Point(738, 168);
            showIcon.Margin = new Padding(3, 4, 3, 4);
            showIcon.Name = "showIcon";
            showIcon.Size = new Size(26, 29);
            showIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            showIcon.TabIndex = 39;
            showIcon.TabStop = false;
            showIcon.Click += showIcon_Click;
            // 
            // btn_clear_MAF
            // 
            btn_clear_MAF.Location = new Point(585, 456);
            btn_clear_MAF.Name = "btn_clear_MAF";
            btn_clear_MAF.Size = new Size(94, 29);
            btn_clear_MAF.TabIndex = 40;
            btn_clear_MAF.Text = "clear";
            btn_clear_MAF.UseVisualStyleBackColor = true;
            btn_clear_MAF.Click += btn_clear_MAF_Click;
            // 
            // ManageAdmins
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 593);
            Controls.Add(btn_clear_MAF);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btn_clear_MAF;
    }
}
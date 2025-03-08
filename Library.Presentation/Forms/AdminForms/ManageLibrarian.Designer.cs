namespace Library.Presentation.Admin
{
    partial class ManageLibrarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLibrarian));
            label1 = new Label();
            dgv_Libraian = new DataGridView();
            label2 = new Label();
            txt_userName_ML = new TextBox();
            txt_Name_ML = new TextBox();
            label3 = new Label();
            txt_userEmail_ML = new TextBox();
            label4 = new Label();
            txt_userPass_ML = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txt_Phone_ML = new TextBox();
            label7 = new Label();
            cb_Role = new ComboBox();
            btn_add_ML = new Button();
            btn_update_ML = new Button();
            btn_delete_ML = new Button();
            btn_back_ML = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_manageLib_MLF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Libraian).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 29);
            label1.Name = "label1";
            label1.Size = new Size(308, 43);
            label1.TabIndex = 0;
            label1.Text = "Manage Librarian";
            // 
            // dgv_Libraian
            // 
            dgv_Libraian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Libraian.Location = new Point(14, 132);
            dgv_Libraian.Margin = new Padding(3, 4, 3, 4);
            dgv_Libraian.Name = "dgv_Libraian";
            dgv_Libraian.RowHeadersWidth = 51;
            dgv_Libraian.Size = new Size(426, 341);
            dgv_Libraian.TabIndex = 1;
            dgv_Libraian.RowHeaderMouseDoubleClick += dgv_Libraian_RowHeaderMouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(456, 132);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 2;
            label2.Text = "UserName";
            // 
            // txt_userName_ML
            // 
            txt_userName_ML.Location = new Point(561, 133);
            txt_userName_ML.Margin = new Padding(3, 4, 3, 4);
            txt_userName_ML.Name = "txt_userName_ML";
            txt_userName_ML.Size = new Size(180, 27);
            txt_userName_ML.TabIndex = 3;
            // 
            // txt_Name_ML
            // 
            txt_Name_ML.Location = new Point(561, 313);
            txt_Name_ML.Margin = new Padding(3, 4, 3, 4);
            txt_Name_ML.Name = "txt_Name_ML";
            txt_Name_ML.Size = new Size(180, 27);
            txt_Name_ML.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(461, 249);
            label3.Name = "label3";
            label3.Size = new Size(63, 24);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // txt_userEmail_ML
            // 
            txt_userEmail_ML.Location = new Point(561, 249);
            txt_userEmail_ML.Margin = new Padding(3, 4, 3, 4);
            txt_userEmail_ML.Name = "txt_userEmail_ML";
            txt_userEmail_ML.Size = new Size(180, 27);
            txt_userEmail_ML.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(461, 313);
            label4.Name = "label4";
            label4.Size = new Size(62, 24);
            label4.TabIndex = 6;
            label4.Text = "Name";
            // 
            // txt_userPass_ML
            // 
            txt_userPass_ML.Location = new Point(561, 191);
            txt_userPass_ML.Margin = new Padding(3, 4, 3, 4);
            txt_userPass_ML.Name = "txt_userPass_ML";
            txt_userPass_ML.PasswordChar = '●';
            txt_userPass_ML.Size = new Size(180, 27);
            txt_userPass_ML.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(456, 189);
            label5.Name = "label5";
            label5.Size = new Size(98, 24);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(461, 440);
            label6.Name = "label6";
            label6.Size = new Size(50, 24);
            label6.TabIndex = 10;
            label6.Text = "Role";
            // 
            // txt_Phone_ML
            // 
            txt_Phone_ML.Location = new Point(561, 375);
            txt_Phone_ML.Margin = new Padding(3, 4, 3, 4);
            txt_Phone_ML.Name = "txt_Phone_ML";
            txt_Phone_ML.Size = new Size(180, 27);
            txt_Phone_ML.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(456, 373);
            label7.Name = "label7";
            label7.Size = new Size(67, 24);
            label7.TabIndex = 12;
            label7.Text = "Phone";
            // 
            // cb_Role
            // 
            cb_Role.FormattingEnabled = true;
            cb_Role.Items.AddRange(new object[] { "Librarian", "Admin" });
            cb_Role.Location = new Point(565, 435);
            cb_Role.Margin = new Padding(3, 4, 3, 4);
            cb_Role.Name = "cb_Role";
            cb_Role.Size = new Size(177, 28);
            cb_Role.TabIndex = 14;
            // 
            // btn_add_ML
            // 
            btn_add_ML.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_ML.Location = new Point(446, 529);
            btn_add_ML.Margin = new Padding(3, 4, 3, 4);
            btn_add_ML.Name = "btn_add_ML";
            btn_add_ML.Size = new Size(86, 41);
            btn_add_ML.TabIndex = 15;
            btn_add_ML.Text = "Add";
            btn_add_ML.UseVisualStyleBackColor = true;
            btn_add_ML.Click += btn_add_ML_Click;
            // 
            // btn_update_ML
            // 
            btn_update_ML.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_ML.Location = new Point(549, 529);
            btn_update_ML.Margin = new Padding(3, 4, 3, 4);
            btn_update_ML.Name = "btn_update_ML";
            btn_update_ML.Size = new Size(86, 41);
            btn_update_ML.TabIndex = 16;
            btn_update_ML.Text = "update";
            btn_update_ML.UseVisualStyleBackColor = true;
            btn_update_ML.Click += btn_update_ML_Click;
            // 
            // btn_delete_ML
            // 
            btn_delete_ML.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete_ML.Location = new Point(657, 529);
            btn_delete_ML.Margin = new Padding(3, 4, 3, 4);
            btn_delete_ML.Name = "btn_delete_ML";
            btn_delete_ML.Size = new Size(86, 41);
            btn_delete_ML.TabIndex = 17;
            btn_delete_ML.Text = "Delete";
            btn_delete_ML.UseVisualStyleBackColor = true;
            btn_delete_ML.Click += btn_delete_ML_Click;
            // 
            // btn_back_ML
            // 
            btn_back_ML.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back_ML.Location = new Point(30, 583);
            btn_back_ML.Margin = new Padding(3, 4, 3, 4);
            btn_back_ML.Name = "btn_back_ML";
            btn_back_ML.Size = new Size(94, 39);
            btn_back_ML.TabIndex = 18;
            btn_back_ML.Text = "back";
            btn_back_ML.UseVisualStyleBackColor = true;
            btn_back_ML.Click += btn_back_ML_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(714, 192);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(714, 192);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btn_manageLib_MLF
            // 
            btn_manageLib_MLF.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_manageLib_MLF.Location = new Point(30, 529);
            btn_manageLib_MLF.Margin = new Padding(3, 4, 3, 4);
            btn_manageLib_MLF.Name = "btn_manageLib_MLF";
            btn_manageLib_MLF.Size = new Size(94, 39);
            btn_manageLib_MLF.TabIndex = 57;
            btn_manageLib_MLF.Text = "back";
            btn_manageLib_MLF.UseVisualStyleBackColor = true;
            btn_manageLib_MLF.Click += btn_manageLib_MLF_Click;
            // 
            // ManageLibrarian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 637);
            Controls.Add(btn_manageLib_MLF);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_back_ML);
            Controls.Add(btn_delete_ML);
            Controls.Add(btn_update_ML);
            Controls.Add(btn_add_ML);
            Controls.Add(cb_Role);
            Controls.Add(txt_Phone_ML);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txt_userPass_ML);
            Controls.Add(label5);
            Controls.Add(txt_userEmail_ML);
            Controls.Add(label4);
            Controls.Add(txt_Name_ML);
            Controls.Add(label3);
            Controls.Add(txt_userName_ML);
            Controls.Add(label2);
            Controls.Add(dgv_Libraian);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageLibrarian";
            Text = "ManageLibrarian";
            Load += ManageLibrarian_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Libraian).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_Libraian;
        private Label label2;
        private TextBox txt_userName_ML;
        private TextBox txt_Name_ML;
        private Label label3;
        private TextBox txt_userEmail_ML;
        private Label label4;
        private TextBox txt_userPass_ML;
        private Label label5;
        private Label label6;
        private TextBox txt_Phone_ML;
        private Label label7;
        private ComboBox cb_Role;
        private Button btn_add_ML;
        private Button btn_update_ML;
        private Button btn_delete_ML;
        private Button btn_back_ML;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_manageLib_MLF;
    }
}
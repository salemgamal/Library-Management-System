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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Libraian).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold);
            label1.Location = new Point(224, 16);
            label1.Name = "label1";
            label1.Size = new Size(504, 68);
            label1.TabIndex = 0;
            label1.Text = "Manage Librarian";
            // 
            // dgv_Libraian
            // 
            dgv_Libraian.BackgroundColor = Color.BurlyWood;
            dgv_Libraian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.PeachPuff;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_Libraian.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_Libraian.Location = new Point(14, 167);
            dgv_Libraian.Margin = new Padding(3, 4, 3, 4);
            dgv_Libraian.Name = "dgv_Libraian";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.Info;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_Libraian.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Libraian.RowHeadersWidth = 51;
            dgv_Libraian.Size = new Size(470, 341);
            dgv_Libraian.TabIndex = 1;
            dgv_Libraian.RowHeaderMouseDoubleClick += dgv_Libraian_RowHeaderMouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label2.Location = new Point(485, 173);
            label2.Name = "label2";
            label2.Size = new Size(137, 31);
            label2.TabIndex = 2;
            label2.Text = "UserName";
            // 
            // txt_userName_ML
            // 
            txt_userName_ML.Location = new Point(621, 173);
            txt_userName_ML.Margin = new Padding(3, 4, 3, 4);
            txt_userName_ML.Name = "txt_userName_ML";
            txt_userName_ML.Size = new Size(180, 27);
            txt_userName_ML.TabIndex = 3;
            // 
            // txt_Name_ML
            // 
            txt_Name_ML.Location = new Point(621, 353);
            txt_Name_ML.Margin = new Padding(3, 4, 3, 4);
            txt_Name_ML.Name = "txt_Name_ML";
            txt_Name_ML.Size = new Size(180, 27);
            txt_Name_ML.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label3.Location = new Point(490, 285);
            label3.Name = "label3";
            label3.Size = new Size(84, 31);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // txt_userEmail_ML
            // 
            txt_userEmail_ML.Location = new Point(621, 289);
            txt_userEmail_ML.Margin = new Padding(3, 4, 3, 4);
            txt_userEmail_ML.Name = "txt_userEmail_ML";
            txt_userEmail_ML.Size = new Size(180, 27);
            txt_userEmail_ML.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label4.Location = new Point(490, 353);
            label4.Name = "label4";
            label4.Size = new Size(82, 31);
            label4.TabIndex = 6;
            label4.Text = "Name";
            // 
            // txt_userPass_ML
            // 
            txt_userPass_ML.Location = new Point(621, 231);
            txt_userPass_ML.Margin = new Padding(3, 4, 3, 4);
            txt_userPass_ML.Name = "txt_userPass_ML";
            txt_userPass_ML.PasswordChar = '●';
            txt_userPass_ML.Size = new Size(180, 27);
            txt_userPass_ML.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label5.Location = new Point(488, 230);
            label5.Name = "label5";
            label5.Size = new Size(127, 31);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label6.Location = new Point(490, 475);
            label6.Name = "label6";
            label6.Size = new Size(68, 31);
            label6.TabIndex = 10;
            label6.Text = "Role";
            // 
            // txt_Phone_ML
            // 
            txt_Phone_ML.Location = new Point(621, 415);
            txt_Phone_ML.Margin = new Padding(3, 4, 3, 4);
            txt_Phone_ML.Name = "txt_Phone_ML";
            txt_Phone_ML.Size = new Size(180, 27);
            txt_Phone_ML.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label7.Location = new Point(490, 415);
            label7.Name = "label7";
            label7.Size = new Size(87, 31);
            label7.TabIndex = 12;
            label7.Text = "Phone";
            // 
            // cb_Role
            // 
            cb_Role.FormattingEnabled = true;
            cb_Role.Items.AddRange(new object[] { "Librarian", "Admin" });
            cb_Role.Location = new Point(624, 475);
            cb_Role.Margin = new Padding(3, 4, 3, 4);
            cb_Role.Name = "cb_Role";
            cb_Role.Size = new Size(177, 28);
            cb_Role.TabIndex = 14;
            // 
            // btn_add_ML
            // 
            btn_add_ML.BackColor = Color.Olive;
            btn_add_ML.Cursor = Cursors.Hand;
            btn_add_ML.FlatStyle = FlatStyle.Flat;
            btn_add_ML.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_ML.ForeColor = SystemColors.ButtonFace;
            btn_add_ML.Location = new Point(506, 571);
            btn_add_ML.Margin = new Padding(3, 4, 3, 4);
            btn_add_ML.Name = "btn_add_ML";
            btn_add_ML.Size = new Size(86, 42);
            btn_add_ML.TabIndex = 15;
            btn_add_ML.Text = "Add";
            btn_add_ML.UseVisualStyleBackColor = false;
            btn_add_ML.Click += btn_add_ML_Click;
            // 
            // btn_update_ML
            // 
            btn_update_ML.BackColor = Color.Goldenrod;
            btn_update_ML.Cursor = Cursors.Hand;
            btn_update_ML.FlatStyle = FlatStyle.Flat;
            btn_update_ML.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_ML.ForeColor = SystemColors.ControlLightLight;
            btn_update_ML.Location = new Point(609, 571);
            btn_update_ML.Margin = new Padding(3, 4, 3, 4);
            btn_update_ML.Name = "btn_update_ML";
            btn_update_ML.Size = new Size(103, 42);
            btn_update_ML.TabIndex = 16;
            btn_update_ML.Text = "update";
            btn_update_ML.UseVisualStyleBackColor = false;
            btn_update_ML.Click += btn_update_ML_Click;
            // 
            // btn_delete_ML
            // 
            btn_delete_ML.BackColor = Color.Firebrick;
            btn_delete_ML.Cursor = Cursors.Hand;
            btn_delete_ML.FlatStyle = FlatStyle.Flat;
            btn_delete_ML.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete_ML.ForeColor = SystemColors.ControlLightLight;
            btn_delete_ML.Location = new Point(718, 571);
            btn_delete_ML.Margin = new Padding(3, 4, 3, 4);
            btn_delete_ML.Name = "btn_delete_ML";
            btn_delete_ML.Size = new Size(86, 42);
            btn_delete_ML.TabIndex = 17;
            btn_delete_ML.Text = "Delete";
            btn_delete_ML.UseVisualStyleBackColor = false;
            btn_delete_ML.Click += btn_delete_ML_Click;
            // 
            // btn_back_ML
            // 
            btn_back_ML.BackColor = Color.BurlyWood;
            btn_back_ML.BackgroundImage = Properties.Resources.back_button_png_brown;
            btn_back_ML.BackgroundImageLayout = ImageLayout.Zoom;
            btn_back_ML.Cursor = Cursors.Hand;
            btn_back_ML.FlatStyle = FlatStyle.Flat;
            btn_back_ML.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back_ML.ForeColor = Color.Transparent;
            btn_back_ML.Location = new Point(26, 600);
            btn_back_ML.Margin = new Padding(3, 4, 3, 4);
            btn_back_ML.Name = "btn_back_ML";
            btn_back_ML.Size = new Size(66, 52);
            btn_back_ML.TabIndex = 18;
            btn_back_ML.UseVisualStyleBackColor = false;
            btn_back_ML.Click += btn_back_ML_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(799, 232);
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
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(799, 232);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(799, 16);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // ManageLibrarian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(840, 668);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageLibrarian";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageLibrarian";
            Load += ManageLibrarian_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Libraian).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox3;
    }
}
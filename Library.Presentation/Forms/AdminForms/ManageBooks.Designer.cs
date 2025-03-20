namespace Library.Presentation.Admin
{
    partial class ManageBooks
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooks));
            btn_back_ML = new Button();
            btn_delete_MB = new Button();
            btn_update_MB = new Button();
            btn_add_MB = new Button();
            txt_publish_MB = new TextBox();
            label7 = new Label();
            txt_author_MB = new TextBox();
            label5 = new Label();
            txt_ISBN_MB = new TextBox();
            label4 = new Label();
            txt_category_MB = new TextBox();
            label3 = new Label();
            txt_title_MB = new TextBox();
            label2 = new Label();
            dgv_books = new DataGridView();
            label1 = new Label();
            label6 = new Label();
            txt_QTY_MB = new NumericUpDown();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_books).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_QTY_MB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
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
            btn_back_ML.Location = new Point(827, 575);
            btn_back_ML.Margin = new Padding(3, 4, 3, 4);
            btn_back_ML.Name = "btn_back_ML";
            btn_back_ML.Size = new Size(67, 51);
            btn_back_ML.TabIndex = 56;
            btn_back_ML.UseVisualStyleBackColor = false;
            btn_back_ML.Click += btn_back_ML_Click;
            // 
            // btn_delete_MB
            // 
            btn_delete_MB.BackColor = Color.Firebrick;
            btn_delete_MB.Cursor = Cursors.Hand;
            btn_delete_MB.FlatStyle = FlatStyle.Flat;
            btn_delete_MB.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete_MB.ForeColor = SystemColors.ControlLightLight;
            btn_delete_MB.Location = new Point(312, 567);
            btn_delete_MB.Margin = new Padding(3, 4, 3, 4);
            btn_delete_MB.Name = "btn_delete_MB";
            btn_delete_MB.Size = new Size(103, 44);
            btn_delete_MB.TabIndex = 55;
            btn_delete_MB.Text = "Delete";
            btn_delete_MB.UseVisualStyleBackColor = false;
            btn_delete_MB.Click += btn_delete_MB_Click;
            // 
            // btn_update_MB
            // 
            btn_update_MB.BackColor = Color.Goldenrod;
            btn_update_MB.Cursor = Cursors.Hand;
            btn_update_MB.FlatStyle = FlatStyle.Flat;
            btn_update_MB.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_MB.ForeColor = SystemColors.ControlLightLight;
            btn_update_MB.Location = new Point(186, 567);
            btn_update_MB.Margin = new Padding(3, 4, 3, 4);
            btn_update_MB.Name = "btn_update_MB";
            btn_update_MB.Size = new Size(107, 44);
            btn_update_MB.TabIndex = 54;
            btn_update_MB.Text = "update";
            btn_update_MB.UseVisualStyleBackColor = false;
            btn_update_MB.Click += btn_update_MB_Click;
            // 
            // btn_add_MB
            // 
            btn_add_MB.BackColor = Color.Olive;
            btn_add_MB.Cursor = Cursors.Hand;
            btn_add_MB.FlatStyle = FlatStyle.Flat;
            btn_add_MB.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_MB.ForeColor = SystemColors.ControlLightLight;
            btn_add_MB.Location = new Point(61, 567);
            btn_add_MB.Margin = new Padding(3, 4, 3, 4);
            btn_add_MB.Name = "btn_add_MB";
            btn_add_MB.Size = new Size(101, 44);
            btn_add_MB.TabIndex = 53;
            btn_add_MB.Text = "Add";
            btn_add_MB.UseVisualStyleBackColor = false;
            btn_add_MB.Click += btn_add_MB_Click;
            // 
            // txt_publish_MB
            // 
            txt_publish_MB.Location = new Point(234, 417);
            txt_publish_MB.Margin = new Padding(3, 4, 3, 4);
            txt_publish_MB.Name = "txt_publish_MB";
            txt_publish_MB.Size = new Size(180, 27);
            txt_publish_MB.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label7.Location = new Point(34, 416);
            label7.Name = "label7";
            label7.Size = new Size(191, 31);
            label7.TabIndex = 51;
            label7.Text = "Published Year";
            // 
            // txt_author_MB
            // 
            txt_author_MB.Location = new Point(234, 233);
            txt_author_MB.Margin = new Padding(3, 4, 3, 4);
            txt_author_MB.Name = "txt_author_MB";
            txt_author_MB.Size = new Size(180, 27);
            txt_author_MB.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label5.Location = new Point(34, 227);
            label5.Name = "label5";
            label5.Size = new Size(98, 31);
            label5.TabIndex = 49;
            label5.Text = "Author";
            // 
            // txt_ISBN_MB
            // 
            txt_ISBN_MB.Location = new Point(234, 292);
            txt_ISBN_MB.Margin = new Padding(3, 4, 3, 4);
            txt_ISBN_MB.Name = "txt_ISBN_MB";
            txt_ISBN_MB.Size = new Size(180, 27);
            txt_ISBN_MB.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label4.Location = new Point(34, 355);
            label4.Name = "label4";
            label4.Size = new Size(121, 31);
            label4.TabIndex = 47;
            label4.Text = "Category";
            // 
            // txt_category_MB
            // 
            txt_category_MB.Location = new Point(234, 356);
            txt_category_MB.Margin = new Padding(3, 4, 3, 4);
            txt_category_MB.Name = "txt_category_MB";
            txt_category_MB.Size = new Size(180, 27);
            txt_category_MB.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label3.Location = new Point(36, 286);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 45;
            label3.Text = "ISBN";
            // 
            // txt_title_MB
            // 
            txt_title_MB.Location = new Point(234, 175);
            txt_title_MB.Margin = new Padding(3, 4, 3, 4);
            txt_title_MB.Name = "txt_title_MB";
            txt_title_MB.Size = new Size(180, 27);
            txt_title_MB.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label2.Location = new Point(36, 175);
            label2.Name = "label2";
            label2.Size = new Size(69, 31);
            label2.TabIndex = 43;
            label2.Text = "Title";
            // 
            // dgv_books
            // 
            dgv_books.BackgroundColor = Color.BurlyWood;
            dgv_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.PeachPuff;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_books.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_books.Location = new Point(442, 171);
            dgv_books.Margin = new Padding(3, 4, 3, 4);
            dgv_books.Name = "dgv_books";
            dgv_books.RowHeadersWidth = 51;
            dgv_books.Size = new Size(451, 343);
            dgv_books.TabIndex = 42;
            dgv_books.RowHeaderMouseDoubleClick += dgv_books_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold);
            label1.Location = new Point(274, 16);
            label1.Name = "label1";
            label1.Size = new Size(403, 68);
            label1.TabIndex = 41;
            label1.Text = "Manage Books";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label6.Location = new Point(36, 480);
            label6.Name = "label6";
            label6.Size = new Size(118, 31);
            label6.TabIndex = 59;
            label6.Text = "Quantity";
            // 
            // txt_QTY_MB
            // 
            txt_QTY_MB.Location = new Point(234, 481);
            txt_QTY_MB.Margin = new Padding(3, 4, 3, 4);
            txt_QTY_MB.Name = "txt_QTY_MB";
            txt_QTY_MB.Size = new Size(182, 27);
            txt_QTY_MB.TabIndex = 60;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(848, 16);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 61;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // ManageBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(907, 655);
            Controls.Add(pictureBox3);
            Controls.Add(txt_QTY_MB);
            Controls.Add(label6);
            Controls.Add(btn_back_ML);
            Controls.Add(btn_delete_MB);
            Controls.Add(btn_update_MB);
            Controls.Add(btn_add_MB);
            Controls.Add(txt_publish_MB);
            Controls.Add(label7);
            Controls.Add(txt_author_MB);
            Controls.Add(label5);
            Controls.Add(txt_ISBN_MB);
            Controls.Add(label4);
            Controls.Add(txt_category_MB);
            Controls.Add(label3);
            Controls.Add(txt_title_MB);
            Controls.Add(label2);
            Controls.Add(dgv_books);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageBooks";
            Load += ManageBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_books).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_QTY_MB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_back_ML;
        private Button btn_delete_MB;
        private Button btn_update_MB;
        private Button btn_add_MB;
        private TextBox txt_publish_MB;
        private Label label7;
        private TextBox txt_author_MB;
        private Label label5;
        private TextBox txt_ISBN_MB;
        private Label label4;
        private TextBox txt_category_MB;
        private Label label3;
        private TextBox txt_title_MB;
        private Label label2;
        private DataGridView dgv_books;
        private Label label1;
        private Label label6;
        private NumericUpDown txt_QTY_MB;
        private PictureBox pictureBox3;
    }
}
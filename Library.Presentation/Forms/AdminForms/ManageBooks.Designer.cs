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
            num_publish_MB = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgv_books).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_QTY_MB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_publish_MB).BeginInit();
            SuspendLayout();
            // 
            // btn_back_ML
            // 
            btn_back_ML.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back_ML.Location = new Point(66, 532);
            btn_back_ML.Margin = new Padding(3, 4, 3, 4);
            btn_back_ML.Name = "btn_back_ML";
            btn_back_ML.Size = new Size(94, 39);
            btn_back_ML.TabIndex = 56;
            btn_back_ML.Text = "back";
            btn_back_ML.UseVisualStyleBackColor = true;
            btn_back_ML.Click += btn_back_ML_Click;
            // 
            // btn_delete_MB
            // 
            btn_delete_MB.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete_MB.Location = new Point(727, 508);
            btn_delete_MB.Margin = new Padding(3, 4, 3, 4);
            btn_delete_MB.Name = "btn_delete_MB";
            btn_delete_MB.Size = new Size(86, 41);
            btn_delete_MB.TabIndex = 55;
            btn_delete_MB.Text = "Delete";
            btn_delete_MB.UseVisualStyleBackColor = true;
            btn_delete_MB.Click += btn_delete_MB_Click;
            // 
            // btn_update_MB
            // 
            btn_update_MB.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_MB.Location = new Point(601, 508);
            btn_update_MB.Margin = new Padding(3, 4, 3, 4);
            btn_update_MB.Name = "btn_update_MB";
            btn_update_MB.Size = new Size(107, 41);
            btn_update_MB.TabIndex = 54;
            btn_update_MB.Text = "update";
            btn_update_MB.UseVisualStyleBackColor = true;
            btn_update_MB.Click += btn_update_MB_Click;
            // 
            // btn_add_MB
            // 
            btn_add_MB.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_MB.Location = new Point(509, 508);
            btn_add_MB.Margin = new Padding(3, 4, 3, 4);
            btn_add_MB.Name = "btn_add_MB";
            btn_add_MB.Size = new Size(86, 41);
            btn_add_MB.TabIndex = 53;
            btn_add_MB.Text = "Add";
            btn_add_MB.UseVisualStyleBackColor = true;
            btn_add_MB.Click += btn_add_MB_Click;
            // 
            // txt_publish_MB
            // 
            txt_publish_MB.Location = new Point(632, 372);
            txt_publish_MB.Margin = new Padding(3, 4, 3, 4);
            txt_publish_MB.Name = "txt_publish_MB";
            txt_publish_MB.Size = new Size(180, 27);
            txt_publish_MB.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(489, 377);
            label7.Name = "label7";
            label7.Size = new Size(146, 24);
            label7.TabIndex = 51;
            label7.Text = "Published Year";
            // 
            // txt_author_MB
            // 
            txt_author_MB.Location = new Point(632, 188);
            txt_author_MB.Margin = new Padding(3, 4, 3, 4);
            txt_author_MB.Name = "txt_author_MB";
            txt_author_MB.Size = new Size(180, 27);
            txt_author_MB.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(489, 188);
            label5.Name = "label5";
            label5.Size = new Size(74, 24);
            label5.TabIndex = 49;
            label5.Text = "Author";
            // 
            // txt_ISBN_MB
            // 
            txt_ISBN_MB.Location = new Point(632, 247);
            txt_ISBN_MB.Margin = new Padding(3, 4, 3, 4);
            txt_ISBN_MB.Name = "txt_ISBN_MB";
            txt_ISBN_MB.Size = new Size(180, 27);
            txt_ISBN_MB.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(489, 316);
            label4.Name = "label4";
            label4.Size = new Size(93, 24);
            label4.TabIndex = 47;
            label4.Text = "Category";
            // 
            // txt_category_MB
            // 
            txt_category_MB.Location = new Point(632, 311);
            txt_category_MB.Margin = new Padding(3, 4, 3, 4);
            txt_category_MB.Name = "txt_category_MB";
            txt_category_MB.Size = new Size(180, 27);
            txt_category_MB.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(490, 247);
            label3.Name = "label3";
            label3.Size = new Size(55, 24);
            label3.TabIndex = 45;
            label3.Text = "ISBN";
            // 
            // txt_title_MB
            // 
            txt_title_MB.Location = new Point(632, 129);
            txt_title_MB.Margin = new Padding(3, 4, 3, 4);
            txt_title_MB.Name = "txt_title_MB";
            txt_title_MB.Size = new Size(180, 27);
            txt_title_MB.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(490, 136);
            label2.Name = "label2";
            label2.Size = new Size(53, 24);
            label2.TabIndex = 43;
            label2.Text = "Title";
            // 
            // dgv_books
            // 
            dgv_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_books.Location = new Point(40, 129);
            dgv_books.Margin = new Padding(3, 4, 3, 4);
            dgv_books.Name = "dgv_books";
            dgv_books.RowHeadersWidth = 51;
            dgv_books.Size = new Size(426, 341);
            dgv_books.TabIndex = 42;
            dgv_books.RowHeaderMouseDoubleClick += dgv_books_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 12);
            label1.Name = "label1";
            label1.Size = new Size(308, 43);
            label1.TabIndex = 41;
            label1.Text = "Manage Librarian";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(490, 441);
            label6.Name = "label6";
            label6.Size = new Size(92, 24);
            label6.TabIndex = 59;
            label6.Text = "Quantity";
            // 
            // txt_QTY_MB
            // 
            txt_QTY_MB.Location = new Point(632, 436);
            txt_QTY_MB.Margin = new Padding(3, 4, 3, 4);
            txt_QTY_MB.Name = "txt_QTY_MB";
            txt_QTY_MB.Size = new Size(182, 27);
            txt_QTY_MB.TabIndex = 60;
            // 
            // num_publish_MB
            // 
            num_publish_MB.Location = new Point(630, 348);
            num_publish_MB.Name = "num_publish_MB";
            num_publish_MB.Size = new Size(150, 27);
            num_publish_MB.TabIndex = 61;
            // 
            // ManageBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 580);
            Controls.Add(num_publish_MB);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageBooks";
            Text = "ManageBooks";
            Load += ManageBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_books).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_QTY_MB).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_publish_MB).EndInit();
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
        private NumericUpDown num_publish_MB;
    }
}
namespace Library.Presentation.Forms.Librarian_Forms
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
            lbl_search_LF = new Label();
            txt_search_LF = new TextBox();
            dgv_all_MB = new DataGridView();
            btn_search_LF = new Button();
            btn_add_LF = new Button();
            btn_available_LF = new Button();
            btn_borrowed_LF = new Button();
            btn_overDue_LF = new Button();
            btn_edit_LF = new Button();
            btn_delete = new Button();
            lbl_categories_LF = new Label();
            cmbBox_categories_LF = new ComboBox();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgv_all_MB).BeginInit();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_search_LF
            // 
            lbl_search_LF.AutoSize = true;
            lbl_search_LF.Location = new Point(35, 140);
            lbl_search_LF.Name = "lbl_search_LF";
            lbl_search_LF.Size = new Size(53, 20);
            lbl_search_LF.TabIndex = 0;
            lbl_search_LF.Text = "Search";
            // 
            // txt_search_LF
            // 
            txt_search_LF.Location = new Point(119, 133);
            txt_search_LF.Name = "txt_search_LF";
            txt_search_LF.Size = new Size(369, 27);
            txt_search_LF.TabIndex = 1;
            // 
            // dgv_all_MB
            // 
            dgv_all_MB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_all_MB.Location = new Point(3, 3);
            dgv_all_MB.Name = "dgv_all_MB";
            dgv_all_MB.RowHeadersWidth = 51;
            dgv_all_MB.Size = new Size(719, 328);
            dgv_all_MB.TabIndex = 2;
            dgv_all_MB.RowHeaderMouseDoubleClick += dgv_search_LF_RowHeaderMouseDoubleClick;
            // 
            // btn_search_LF
            // 
            btn_search_LF.Location = new Point(494, 125);
            btn_search_LF.Name = "btn_search_LF";
            btn_search_LF.Size = new Size(65, 42);
            btn_search_LF.TabIndex = 3;
            btn_search_LF.Text = "Search";
            btn_search_LF.UseVisualStyleBackColor = true;
            btn_search_LF.Click += btn_search_LF_Click;
            // 
            // btn_add_LF
            // 
            btn_add_LF.Location = new Point(31, 550);
            btn_add_LF.Name = "btn_add_LF";
            btn_add_LF.Size = new Size(115, 35);
            btn_add_LF.TabIndex = 6;
            btn_add_LF.Text = "Add";
            btn_add_LF.UseVisualStyleBackColor = true;
            btn_add_LF.Click += btn_add_LF_Click;
            // 
            // btn_available_LF
            // 
            btn_available_LF.Location = new Point(98, 16);
            btn_available_LF.Name = "btn_available_LF";
            btn_available_LF.Size = new Size(129, 77);
            btn_available_LF.TabIndex = 7;
            btn_available_LF.Text = "Available Books";
            btn_available_LF.UseVisualStyleBackColor = true;
            btn_available_LF.Click += btn_available_LF_Click;
            // 
            // btn_borrowed_LF
            // 
            btn_borrowed_LF.Location = new Point(264, 17);
            btn_borrowed_LF.Name = "btn_borrowed_LF";
            btn_borrowed_LF.Size = new Size(110, 76);
            btn_borrowed_LF.TabIndex = 8;
            btn_borrowed_LF.Text = "Borrowed Books";
            btn_borrowed_LF.UseVisualStyleBackColor = true;
            btn_borrowed_LF.Click += btn_borrowed_LF_Click;
            // 
            // btn_overDue_LF
            // 
            btn_overDue_LF.Location = new Point(425, 17);
            btn_overDue_LF.Name = "btn_overDue_LF";
            btn_overDue_LF.Size = new Size(108, 76);
            btn_overDue_LF.TabIndex = 9;
            btn_overDue_LF.Text = "Over Due Books";
            btn_overDue_LF.UseVisualStyleBackColor = true;
            btn_overDue_LF.Click += btn_overDue_LF_Click;
            // 
            // btn_edit_LF
            // 
            btn_edit_LF.Location = new Point(201, 550);
            btn_edit_LF.Name = "btn_edit_LF";
            btn_edit_LF.Size = new Size(94, 36);
            btn_edit_LF.TabIndex = 10;
            btn_edit_LF.Text = "Edit";
            btn_edit_LF.UseVisualStyleBackColor = true;
            btn_edit_LF.Click += btn_edit_LF_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(365, 550);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 36);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // lbl_categories_LF
            // 
            lbl_categories_LF.AutoSize = true;
            lbl_categories_LF.Location = new Point(584, 115);
            lbl_categories_LF.Name = "lbl_categories_LF";
            lbl_categories_LF.Size = new Size(69, 20);
            lbl_categories_LF.TabIndex = 20;
            lbl_categories_LF.Text = "Category";
            // 
            // cmbBox_categories_LF
            // 
            cmbBox_categories_LF.FormattingEnabled = true;
            cmbBox_categories_LF.Location = new Point(584, 138);
            cmbBox_categories_LF.Name = "cmbBox_categories_LF";
            cmbBox_categories_LF.Size = new Size(151, 28);
            cmbBox_categories_LF.TabIndex = 19;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Location = new Point(12, 169);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(736, 375);
            tabControl.TabIndex = 21;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgv_all_MB);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(728, 342);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "All";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(728, 342);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Available";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(719, 328);
            dataGridView1.TabIndex = 22;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(728, 342);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Borrowed";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(728, 342);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Over Due";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // ManageBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 615);
            Controls.Add(tabControl);
            Controls.Add(lbl_categories_LF);
            Controls.Add(cmbBox_categories_LF);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit_LF);
            Controls.Add(btn_overDue_LF);
            Controls.Add(btn_borrowed_LF);
            Controls.Add(btn_available_LF);
            Controls.Add(btn_add_LF);
            Controls.Add(btn_search_LF);
            Controls.Add(txt_search_LF);
            Controls.Add(lbl_search_LF);
            Name = "ManageBooks";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_all_MB).EndInit();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_search_LF;
        private TextBox txt_search_LF;
        private DataGridView dgv_all_MB;
        private Button btn_search_LF;
        private Button btn_add_LF;
        private Button btn_available_LF;
        private Button btn_borrowed_LF;
        private Button btn_overDue_LF;
        private Button btn_edit_LF;
        private Button btn_delete;
        private Label lbl_categories_LF;
        private ComboBox cmbBox_categories_LF;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private TabPage tabPage3;
        private TabPage tabPage4;
    }
}
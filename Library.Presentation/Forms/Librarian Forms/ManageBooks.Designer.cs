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
            btn_edit_LF = new Button();
            btn_delete = new Button();
            lbl_categories_LF = new Label();
            cmbBox_categories_LF = new ComboBox();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            btn_back = new Button();
            btn_clearMB = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_all_MB).BeginInit();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_search_LF
            // 
            lbl_search_LF.AutoSize = true;
            lbl_search_LF.Location = new Point(9, 34);
            lbl_search_LF.Name = "lbl_search_LF";
            lbl_search_LF.Size = new Size(53, 20);
            lbl_search_LF.TabIndex = 0;
            lbl_search_LF.Text = "Search";
            // 
            // txt_search_LF
            // 
            txt_search_LF.Location = new Point(68, 31);
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
            dgv_all_MB.Size = new Size(719, 429);
            dgv_all_MB.TabIndex = 2;
            dgv_all_MB.RowHeaderMouseDoubleClick += DataGridView_RowHeaderMouseDoubleClick;
            // 
            // btn_search_LF
            // 
            btn_search_LF.Location = new Point(443, 25);
            btn_search_LF.Name = "btn_search_LF";
            btn_search_LF.Size = new Size(65, 42);
            btn_search_LF.TabIndex = 3;
            btn_search_LF.Text = "Search";
            btn_search_LF.UseVisualStyleBackColor = true;
            btn_search_LF.Click += btn_search_LF_Click;
            // 
            // btn_add_LF
            // 
            btn_add_LF.Location = new Point(329, 554);
            btn_add_LF.Name = "btn_add_LF";
            btn_add_LF.Size = new Size(115, 35);
            btn_add_LF.TabIndex = 6;
            btn_add_LF.Text = "Add";
            btn_add_LF.UseVisualStyleBackColor = true;
            btn_add_LF.Click += btn_add_LF_Click;
            // 
            // btn_edit_LF
            // 
            btn_edit_LF.Location = new Point(499, 554);
            btn_edit_LF.Name = "btn_edit_LF";
            btn_edit_LF.Size = new Size(94, 36);
            btn_edit_LF.TabIndex = 10;
            btn_edit_LF.Text = "Edit";
            btn_edit_LF.UseVisualStyleBackColor = true;
            btn_edit_LF.Click += btn_edit_LF_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(663, 554);
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
            lbl_categories_LF.Location = new Point(514, 16);
            lbl_categories_LF.Name = "lbl_categories_LF";
            lbl_categories_LF.Size = new Size(69, 20);
            lbl_categories_LF.TabIndex = 20;
            lbl_categories_LF.Text = "Category";
            // 
            // cmbBox_categories_LF
            // 
            cmbBox_categories_LF.FormattingEnabled = true;
            cmbBox_categories_LF.Location = new Point(514, 39);
            cmbBox_categories_LF.Name = "cmbBox_categories_LF";
            cmbBox_categories_LF.Size = new Size(151, 28);
            cmbBox_categories_LF.TabIndex = 19;
            cmbBox_categories_LF.SelectedIndexChanged += btn_search_LF_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Location = new Point(12, 73);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(736, 471);
            tabControl.TabIndex = 21;
            tabControl.SelectedIndexChanged += btn_search_LF_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgv_all_MB);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(728, 438);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "All Books";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(19, 561);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 22;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_clearMB
            // 
            btn_clearMB.Location = new Point(691, 38);
            btn_clearMB.Name = "btn_clearMB";
            btn_clearMB.Size = new Size(66, 29);
            btn_clearMB.TabIndex = 23;
            btn_clearMB.Text = "Clear";
            btn_clearMB.UseVisualStyleBackColor = true;
            btn_clearMB.Click += btn_clearMB_Click;
            // 
            // ManageBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 615);
            Controls.Add(btn_clearMB);
            Controls.Add(btn_back);
            Controls.Add(tabControl);
            Controls.Add(lbl_categories_LF);
            Controls.Add(cmbBox_categories_LF);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit_LF);
            Controls.Add(btn_add_LF);
            Controls.Add(btn_search_LF);
            Controls.Add(txt_search_LF);
            Controls.Add(lbl_search_LF);
            Name = "ManageBooks";
            Text = "Form1";
            Load += ManageBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_all_MB).EndInit();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_search_LF;
        private TextBox txt_search_LF;
        private DataGridView dgv_all_MB;
        private Button btn_search_LF;
        private Button btn_add_LF;
        private Button btn_edit_LF;
        private Button btn_delete;
        private Label lbl_categories_LF;
        private ComboBox cmbBox_categories_LF;
        private TabControl tabControl;
        private TabPage tabPage1;
        private Button btn_back;
        private Button btn_clearMB;
    }
}
namespace Library.Presentation.Forms.Librarian_Forms
{
    partial class BorrowReturn
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            dgv_borrowed_BR = new DataGridView();
            tabPage2 = new TabPage();
            dgv_overDue_MB = new DataGridView();
            lbl_categories_BR = new Label();
            cmbBox_categories_BR = new ComboBox();
            btn_search_BR = new Button();
            txt_search_BR = new TextBox();
            lbl_search_BR = new Label();
            btn_generateReport = new Button();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_borrowed_BR).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_overDue_MB).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(73, 60);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(736, 471);
            tabControl.TabIndex = 27;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgv_borrowed_BR);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(728, 438);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Borrowed";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_borrowed_BR
            // 
            dgv_borrowed_BR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_borrowed_BR.Location = new Point(3, 3);
            dgv_borrowed_BR.Name = "dgv_borrowed_BR";
            dgv_borrowed_BR.RowHeadersWidth = 51;
            dgv_borrowed_BR.Size = new Size(719, 429);
            dgv_borrowed_BR.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgv_overDue_MB);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(728, 438);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Over Due";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_overDue_MB
            // 
            dgv_overDue_MB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_overDue_MB.Location = new Point(3, 3);
            dgv_overDue_MB.Name = "dgv_overDue_MB";
            dgv_overDue_MB.RowHeadersWidth = 51;
            dgv_overDue_MB.Size = new Size(719, 432);
            dgv_overDue_MB.TabIndex = 22;
            // 
            // lbl_categories_BR
            // 
            lbl_categories_BR.AutoSize = true;
            lbl_categories_BR.Location = new Point(642, 2);
            lbl_categories_BR.Name = "lbl_categories_BR";
            lbl_categories_BR.Size = new Size(69, 20);
            lbl_categories_BR.TabIndex = 26;
            lbl_categories_BR.Text = "Category";
            // 
            // cmbBox_categories_BR
            // 
            cmbBox_categories_BR.FormattingEnabled = true;
            cmbBox_categories_BR.Location = new Point(642, 25);
            cmbBox_categories_BR.Name = "cmbBox_categories_BR";
            cmbBox_categories_BR.Size = new Size(151, 28);
            cmbBox_categories_BR.TabIndex = 25;
            // 
            // btn_search_BR
            // 
            btn_search_BR.Location = new Point(552, 12);
            btn_search_BR.Name = "btn_search_BR";
            btn_search_BR.Size = new Size(65, 42);
            btn_search_BR.TabIndex = 24;
            btn_search_BR.Text = "Search";
            btn_search_BR.UseVisualStyleBackColor = true;
            btn_search_BR.Click += btn_search_BR_Click;
            // 
            // txt_search_BR
            // 
            txt_search_BR.Location = new Point(177, 20);
            txt_search_BR.Name = "txt_search_BR";
            txt_search_BR.Size = new Size(369, 27);
            txt_search_BR.TabIndex = 23;
            // 
            // lbl_search_BR
            // 
            lbl_search_BR.AutoSize = true;
            lbl_search_BR.Location = new Point(92, 20);
            lbl_search_BR.Name = "lbl_search_BR";
            lbl_search_BR.Size = new Size(53, 20);
            lbl_search_BR.TabIndex = 22;
            lbl_search_BR.Text = "Search";
            // 
            // btn_generateReport
            // 
            btn_generateReport.Location = new Point(619, 553);
            btn_generateReport.Name = "btn_generateReport";
            btn_generateReport.Size = new Size(180, 29);
            btn_generateReport.TabIndex = 28;
            btn_generateReport.Text = "Generate Report";
            btn_generateReport.UseVisualStyleBackColor = true;
            btn_generateReport.Click += btn_generateReport_Click;
            // 
            // BorrowReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 624);
            Controls.Add(btn_generateReport);
            Controls.Add(tabControl);
            Controls.Add(lbl_categories_BR);
            Controls.Add(cmbBox_categories_BR);
            Controls.Add(btn_search_BR);
            Controls.Add(txt_search_BR);
            Controls.Add(lbl_search_BR);
            Name = "BorrowReturn";
            Text = "BorrowReturn";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_borrowed_BR).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_overDue_MB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private DataGridView dgv_borrowed_BR;
        private TabPage tabPage2;
        private DataGridView dgv_overDue_MB;
        private Label lbl_categories_BR;
        private ComboBox cmbBox_categories_BR;
        private Button btn_search_BR;
        private TextBox txt_search_BR;
        private Label lbl_search_BR;
        private Button btn_generateReport;
    }
}
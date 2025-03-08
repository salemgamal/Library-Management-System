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
            tabPage3 = new TabPage();
            dgv_logActions_MB = new DataGridView();
            btn_search_BR = new Button();
            txt_search_BR = new TextBox();
            lbl_search_BR = new Label();
            btn_generateReport = new Button();
            dateTimePicker = new DateTimePicker();
            btn_clear = new Button();
            btn_back = new Button();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_borrowed_BR).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_overDue_MB).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_logActions_MB).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(73, 103);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(736, 494);
            tabControl.TabIndex = 27;
            tabControl.SelectedIndexChanged += btn_search_BR_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgv_borrowed_BR);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(728, 461);
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
            dgv_borrowed_BR.Size = new Size(719, 451);
            dgv_borrowed_BR.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgv_overDue_MB);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(728, 461);
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
            dgv_overDue_MB.Size = new Size(719, 451);
            dgv_overDue_MB.TabIndex = 22;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgv_logActions_MB);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(728, 461);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Log Actions";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_logActions_MB
            // 
            dgv_logActions_MB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_logActions_MB.Location = new Point(3, 3);
            dgv_logActions_MB.Name = "dgv_logActions_MB";
            dgv_logActions_MB.RowHeadersWidth = 51;
            dgv_logActions_MB.Size = new Size(722, 455);
            dgv_logActions_MB.TabIndex = 29;
            // 
            // btn_search_BR
            // 
            btn_search_BR.Location = new Point(535, 17);
            btn_search_BR.Name = "btn_search_BR";
            btn_search_BR.Size = new Size(65, 42);
            btn_search_BR.TabIndex = 24;
            btn_search_BR.Text = "Search";
            btn_search_BR.UseVisualStyleBackColor = true;
            btn_search_BR.Click += btn_search_BR_Click;
            // 
            // txt_search_BR
            // 
            txt_search_BR.Location = new Point(160, 25);
            txt_search_BR.Name = "txt_search_BR";
            txt_search_BR.Size = new Size(369, 27);
            txt_search_BR.TabIndex = 23;
            // 
            // lbl_search_BR
            // 
            lbl_search_BR.AutoSize = true;
            lbl_search_BR.Location = new Point(75, 25);
            lbl_search_BR.Name = "lbl_search_BR";
            lbl_search_BR.Size = new Size(53, 20);
            lbl_search_BR.TabIndex = 22;
            lbl_search_BR.Text = "Search";
            // 
            // btn_generateReport
            // 
            btn_generateReport.Location = new Point(610, 603);
            btn_generateReport.Name = "btn_generateReport";
            btn_generateReport.Size = new Size(192, 41);
            btn_generateReport.TabIndex = 28;
            btn_generateReport.Text = "Generate Report";
            btn_generateReport.UseVisualStyleBackColor = true;
            btn_generateReport.Click += btn_generateReport_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(160, 58);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(270, 27);
            dateTimePicker.TabIndex = 29;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(436, 58);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(62, 29);
            btn_clear.TabIndex = 30;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(30, 608);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 31;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // BorrowReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 656);
            Controls.Add(btn_back);
            Controls.Add(btn_clear);
            Controls.Add(dateTimePicker);
            Controls.Add(btn_generateReport);
            Controls.Add(tabControl);
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
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_logActions_MB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private DataGridView dgv_borrowed_BR;
        private TabPage tabPage2;
        private DataGridView dgv_overDue_MB;
        private Button btn_search_BR;
        private TextBox txt_search_BR;
        private Label lbl_search_BR;
        private Button btn_generateReport;
        private TabPage tabPage3;
        private DataGridView dgv_logActions_MB;
        private DateTimePicker dateTimePicker;
        private Button btn_clear;
        private Button btn_back;
    }
}
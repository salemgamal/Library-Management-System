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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowReturn));
            tabControl = new TabControl();
            tabBorrow = new TabPage();
            dgv_borrowed_BR = new DataGridView();
            tabAvailable = new TabPage();
            dgv_availbleBooks = new DataGridView();
            tabOverDue = new TabPage();
            dgv_overDue_MB = new DataGridView();
            tabLogActions = new TabPage();
            dgv_logActions_MB = new DataGridView();
            btn_search_BR = new Button();
            txt_search_BR = new TextBox();
            btn_generateReport = new Button();
            btn_clear = new Button();
            btn_back = new Button();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            tabControl.SuspendLayout();
            tabBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_borrowed_BR).BeginInit();
            tabAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_availbleBooks).BeginInit();
            tabOverDue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_overDue_MB).BeginInit();
            tabLogActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_logActions_MB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabBorrow);
            tabControl.Controls.Add(tabAvailable);
            tabControl.Controls.Add(tabOverDue);
            tabControl.Controls.Add(tabLogActions);
            tabControl.Location = new Point(30, 103);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(813, 494);
            tabControl.TabIndex = 27;
            tabControl.SelectedIndexChanged += btn_search_BR_Click;
            // 
            // tabBorrow
            // 
            tabBorrow.Controls.Add(dgv_borrowed_BR);
            tabBorrow.Location = new Point(4, 29);
            tabBorrow.Name = "tabBorrow";
            tabBorrow.Padding = new Padding(3);
            tabBorrow.Size = new Size(805, 461);
            tabBorrow.TabIndex = 0;
            tabBorrow.Text = "Borrow Records";
            tabBorrow.UseVisualStyleBackColor = true;
            // 
            // dgv_borrowed_BR
            // 
            dgv_borrowed_BR.BackgroundColor = Color.BurlyWood;
            dgv_borrowed_BR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_borrowed_BR.Location = new Point(6, 3);
            dgv_borrowed_BR.Name = "dgv_borrowed_BR";
            dgv_borrowed_BR.RowHeadersWidth = 51;
            dgv_borrowed_BR.Size = new Size(803, 451);
            dgv_borrowed_BR.TabIndex = 2;
            // 
            // tabAvailable
            // 
            tabAvailable.Controls.Add(dgv_availbleBooks);
            tabAvailable.Location = new Point(4, 29);
            tabAvailable.Name = "tabAvailable";
            tabAvailable.Size = new Size(805, 461);
            tabAvailable.TabIndex = 3;
            tabAvailable.Text = "Available Books";
            tabAvailable.UseVisualStyleBackColor = true;
            // 
            // dgv_availbleBooks
            // 
            dgv_availbleBooks.BackgroundColor = Color.BurlyWood;
            dgv_availbleBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_availbleBooks.Location = new Point(3, 3);
            dgv_availbleBooks.Name = "dgv_availbleBooks";
            dgv_availbleBooks.RowHeadersWidth = 51;
            dgv_availbleBooks.Size = new Size(799, 451);
            dgv_availbleBooks.TabIndex = 32;
            // 
            // tabOverDue
            // 
            tabOverDue.Controls.Add(dgv_overDue_MB);
            tabOverDue.Location = new Point(4, 29);
            tabOverDue.Name = "tabOverDue";
            tabOverDue.Padding = new Padding(3);
            tabOverDue.Size = new Size(805, 461);
            tabOverDue.TabIndex = 1;
            tabOverDue.Text = "Over Due";
            tabOverDue.UseVisualStyleBackColor = true;
            // 
            // dgv_overDue_MB
            // 
            dgv_overDue_MB.BackgroundColor = Color.BurlyWood;
            dgv_overDue_MB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_overDue_MB.Location = new Point(3, 3);
            dgv_overDue_MB.Name = "dgv_overDue_MB";
            dgv_overDue_MB.RowHeadersWidth = 51;
            dgv_overDue_MB.Size = new Size(799, 451);
            dgv_overDue_MB.TabIndex = 22;
            // 
            // tabLogActions
            // 
            tabLogActions.Controls.Add(dgv_logActions_MB);
            tabLogActions.Location = new Point(4, 29);
            tabLogActions.Name = "tabLogActions";
            tabLogActions.Size = new Size(805, 461);
            tabLogActions.TabIndex = 2;
            tabLogActions.Text = "Log Actions";
            tabLogActions.UseVisualStyleBackColor = true;
            // 
            // dgv_logActions_MB
            // 
            dgv_logActions_MB.BackgroundColor = Color.BurlyWood;
            dgv_logActions_MB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_logActions_MB.GridColor = Color.LightGray;
            dgv_logActions_MB.Location = new Point(3, 3);
            dgv_logActions_MB.Name = "dgv_logActions_MB";
            dgv_logActions_MB.RowHeadersWidth = 51;
            dgv_logActions_MB.Size = new Size(799, 455);
            dgv_logActions_MB.TabIndex = 29;
            // 
            // btn_search_BR
            // 
            btn_search_BR.BackColor = Color.SkyBlue;
            btn_search_BR.Cursor = Cursors.Hand;
            btn_search_BR.FlatStyle = FlatStyle.Flat;
            btn_search_BR.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search_BR.ForeColor = Color.Transparent;
            btn_search_BR.Location = new Point(405, 25);
            btn_search_BR.Name = "btn_search_BR";
            btn_search_BR.Size = new Size(127, 27);
            btn_search_BR.TabIndex = 24;
            btn_search_BR.Text = "Search";
            btn_search_BR.UseVisualStyleBackColor = false;
            btn_search_BR.Click += btn_search_BR_Click;
            // 
            // txt_search_BR
            // 
            txt_search_BR.BackColor = SystemColors.Info;
            txt_search_BR.Location = new Point(30, 25);
            txt_search_BR.Name = "txt_search_BR";
            txt_search_BR.Size = new Size(369, 27);
            txt_search_BR.TabIndex = 23;
            // 
            // btn_generateReport
            // 
            btn_generateReport.BackColor = Color.SaddleBrown;
            btn_generateReport.Cursor = Cursors.Hand;
            btn_generateReport.FlatStyle = FlatStyle.Flat;
            btn_generateReport.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn_generateReport.ForeColor = SystemColors.ButtonHighlight;
            btn_generateReport.Location = new Point(597, 603);
            btn_generateReport.Name = "btn_generateReport";
            btn_generateReport.Size = new Size(246, 41);
            btn_generateReport.TabIndex = 28;
            btn_generateReport.Text = "Generate Report";
            btn_generateReport.UseVisualStyleBackColor = false;
            btn_generateReport.Click += btn_generateReport_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Tan;
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = Color.Transparent;
            btn_clear.Location = new Point(552, 25);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(127, 27);
            btn_clear.TabIndex = 30;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.BurlyWood;
            btn_back.BackgroundImage = Properties.Resources.back_button_png_brown;
            btn_back.BackgroundImageLayout = ImageLayout.Zoom;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(34, 603);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(66, 50);
            btn_back.TabIndex = 31;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.BurlyWood;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(823, 17);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGoldenrod;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(336, 603);
            button1.Name = "button1";
            button1.Size = new Size(246, 41);
            button1.TabIndex = 43;
            button1.Text = "Send Email Reminders";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BorrowReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(883, 656);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(btn_back);
            Controls.Add(btn_clear);
            Controls.Add(btn_generateReport);
            Controls.Add(tabControl);
            Controls.Add(btn_search_BR);
            Controls.Add(txt_search_BR);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorrowReturn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrowReturn";
            Load += BorrowReturn_Load;
            tabControl.ResumeLayout(false);
            tabBorrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_borrowed_BR).EndInit();
            tabAvailable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_availbleBooks).EndInit();
            tabOverDue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_overDue_MB).EndInit();
            tabLogActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_logActions_MB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabBorrow;
        private DataGridView dgv_borrowed_BR;
        private TabPage tabOverDue;
        private DataGridView dgv_overDue_MB;
        private Button btn_search_BR;
        private TextBox txt_search_BR;
        private Button btn_generateReport;
        private TabPage tabLogActions;
        private DataGridView dgv_logActions_MB;
        private Button btn_clear;
        private Button btn_back;
        private TabPage tabAvailable;
        private DataGridView dgv_availbleBooks;
        private PictureBox pictureBox2;
        private Button button1;
    }
}
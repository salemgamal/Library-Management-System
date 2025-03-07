
namespace Library.Presentation.Forms.MemberForms
{
    partial class MemberBorrowedBooksF
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
            dgv_borrowedBooks_MBF = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            txt_title_MBF = new TextBox();
            txt_dueDate_MBF = new TextBox();
            btn_return_MBF = new Button();
            btn_back_MBF = new Button();
            btn_notification_MBF = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_borrowedBooks_MBF).BeginInit();
            SuspendLayout();
            // 
            // dgv_borrowedBooks_MBF
            // 
            dgv_borrowedBooks_MBF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_borrowedBooks_MBF.Location = new Point(12, 255);
            dgv_borrowedBooks_MBF.Name = "dgv_borrowedBooks_MBF";
            dgv_borrowedBooks_MBF.RowHeadersWidth = 51;
            dgv_borrowedBooks_MBF.Size = new Size(776, 188);
            dgv_borrowedBooks_MBF.TabIndex = 0;
            dgv_borrowedBooks_MBF.RowHeaderMouseDoubleClick += dgv_borrowedBooks_MBF_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 44);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 120);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 3;
            label3.Text = "Should Returned before";
            // 
            // txt_title_MBF
            // 
            txt_title_MBF.Location = new Point(217, 44);
            txt_title_MBF.Name = "txt_title_MBF";
            txt_title_MBF.ReadOnly = true;
            txt_title_MBF.Size = new Size(125, 27);
            txt_title_MBF.TabIndex = 4;
            // 
            // txt_dueDate_MBF
            // 
            txt_dueDate_MBF.Location = new Point(217, 117);
            txt_dueDate_MBF.Name = "txt_dueDate_MBF";
            txt_dueDate_MBF.ReadOnly = true;
            txt_dueDate_MBF.Size = new Size(125, 27);
            txt_dueDate_MBF.TabIndex = 6;
            // 
            // btn_return_MBF
            // 
            btn_return_MBF.Location = new Point(217, 193);
            btn_return_MBF.Name = "btn_return_MBF";
            btn_return_MBF.Size = new Size(121, 29);
            btn_return_MBF.TabIndex = 7;
            btn_return_MBF.Text = "Return book";
            btn_return_MBF.UseVisualStyleBackColor = true;
            btn_return_MBF.Click += btn_return_MBF_Click;
            // 
            // btn_back_MBF
            // 
            btn_back_MBF.Location = new Point(21, 193);
            btn_back_MBF.Name = "btn_back_MBF";
            btn_back_MBF.Size = new Size(94, 29);
            btn_back_MBF.TabIndex = 8;
            btn_back_MBF.Text = "back";
            btn_back_MBF.UseVisualStyleBackColor = true;
            btn_back_MBF.Click += btn_back_MBF_Click;
            // 
            // btn_notification_MBF
            // 
            btn_notification_MBF.Location = new Point(688, 12);
            btn_notification_MBF.Name = "btn_notification_MBF";
            btn_notification_MBF.Size = new Size(100, 27);
            btn_notification_MBF.TabIndex = 9;
            btn_notification_MBF.Text = "Notification";
            btn_notification_MBF.UseVisualStyleBackColor = true;
            btn_notification_MBF.Click += btn_notification_MBF_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(545, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 192);
            panel1.TabIndex = 10;
            // 
            // MemberBorrowedBooksF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btn_notification_MBF);
            Controls.Add(btn_back_MBF);
            Controls.Add(btn_return_MBF);
            Controls.Add(txt_dueDate_MBF);
            Controls.Add(txt_title_MBF);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgv_borrowedBooks_MBF);
            Name = "MemberBorrowedBooksF";
            Text = "MemberBorrowedBooks";
            Load += MemberBorrowedBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_borrowedBooks_MBF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private DataGridView dgv_borrowedBooks_MBF;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_title_MBF;
        private TextBox textBox2;
        private TextBox txt_dueDate_MBF;
        private Button btn_return_MBF;
        private Button btn_back_MBF;
        private Button btn_notification_MBF;
        private Panel panel1;
    }
}
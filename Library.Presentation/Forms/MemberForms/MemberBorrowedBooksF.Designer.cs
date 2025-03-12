
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
            panel_QR_MF = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnCapture = new Button();
            txtQRCode = new TextBox();
            btnStart = new Button();
            cboDevice = new ComboBox();
            pictureBox1 = new PictureBox();
            btn_scan_MF = new Button();
            btn_clear_MF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_borrowedBooks_MBF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_borrowedBooks_MBF
            // 
            dgv_borrowedBooks_MBF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_borrowedBooks_MBF.Location = new Point(12, 255);
            dgv_borrowedBooks_MBF.Name = "dgv_borrowedBooks_MBF";
            dgv_borrowedBooks_MBF.RowHeadersWidth = 51;
            dgv_borrowedBooks_MBF.Size = new Size(439, 188);
            dgv_borrowedBooks_MBF.TabIndex = 0;
            dgv_borrowedBooks_MBF.RowHeaderMouseDoubleClick += dgv_borrowedBooks_MBF_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 48);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 3;
            label3.Text = "Should Returned before";
            // 
            // txt_title_MBF
            // 
            txt_title_MBF.Location = new Point(65, 12);
            txt_title_MBF.Name = "txt_title_MBF";
            txt_title_MBF.ReadOnly = true;
            txt_title_MBF.Size = new Size(125, 27);
            txt_title_MBF.TabIndex = 4;
            // 
            // txt_dueDate_MBF
            // 
            txt_dueDate_MBF.Location = new Point(12, 73);
            txt_dueDate_MBF.Name = "txt_dueDate_MBF";
            txt_dueDate_MBF.ReadOnly = true;
            txt_dueDate_MBF.Size = new Size(125, 27);
            txt_dueDate_MBF.TabIndex = 6;
            // 
            // btn_return_MBF
            // 
            btn_return_MBF.Location = new Point(12, 106);
            btn_return_MBF.Name = "btn_return_MBF";
            btn_return_MBF.Size = new Size(121, 29);
            btn_return_MBF.TabIndex = 7;
            btn_return_MBF.Text = "Return book";
            btn_return_MBF.UseVisualStyleBackColor = true;
            btn_return_MBF.Click += btn_return_MBF_Click;
            // 
            // btn_back_MBF
            // 
            btn_back_MBF.Location = new Point(12, 176);
            btn_back_MBF.Name = "btn_back_MBF";
            btn_back_MBF.Size = new Size(121, 29);
            btn_back_MBF.TabIndex = 8;
            btn_back_MBF.Text = "back";
            btn_back_MBF.UseVisualStyleBackColor = true;
            btn_back_MBF.Click += btn_back_MBF_Click;
            // 
            // btn_notification_MBF
            // 
            btn_notification_MBF.Location = new Point(210, 8);
            btn_notification_MBF.Name = "btn_notification_MBF";
            btn_notification_MBF.Size = new Size(100, 27);
            btn_notification_MBF.TabIndex = 9;
            btn_notification_MBF.Text = "Notification";
            btn_notification_MBF.UseVisualStyleBackColor = true;
            btn_notification_MBF.Click += btn_notification_MBF_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(316, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 192);
            panel1.TabIndex = 10;
            // 
            // panel_QR_MF
            // 
            panel_QR_MF.Location = new Point(457, 255);
            panel_QR_MF.Name = "panel_QR_MF";
            panel_QR_MF.Size = new Size(149, 180);
            panel_QR_MF.TabIndex = 24;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnCapture
            // 
            btnCapture.Location = new Point(12, 220);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(121, 29);
            btnCapture.TabIndex = 31;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click_1;
            // 
            // txtQRCode
            // 
            txtQRCode.Location = new Point(154, 97);
            txtQRCode.Multiline = true;
            txtQRCode.Name = "txtQRCode";
            txtQRCode.Size = new Size(140, 108);
            txtQRCode.TabIndex = 30;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(139, 220);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(135, 29);
            btnStart.TabIndex = 29;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // cboDevice
            // 
            cboDevice.FormattingEnabled = true;
            cboDevice.Location = new Point(280, 221);
            cboDevice.Name = "cboDevice";
            cboDevice.Size = new Size(135, 28);
            cboDevice.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(612, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 424);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btn_scan_MF
            // 
            btn_scan_MF.Location = new Point(448, 221);
            btn_scan_MF.Name = "btn_scan_MF";
            btn_scan_MF.Size = new Size(158, 29);
            btn_scan_MF.TabIndex = 25;
            btn_scan_MF.Text = "Scan";
            btn_scan_MF.UseVisualStyleBackColor = true;
            btn_scan_MF.Click += btn_scan_MF_Click;
            // 
            // btn_clear_MF
            // 
            btn_clear_MF.Location = new Point(12, 141);
            btn_clear_MF.Name = "btn_clear_MF";
            btn_clear_MF.Size = new Size(121, 29);
            btn_clear_MF.TabIndex = 23;
            btn_clear_MF.Text = "Clear";
            btn_clear_MF.UseVisualStyleBackColor = true;
            // 
            // MemberBorrowedBooksF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 455);
            Controls.Add(panel_QR_MF);
            Controls.Add(btnCapture);
            Controls.Add(txtQRCode);
            Controls.Add(btnStart);
            Controls.Add(cboDevice);
            Controls.Add(pictureBox1);
            Controls.Add(btn_scan_MF);
            Controls.Add(btn_clear_MF);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnCapture;
        private TextBox txtQRCode;
        private Button btnStart;
        private ComboBox cboDevice;
        private PictureBox pictureBox1;
        private Button btn_scan_MF;
        private Panel panel_QR_MF;
        private Button btn_clear_MF;
    }
}
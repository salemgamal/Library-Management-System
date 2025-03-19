
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberBorrowedBooksF));
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
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_borrowedBooks_MBF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgv_borrowedBooks_MBF
            // 
            dgv_borrowedBooks_MBF.BackgroundColor = Color.PaleGoldenrod;
            dgv_borrowedBooks_MBF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_borrowedBooks_MBF.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_borrowedBooks_MBF.Location = new Point(14, 400);
            dgv_borrowedBooks_MBF.Name = "dgv_borrowedBooks_MBF";
            dgv_borrowedBooks_MBF.RowHeadersWidth = 51;
            dgv_borrowedBooks_MBF.Size = new Size(439, 188);
            dgv_borrowedBooks_MBF.TabIndex = 0;
            dgv_borrowedBooks_MBF.RowHeaderMouseDoubleClick += dgv_borrowedBooks_MBF_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 77);
            label1.Name = "label1";
            label1.Size = new Size(83, 38);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 136);
            label3.Name = "label3";
            label3.Size = new Size(294, 31);
            label3.TabIndex = 3;
            label3.Text = "Should Returned before";
            // 
            // txt_title_MBF
            // 
            txt_title_MBF.BackColor = Color.PaleGoldenrod;
            txt_title_MBF.Location = new Point(99, 88);
            txt_title_MBF.Name = "txt_title_MBF";
            txt_title_MBF.ReadOnly = true;
            txt_title_MBF.Size = new Size(125, 27);
            txt_title_MBF.TabIndex = 4;
            // 
            // txt_dueDate_MBF
            // 
            txt_dueDate_MBF.BackColor = Color.PaleGoldenrod;
            txt_dueDate_MBF.Location = new Point(311, 136);
            txt_dueDate_MBF.Name = "txt_dueDate_MBF";
            txt_dueDate_MBF.ReadOnly = true;
            txt_dueDate_MBF.Size = new Size(142, 27);
            txt_dueDate_MBF.TabIndex = 6;
            // 
            // btn_return_MBF
            // 
            btn_return_MBF.BackColor = Color.FromArgb(128, 64, 0);
            btn_return_MBF.Cursor = Cursors.Hand;
            btn_return_MBF.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_return_MBF.ForeColor = SystemColors.ControlLightLight;
            btn_return_MBF.Location = new Point(21, 192);
            btn_return_MBF.Name = "btn_return_MBF";
            btn_return_MBF.Size = new Size(155, 47);
            btn_return_MBF.TabIndex = 7;
            btn_return_MBF.Text = "Return book";
            btn_return_MBF.UseVisualStyleBackColor = false;
            btn_return_MBF.Click += btn_return_MBF_Click;
            // 
            // btn_back_MBF
            // 
            btn_back_MBF.BackColor = Color.FromArgb(128, 64, 0);
            btn_back_MBF.Cursor = Cursors.Hand;
            btn_back_MBF.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back_MBF.ForeColor = SystemColors.ControlLightLight;
            btn_back_MBF.Location = new Point(14, 593);
            btn_back_MBF.Name = "btn_back_MBF";
            btn_back_MBF.Size = new Size(103, 48);
            btn_back_MBF.TabIndex = 8;
            btn_back_MBF.Text = "back";
            btn_back_MBF.UseVisualStyleBackColor = false;
            btn_back_MBF.Click += btn_back_MBF_Click;
            // 
            // btn_notification_MBF
            // 
            btn_notification_MBF.BackColor = Color.FromArgb(128, 64, 0);
            btn_notification_MBF.Cursor = Cursors.Hand;
            btn_notification_MBF.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_notification_MBF.ForeColor = SystemColors.ControlLightLight;
            btn_notification_MBF.Location = new Point(459, 118);
            btn_notification_MBF.Name = "btn_notification_MBF";
            btn_notification_MBF.Size = new Size(135, 53);
            btn_notification_MBF.TabIndex = 9;
            btn_notification_MBF.Text = "Notification";
            btn_notification_MBF.TextAlign = ContentAlignment.MiddleLeft;
            btn_notification_MBF.UseVisualStyleBackColor = false;
            btn_notification_MBF.Click += btn_notification_MBF_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.Location = new Point(459, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 163);
            panel1.TabIndex = 10;
            // 
            // panel_QR_MF
            // 
            panel_QR_MF.BackColor = Color.PaleGoldenrod;
            panel_QR_MF.Location = new Point(459, 400);
            panel_QR_MF.Name = "panel_QR_MF";
            panel_QR_MF.Size = new Size(173, 188);
            panel_QR_MF.TabIndex = 24;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnCapture
            // 
            btnCapture.BackColor = Color.FromArgb(128, 64, 0);
            btnCapture.Cursor = Cursors.Hand;
            btnCapture.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCapture.ForeColor = SystemColors.ControlLightLight;
            btnCapture.Location = new Point(459, 350);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(155, 44);
            btnCapture.TabIndex = 31;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = false;
            btnCapture.Click += btnCapture_Click_1;
            // 
            // txtQRCode
            // 
            txtQRCode.BackColor = Color.PaleGoldenrod;
            txtQRCode.Location = new Point(182, 192);
            txtQRCode.Multiline = true;
            txtQRCode.Name = "txtQRCode";
            txtQRCode.Size = new Size(171, 157);
            txtQRCode.TabIndex = 30;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(128, 64, 0);
            btnStart.Cursor = Cursors.Hand;
            btnStart.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnStart.ForeColor = SystemColors.ControlLightLight;
            btnStart.Location = new Point(795, 88);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(135, 44);
            btnStart.TabIndex = 29;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // cboDevice
            // 
            cboDevice.BackColor = Color.PaleGoldenrod;
            cboDevice.FormattingEnabled = true;
            cboDevice.Location = new Point(641, 98);
            cboDevice.Name = "cboDevice";
            cboDevice.Size = new Size(135, 28);
            cboDevice.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PaleGoldenrod;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(640, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 451);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btn_scan_MF
            // 
            btn_scan_MF.BackColor = Color.FromArgb(128, 64, 0);
            btn_scan_MF.Cursor = Cursors.Hand;
            btn_scan_MF.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_scan_MF.ForeColor = SystemColors.ControlLightLight;
            btn_scan_MF.Location = new Point(21, 302);
            btn_scan_MF.Name = "btn_scan_MF";
            btn_scan_MF.Size = new Size(155, 47);
            btn_scan_MF.TabIndex = 25;
            btn_scan_MF.Text = "Scan";
            btn_scan_MF.UseVisualStyleBackColor = false;
            btn_scan_MF.Click += btn_scan_MF_Click;
            // 
            // btn_clear_MF
            // 
            btn_clear_MF.BackColor = SystemColors.ActiveCaptionText;
            btn_clear_MF.Cursor = Cursors.Hand;
            btn_clear_MF.ForeColor = SystemColors.ControlLightLight;
            btn_clear_MF.Location = new Point(21, 245);
            btn_clear_MF.Name = "btn_clear_MF";
            btn_clear_MF.Size = new Size(155, 47);
            btn_clear_MF.TabIndex = 23;
            btn_clear_MF.Text = "Clear";
            btn_clear_MF.UseVisualStyleBackColor = false;
            btn_clear_MF.Click += btn_clear_MF_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(237, -5);
            label2.Name = "label2";
            label2.Size = new Size(577, 90);
            label2.TabIndex = 32;
            label2.Text = "Borrowed Book";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(128, 64, 0);
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(591, 125);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Sienna;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(960, 16);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // MemberBorrowedBooksF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1017, 656);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberBorrowedBooksF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberBorrowedBooks";
            Load += MemberBorrowedBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_borrowedBooks_MBF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
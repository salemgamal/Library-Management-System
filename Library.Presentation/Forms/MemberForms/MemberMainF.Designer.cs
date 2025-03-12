
namespace Library.Presentation.Forms.MemberForms
{
    partial class MemberMainF
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
            dgv_availableBooks_MF = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_title_MF = new TextBox();
            txt_author_MF = new TextBox();
            txt_category_MF = new TextBox();
            txt_year_MF = new TextBox();
            txt_dueDate_MF = new TextBox();
            brn_borrow_MF = new Button();
            btn_memberRecords_MF = new Button();
            btn_back_MF = new Button();
            btn_clear_MF = new Button();
            panel_QR_MF = new Panel();
            txtQRCode = new TextBox();
            btnStart = new Button();
            pictureBox1 = new PictureBox();
            cboDevice = new ComboBox();
            label6 = new Label();
            btn_scan_MF = new Button();
            btnCapture = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_availableBooks_MF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_availableBooks_MF
            // 
            dgv_availableBooks_MF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_availableBooks_MF.Location = new Point(12, 250);
            dgv_availableBooks_MF.Name = "dgv_availableBooks_MF";
            dgv_availableBooks_MF.RowHeadersWidth = 51;
            dgv_availableBooks_MF.Size = new Size(580, 227);
            dgv_availableBooks_MF.TabIndex = 0;
            dgv_availableBooks_MF.RowHeaderMouseDoubleClick += dgv_availableBooks_MF_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 59);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 99);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 139);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 4;
            label4.Text = "Publish Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 179);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 5;
            label5.Text = "Due Date";
            // 
            // txt_title_MF
            // 
            txt_title_MF.Location = new Point(191, 20);
            txt_title_MF.Name = "txt_title_MF";
            txt_title_MF.ReadOnly = true;
            txt_title_MF.Size = new Size(125, 27);
            txt_title_MF.TabIndex = 6;
            // 
            // txt_author_MF
            // 
            txt_author_MF.Location = new Point(191, 56);
            txt_author_MF.Name = "txt_author_MF";
            txt_author_MF.ReadOnly = true;
            txt_author_MF.Size = new Size(125, 27);
            txt_author_MF.TabIndex = 7;
            // 
            // txt_category_MF
            // 
            txt_category_MF.Location = new Point(191, 99);
            txt_category_MF.Name = "txt_category_MF";
            txt_category_MF.ReadOnly = true;
            txt_category_MF.Size = new Size(125, 27);
            txt_category_MF.TabIndex = 8;
            // 
            // txt_year_MF
            // 
            txt_year_MF.Location = new Point(191, 136);
            txt_year_MF.Name = "txt_year_MF";
            txt_year_MF.ReadOnly = true;
            txt_year_MF.Size = new Size(125, 27);
            txt_year_MF.TabIndex = 9;
            // 
            // txt_dueDate_MF
            // 
            txt_dueDate_MF.Location = new Point(191, 179);
            txt_dueDate_MF.Name = "txt_dueDate_MF";
            txt_dueDate_MF.ReadOnly = true;
            txt_dueDate_MF.Size = new Size(125, 27);
            txt_dueDate_MF.TabIndex = 10;
            // 
            // brn_borrow_MF
            // 
            brn_borrow_MF.Location = new Point(105, 212);
            brn_borrow_MF.Name = "brn_borrow_MF";
            brn_borrow_MF.Size = new Size(94, 29);
            brn_borrow_MF.TabIndex = 11;
            brn_borrow_MF.Text = "Borrow";
            brn_borrow_MF.UseVisualStyleBackColor = true;
            brn_borrow_MF.Click += brn_borrow_MF_Click;
            // 
            // btn_memberRecords_MF
            // 
            btn_memberRecords_MF.Location = new Point(205, 212);
            btn_memberRecords_MF.Name = "btn_memberRecords_MF";
            btn_memberRecords_MF.Size = new Size(94, 29);
            btn_memberRecords_MF.TabIndex = 12;
            btn_memberRecords_MF.Text = "Your books";
            btn_memberRecords_MF.UseVisualStyleBackColor = true;
            btn_memberRecords_MF.Click += btn_memberRecords_MF_Click;
            // 
            // btn_back_MF
            // 
            btn_back_MF.Location = new Point(5, 212);
            btn_back_MF.Name = "btn_back_MF";
            btn_back_MF.Size = new Size(94, 29);
            btn_back_MF.TabIndex = 13;
            btn_back_MF.Text = "Logout";
            btn_back_MF.UseVisualStyleBackColor = true;
            btn_back_MF.Click += btn_back_MF_Click;
            // 
            // btn_clear_MF
            // 
            btn_clear_MF.Location = new Point(305, 212);
            btn_clear_MF.Name = "btn_clear_MF";
            btn_clear_MF.Size = new Size(94, 29);
            btn_clear_MF.TabIndex = 14;
            btn_clear_MF.Text = "Clear";
            btn_clear_MF.UseVisualStyleBackColor = true;
            btn_clear_MF.Click += btn_clear_MF_Click;
            // 
            // panel_QR_MF
            // 
            panel_QR_MF.Location = new Point(326, 12);
            panel_QR_MF.Name = "panel_QR_MF";
            panel_QR_MF.Size = new Size(189, 187);
            panel_QR_MF.TabIndex = 15;
            // 
            // txtQRCode
            // 
            txtQRCode.Location = new Point(771, 6);
            txtQRCode.Multiline = true;
            txtQRCode.Name = "txtQRCode";
            txtQRCode.Size = new Size(404, 91);
            txtQRCode.TabIndex = 21;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(405, 212);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(189, 29);
            btnStart.TabIndex = 20;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(600, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(575, 404);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cboDevice
            // 
            cboDevice.FormattingEnabled = true;
            cboDevice.Location = new Point(614, 6);
            cboDevice.Name = "cboDevice";
            cboDevice.Size = new Size(151, 28);
            cboDevice.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(534, 9);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 19;
            label6.Text = "camera";
            label6.Click += label6_Click;
            // 
            // btn_scan_MF
            // 
            btn_scan_MF.Location = new Point(656, 56);
            btn_scan_MF.Name = "btn_scan_MF";
            btn_scan_MF.Size = new Size(94, 29);
            btn_scan_MF.TabIndex = 16;
            btn_scan_MF.Text = "Scan";
            btn_scan_MF.UseVisualStyleBackColor = true;
            btn_scan_MF.Click += btn_scan_MF_Click;
            // 
            // btnCapture
            // 
            btnCapture.Location = new Point(534, 54);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(94, 29);
            btnCapture.TabIndex = 22;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // MemberMainF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 519);
            Controls.Add(btnCapture);
            Controls.Add(txtQRCode);
            Controls.Add(btnStart);
            Controls.Add(label6);
            Controls.Add(cboDevice);
            Controls.Add(pictureBox1);
            Controls.Add(btn_scan_MF);
            Controls.Add(panel_QR_MF);
            Controls.Add(btn_clear_MF);
            Controls.Add(btn_back_MF);
            Controls.Add(btn_memberRecords_MF);
            Controls.Add(brn_borrow_MF);
            Controls.Add(txt_dueDate_MF);
            Controls.Add(txt_year_MF);
            Controls.Add(txt_category_MF);
            Controls.Add(txt_author_MF);
            Controls.Add(txt_title_MF);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_availableBooks_MF);
            Name = "MemberMainF";
            Text = "MemberMainF";
            Load += MemberMainF_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_availableBooks_MF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void panel_QR_MF_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtQRCode_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

        private void MemberMainF_FormClosing(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dgv_availableBooks_MF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_title_MF;
        private TextBox txt_author_MF;
        private TextBox txt_category_MF;
        private TextBox txt_year_MF;
        private TextBox txt_dueDate_MF;
        private Button brn_borrow_MF;
        private Button btn_memberRecords_MF;
        private Button btn_back_MF;
        private Button btn_clear_MF;
        private Panel panel_QR_MF;
        private TextBox txtQRCode;
        private Button btnStart;
        private PictureBox pictureBox1;
        private ComboBox cboDevice;
        private Label label6;
        private Button btn_scan_MF;
        private Button btnCapture;
    }
}
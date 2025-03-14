
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberMainF));
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
            pictureBox3 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_availableBooks_MF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgv_availableBooks_MF
            // 
            dgv_availableBooks_MF.BackgroundColor = Color.PaleGoldenrod;
            dgv_availableBooks_MF.BorderStyle = BorderStyle.None;
            dgv_availableBooks_MF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_availableBooks_MF.Location = new Point(24, 423);
            dgv_availableBooks_MF.Name = "dgv_availableBooks_MF";
            dgv_availableBooks_MF.RowHeadersWidth = 51;
            dgv_availableBooks_MF.Size = new Size(525, 227);
            dgv_availableBooks_MF.TabIndex = 0;
            dgv_availableBooks_MF.RowHeaderMouseDoubleClick += dgv_availableBooks_MF_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 136);
            label1.Name = "label1";
            label1.Size = new Size(69, 31);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label2.Location = new Point(24, 177);
            label2.Name = "label2";
            label2.Size = new Size(98, 31);
            label2.TabIndex = 2;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label3.Location = new Point(24, 219);
            label3.Name = "label3";
            label3.Size = new Size(121, 31);
            label3.TabIndex = 3;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label4.Location = new Point(24, 257);
            label4.Name = "label4";
            label4.Size = new Size(164, 31);
            label4.TabIndex = 4;
            label4.Text = "Publish Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label5.Location = new Point(24, 299);
            label5.Name = "label5";
            label5.Size = new Size(123, 31);
            label5.TabIndex = 5;
            label5.Text = "Due Date";
            // 
            // txt_title_MF
            // 
            txt_title_MF.BackColor = Color.PaleGoldenrod;
            txt_title_MF.Location = new Point(194, 136);
            txt_title_MF.Name = "txt_title_MF";
            txt_title_MF.ReadOnly = true;
            txt_title_MF.Size = new Size(125, 27);
            txt_title_MF.TabIndex = 6;
            // 
            // txt_author_MF
            // 
            txt_author_MF.BackColor = Color.PaleGoldenrod;
            txt_author_MF.Location = new Point(194, 177);
            txt_author_MF.Name = "txt_author_MF";
            txt_author_MF.ReadOnly = true;
            txt_author_MF.Size = new Size(125, 27);
            txt_author_MF.TabIndex = 7;
            // 
            // txt_category_MF
            // 
            txt_category_MF.BackColor = Color.PaleGoldenrod;
            txt_category_MF.Location = new Point(194, 220);
            txt_category_MF.Name = "txt_category_MF";
            txt_category_MF.ReadOnly = true;
            txt_category_MF.Size = new Size(125, 27);
            txt_category_MF.TabIndex = 8;
            // 
            // txt_year_MF
            // 
            txt_year_MF.BackColor = Color.PaleGoldenrod;
            txt_year_MF.Location = new Point(194, 257);
            txt_year_MF.Name = "txt_year_MF";
            txt_year_MF.ReadOnly = true;
            txt_year_MF.Size = new Size(125, 27);
            txt_year_MF.TabIndex = 9;
            // 
            // txt_dueDate_MF
            // 
            txt_dueDate_MF.BackColor = Color.PaleGoldenrod;
            txt_dueDate_MF.Location = new Point(194, 300);
            txt_dueDate_MF.Name = "txt_dueDate_MF";
            txt_dueDate_MF.ReadOnly = true;
            txt_dueDate_MF.Size = new Size(125, 27);
            txt_dueDate_MF.TabIndex = 10;
            // 
            // brn_borrow_MF
            // 
            brn_borrow_MF.BackColor = Color.FromArgb(128, 64, 0);
            brn_borrow_MF.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            brn_borrow_MF.ForeColor = SystemColors.ControlLightLight;
            brn_borrow_MF.Location = new Point(124, 365);
            brn_borrow_MF.Name = "brn_borrow_MF";
            brn_borrow_MF.Size = new Size(102, 52);
            brn_borrow_MF.TabIndex = 11;
            brn_borrow_MF.Text = "Borrow";
            brn_borrow_MF.UseVisualStyleBackColor = false;
            brn_borrow_MF.Click += brn_borrow_MF_Click;
            // 
            // btn_memberRecords_MF
            // 
            btn_memberRecords_MF.BackColor = Color.FromArgb(128, 64, 0);
            btn_memberRecords_MF.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btn_memberRecords_MF.ForeColor = SystemColors.ControlLightLight;
            btn_memberRecords_MF.Location = new Point(232, 365);
            btn_memberRecords_MF.Name = "btn_memberRecords_MF";
            btn_memberRecords_MF.Size = new Size(147, 52);
            btn_memberRecords_MF.TabIndex = 12;
            btn_memberRecords_MF.Text = "Your books";
            btn_memberRecords_MF.UseVisualStyleBackColor = false;
            btn_memberRecords_MF.Click += btn_memberRecords_MF_Click;
            // 
            // btn_back_MF
            // 
            btn_back_MF.BackColor = Color.Maroon;
            btn_back_MF.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back_MF.ForeColor = SystemColors.ControlLightLight;
            btn_back_MF.Location = new Point(24, 365);
            btn_back_MF.Name = "btn_back_MF";
            btn_back_MF.Size = new Size(94, 52);
            btn_back_MF.TabIndex = 13;
            btn_back_MF.Text = "Logout";
            btn_back_MF.UseVisualStyleBackColor = false;
            btn_back_MF.Click += btn_back_MF_Click;
            // 
            // btn_clear_MF
            // 
            btn_clear_MF.BackColor = Color.FromArgb(128, 64, 0);
            btn_clear_MF.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btn_clear_MF.ForeColor = SystemColors.ControlLightLight;
            btn_clear_MF.Location = new Point(385, 365);
            btn_clear_MF.Name = "btn_clear_MF";
            btn_clear_MF.Size = new Size(82, 52);
            btn_clear_MF.TabIndex = 14;
            btn_clear_MF.Text = "Clear";
            btn_clear_MF.UseVisualStyleBackColor = false;
            btn_clear_MF.Click += btn_clear_MF_Click;
            // 
            // panel_QR_MF
            // 
            panel_QR_MF.BackColor = Color.PaleGoldenrod;
            panel_QR_MF.Location = new Point(346, 144);
            panel_QR_MF.Name = "panel_QR_MF";
            panel_QR_MF.Size = new Size(202, 187);
            panel_QR_MF.TabIndex = 15;
            // 
            // txtQRCode
            // 
            txtQRCode.BackColor = Color.PaleGoldenrod;
            txtQRCode.Location = new Point(798, 147);
            txtQRCode.Multiline = true;
            txtQRCode.Name = "txtQRCode";
            txtQRCode.Size = new Size(361, 91);
            txtQRCode.TabIndex = 21;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(128, 64, 0);
            btnStart.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnStart.ForeColor = SystemColors.ControlLightLight;
            btnStart.Location = new Point(684, 194);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(108, 44);
            btnStart.TabIndex = 20;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(583, 244);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(575, 404);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cboDevice
            // 
            cboDevice.BackColor = Color.PaleGoldenrod;
            cboDevice.FormattingEnabled = true;
            cboDevice.Location = new Point(583, 160);
            cboDevice.Name = "cboDevice";
            cboDevice.Size = new Size(194, 28);
            cboDevice.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label6.Location = new Point(583, 117);
            label6.Name = "label6";
            label6.Size = new Size(100, 31);
            label6.TabIndex = 19;
            label6.Text = "camera";
            label6.Click += label6_Click;
            // 
            // btn_scan_MF
            // 
            btn_scan_MF.BackColor = Color.FromArgb(128, 64, 0);
            btn_scan_MF.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btn_scan_MF.ForeColor = SystemColors.ControlLightLight;
            btn_scan_MF.Location = new Point(473, 365);
            btn_scan_MF.Name = "btn_scan_MF";
            btn_scan_MF.Size = new Size(82, 52);
            btn_scan_MF.TabIndex = 16;
            btn_scan_MF.Text = "Scan";
            btn_scan_MF.UseVisualStyleBackColor = false;
            btn_scan_MF.Click += btn_scan_MF_Click;
            // 
            // btnCapture
            // 
            btnCapture.BackColor = Color.FromArgb(128, 64, 0);
            btnCapture.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnCapture.ForeColor = SystemColors.ControlLightLight;
            btnCapture.Location = new Point(583, 194);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(108, 44);
            btnCapture.TabIndex = 22;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = false;
            btnCapture.Click += btnCapture_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(128, 64, 0);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1130, 45);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 35;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(317, 12);
            label7.Name = "label7";
            label7.Size = new Size(412, 68);
            label7.TabIndex = 36;
            label7.Text = "Member Home";
            // 
            // MemberMainF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1179, 684);
            Controls.Add(label7);
            Controls.Add(pictureBox3);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberMainF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberMainF";
            Load += MemberMainF_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_availableBooks_MF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox3;
        private Label label7;
    }
}
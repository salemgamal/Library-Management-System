namespace Library.Presentation.Forms.MemberForms
{
    partial class NotificationF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationF));
            dgv_notificationF_MBF = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_notificationF_MBF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_notificationF_MBF
            // 
            dgv_notificationF_MBF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_notificationF_MBF.BackgroundColor = Color.PaleGoldenrod;
            dgv_notificationF_MBF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_notificationF_MBF.Location = new Point(30, 40);
            dgv_notificationF_MBF.Name = "dgv_notificationF_MBF";
            dgv_notificationF_MBF.RowHeadersWidth = 51;
            dgv_notificationF_MBF.Size = new Size(366, 203);
            dgv_notificationF_MBF.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(391, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // NotificationF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(422, 275);
            Controls.Add(pictureBox1);
            Controls.Add(dgv_notificationF_MBF);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotificationF";
            Text = "NotificationF";
            Load += NotificationF_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_notificationF_MBF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_notificationF_MBF;
        private PictureBox pictureBox1;
    }
}
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
            dgv_notificationF_MBF = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_notificationF_MBF).BeginInit();
            SuspendLayout();
            // 
            // dgv_notificationF_MBF
            // 
            dgv_notificationF_MBF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_notificationF_MBF.Location = new Point(12, 12);
            dgv_notificationF_MBF.Name = "dgv_notificationF_MBF";
            dgv_notificationF_MBF.RowHeadersWidth = 51;
            dgv_notificationF_MBF.Size = new Size(331, 202);
            dgv_notificationF_MBF.TabIndex = 0;
            // 
            // NotificationF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 234);
            Controls.Add(dgv_notificationF_MBF);
            Name = "NotificationF";
            Text = "NotificationF";
            Load += NotificationF_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_notificationF_MBF).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_notificationF_MBF;
    }
}
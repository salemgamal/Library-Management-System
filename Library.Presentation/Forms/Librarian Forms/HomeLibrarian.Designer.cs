namespace Library.Presentation.Forms.Librarian_Forms
{
    partial class HomeLibrarian
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
            btn_managment_HL = new Button();
            btn_reports_HL = new Button();
            SuspendLayout();
            // 
            // btn_managment_HL
            // 
            btn_managment_HL.Location = new Point(205, 119);
            btn_managment_HL.Name = "btn_managment_HL";
            btn_managment_HL.Size = new Size(419, 69);
            btn_managment_HL.TabIndex = 0;
            btn_managment_HL.Text = "Managment";
            btn_managment_HL.UseVisualStyleBackColor = true;
            btn_managment_HL.Click += btn_managment_HL_Click;
            // 
            // btn_reports_HL
            // 
            btn_reports_HL.Location = new Point(205, 229);
            btn_reports_HL.Name = "btn_reports_HL";
            btn_reports_HL.Size = new Size(419, 69);
            btn_reports_HL.TabIndex = 1;
            btn_reports_HL.Text = "Reports";
            btn_reports_HL.UseVisualStyleBackColor = true;
            btn_reports_HL.Click += btn_reports_HL_Click;
            // 
            // HomeLibrarian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_reports_HL);
            Controls.Add(btn_managment_HL);
            Name = "HomeLibrarian";
            Text = "HomeLibrarian";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_managment_HL;
        private Button btn_reports_HL;
    }
}
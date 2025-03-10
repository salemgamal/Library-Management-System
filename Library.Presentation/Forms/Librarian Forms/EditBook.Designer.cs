namespace Library.Presentation.Forms.Librarian_Forms
{
    partial class EditBook
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
            numericUpDown_puplishYear_AB = new NumericUpDown();
            lbl_quantity_AB = new Label();
            lbl_puplishYear_AB = new Label();
            lbl_ISBN_AB = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_save_AB = new Button();
            txt_auth_AB = new TextBox();
            numericUpDown_quantity_AB = new NumericUpDown();
            txt_title_AB = new TextBox();
            txt_ISBN_AB = new TextBox();
            lbl_categories_LF = new Label();
            cmbBox_categories_EB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_puplishYear_AB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity_AB).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown_puplishYear_AB
            // 
            numericUpDown_puplishYear_AB.Location = new Point(244, 225);
            numericUpDown_puplishYear_AB.Name = "numericUpDown_puplishYear_AB";
            numericUpDown_puplishYear_AB.Size = new Size(260, 27);
            numericUpDown_puplishYear_AB.TabIndex = 44;
            // 
            // lbl_quantity_AB
            // 
            lbl_quantity_AB.AutoSize = true;
            lbl_quantity_AB.Location = new Point(86, 287);
            lbl_quantity_AB.Name = "lbl_quantity_AB";
            lbl_quantity_AB.Size = new Size(65, 20);
            lbl_quantity_AB.TabIndex = 42;
            lbl_quantity_AB.Text = "Quantity";
            // 
            // lbl_puplishYear_AB
            // 
            lbl_puplishYear_AB.AutoSize = true;
            lbl_puplishYear_AB.Location = new Point(86, 230);
            lbl_puplishYear_AB.Name = "lbl_puplishYear_AB";
            lbl_puplishYear_AB.Size = new Size(88, 20);
            lbl_puplishYear_AB.TabIndex = 41;
            lbl_puplishYear_AB.Text = "Puplish Year";
            // 
            // lbl_ISBN_AB
            // 
            lbl_ISBN_AB.AutoSize = true;
            lbl_ISBN_AB.Location = new Point(110, 52);
            lbl_ISBN_AB.Name = "lbl_ISBN_AB";
            lbl_ISBN_AB.Size = new Size(41, 20);
            lbl_ISBN_AB.TabIndex = 40;
            lbl_ISBN_AB.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 176);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 39;
            label2.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 112);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 38;
            label1.Text = "Title";
            // 
            // btn_save_AB
            // 
            btn_save_AB.Location = new Point(371, 408);
            btn_save_AB.Name = "btn_save_AB";
            btn_save_AB.Size = new Size(133, 49);
            btn_save_AB.TabIndex = 37;
            btn_save_AB.Text = "Save changes";
            btn_save_AB.UseVisualStyleBackColor = true;
            btn_save_AB.Click += btn_save_AB_Click;
            // 
            // txt_auth_AB
            // 
            txt_auth_AB.Location = new Point(244, 169);
            txt_auth_AB.Name = "txt_auth_AB";
            txt_auth_AB.Size = new Size(260, 27);
            txt_auth_AB.TabIndex = 36;
            // 
            // numericUpDown_quantity_AB
            // 
            numericUpDown_quantity_AB.Location = new Point(244, 287);
            numericUpDown_quantity_AB.Name = "numericUpDown_quantity_AB";
            numericUpDown_quantity_AB.Size = new Size(260, 27);
            numericUpDown_quantity_AB.TabIndex = 35;
            // 
            // txt_title_AB
            // 
            txt_title_AB.Location = new Point(244, 109);
            txt_title_AB.Name = "txt_title_AB";
            txt_title_AB.Size = new Size(260, 27);
            txt_title_AB.TabIndex = 34;
            // 
            // txt_ISBN_AB
            // 
            txt_ISBN_AB.Location = new Point(244, 45);
            txt_ISBN_AB.Name = "txt_ISBN_AB";
            txt_ISBN_AB.Size = new Size(260, 27);
            txt_ISBN_AB.TabIndex = 33;
            // 
            // lbl_categories_LF
            // 
            lbl_categories_LF.AutoSize = true;
            lbl_categories_LF.Location = new Point(86, 346);
            lbl_categories_LF.Name = "lbl_categories_LF";
            lbl_categories_LF.Size = new Size(69, 20);
            lbl_categories_LF.TabIndex = 32;
            lbl_categories_LF.Text = "Category";
            // 
            // cmbBox_categories_EB
            // 
            cmbBox_categories_EB.FormattingEnabled = true;
            cmbBox_categories_EB.Location = new Point(244, 346);
            cmbBox_categories_EB.Name = "cmbBox_categories_EB";
            cmbBox_categories_EB.Size = new Size(260, 28);
            cmbBox_categories_EB.TabIndex = 43;
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 502);
            Controls.Add(numericUpDown_puplishYear_AB);
            Controls.Add(lbl_quantity_AB);
            Controls.Add(lbl_puplishYear_AB);
            Controls.Add(lbl_ISBN_AB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_save_AB);
            Controls.Add(txt_auth_AB);
            Controls.Add(numericUpDown_quantity_AB);
            Controls.Add(txt_title_AB);
            Controls.Add(txt_ISBN_AB);
            Controls.Add(lbl_categories_LF);
            Controls.Add(cmbBox_categories_EB);
            Name = "EditBook";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_puplishYear_AB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity_AB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown_puplishYear_AB;
        private Label lbl_quantity_AB;
        private Label lbl_puplishYear_AB;
        private Label lbl_ISBN_AB;
        private Label label2;
        private Label label1;
        private Button btn_save_AB;
        private TextBox txt_auth_AB;
        private NumericUpDown numericUpDown_quantity_AB;
        private TextBox txt_title_AB;
        private TextBox txt_ISBN_AB;
        private Label lbl_categories_LF;
        private ComboBox cmbBox_categories_EB;
    }
}
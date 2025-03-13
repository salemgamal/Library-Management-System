namespace Library.Presentation.Forms.Librarian_Forms
{
    partial class AddBook
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
            txt_auth_AB = new TextBox();
            numericUpDown_quantity_AB = new NumericUpDown();
            txt_title_AB = new TextBox();
            txt_ISBN_AB = new TextBox();
            lbl_categories_LF = new Label();
            cmbBox_categories_AB = new ComboBox();
            btn_save_AB = new Button();
            label1 = new Label();
            label2 = new Label();
            lbl_ISBN_AB = new Label();
            lbl_puplishYear_AB = new Label();
            lbl_quantity_AB = new Label();
            numericUpDown_puplishYear_AB = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity_AB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_puplishYear_AB).BeginInit();
            SuspendLayout();
            // 
            // txt_auth_AB
            // 
            txt_auth_AB.Location = new Point(212, 137);
            txt_auth_AB.Margin = new Padding(3, 2, 3, 2);
            txt_auth_AB.Name = "txt_auth_AB";
            txt_auth_AB.Size = new Size(228, 23);
            txt_auth_AB.TabIndex = 22;
            // 
            // numericUpDown_quantity_AB
            // 
            numericUpDown_quantity_AB.Location = new Point(212, 225);
            numericUpDown_quantity_AB.Margin = new Padding(3, 2, 3, 2);
            numericUpDown_quantity_AB.Name = "numericUpDown_quantity_AB";
            numericUpDown_quantity_AB.Size = new Size(228, 23);
            numericUpDown_quantity_AB.TabIndex = 21;
            // 
            // txt_title_AB
            // 
            txt_title_AB.Location = new Point(212, 92);
            txt_title_AB.Margin = new Padding(3, 2, 3, 2);
            txt_title_AB.Name = "txt_title_AB";
            txt_title_AB.Size = new Size(228, 23);
            txt_title_AB.TabIndex = 20;
            // 
            // txt_ISBN_AB
            // 
            txt_ISBN_AB.Location = new Point(212, 44);
            txt_ISBN_AB.Margin = new Padding(3, 2, 3, 2);
            txt_ISBN_AB.Name = "txt_ISBN_AB";
            txt_ISBN_AB.Size = new Size(228, 23);
            txt_ISBN_AB.TabIndex = 19;
            // 
            // lbl_categories_LF
            // 
            lbl_categories_LF.AutoSize = true;
            lbl_categories_LF.Location = new Point(73, 269);
            lbl_categories_LF.Name = "lbl_categories_LF";
            lbl_categories_LF.Size = new Size(55, 15);
            lbl_categories_LF.TabIndex = 18;
            lbl_categories_LF.Text = "Category";
            // 
            // cmbBox_categories_AB
            // 
            cmbBox_categories_AB.FormattingEnabled = true;
            cmbBox_categories_AB.Location = new Point(212, 269);
            cmbBox_categories_AB.Margin = new Padding(3, 2, 3, 2);
            cmbBox_categories_AB.Name = "cmbBox_categories_AB";
            cmbBox_categories_AB.Size = new Size(228, 23);
            cmbBox_categories_AB.TabIndex = 30;
            // 
            // btn_save_AB
            // 
            btn_save_AB.Location = new Point(323, 316);
            btn_save_AB.Margin = new Padding(3, 2, 3, 2);
            btn_save_AB.Name = "btn_save_AB";
            btn_save_AB.Size = new Size(116, 37);
            btn_save_AB.TabIndex = 24;
            btn_save_AB.Text = "Save";
            btn_save_AB.UseVisualStyleBackColor = true;
            btn_save_AB.Click += btn_save_AB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 94);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 25;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 142);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 26;
            label2.Text = "Author";
            // 
            // lbl_ISBN_AB
            // 
            lbl_ISBN_AB.AutoSize = true;
            lbl_ISBN_AB.Location = new Point(95, 49);
            lbl_ISBN_AB.Name = "lbl_ISBN_AB";
            lbl_ISBN_AB.Size = new Size(32, 15);
            lbl_ISBN_AB.TabIndex = 27;
            lbl_ISBN_AB.Text = "ISBN";
            // 
            // lbl_puplishYear_AB
            // 
            lbl_puplishYear_AB.AutoSize = true;
            lbl_puplishYear_AB.Location = new Point(73, 183);
            lbl_puplishYear_AB.Name = "lbl_puplishYear_AB";
            lbl_puplishYear_AB.Size = new Size(71, 15);
            lbl_puplishYear_AB.TabIndex = 28;
            lbl_puplishYear_AB.Text = "Puplish Year";
            // 
            // lbl_quantity_AB
            // 
            lbl_quantity_AB.AutoSize = true;
            lbl_quantity_AB.Location = new Point(73, 225);
            lbl_quantity_AB.Name = "lbl_quantity_AB";
            lbl_quantity_AB.Size = new Size(53, 15);
            lbl_quantity_AB.TabIndex = 29;
            lbl_quantity_AB.Text = "Quantity";
            // 
            // numericUpDown_puplishYear_AB
            // 
            numericUpDown_puplishYear_AB.Location = new Point(212, 179);
            numericUpDown_puplishYear_AB.Margin = new Padding(3, 2, 3, 2);
            numericUpDown_puplishYear_AB.Name = "numericUpDown_puplishYear_AB";
            numericUpDown_puplishYear_AB.Size = new Size(228, 23);
            numericUpDown_puplishYear_AB.TabIndex = 31;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 395);
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
            Controls.Add(cmbBox_categories_AB);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddBook";
            Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity_AB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_puplishYear_AB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_auth_AB;
        private NumericUpDown numericUpDown_quantity_AB;
        private TextBox txt_title_AB;
        private TextBox txt_ISBN_AB;
        private Label lbl_categories_LF;
        private ComboBox cmbBox_categories_AB;
        private Button btn_save_AB;
        private Label label1;
        private Label label2;
        private Label lbl_ISBN_AB;
        private Label lbl_puplishYear_AB;
        private Label lbl_quantity_AB;
        private NumericUpDown numericUpDown_puplishYear_AB;
    }
}
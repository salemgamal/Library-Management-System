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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
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
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity_AB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_puplishYear_AB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_auth_AB
            // 
            txt_auth_AB.BackColor = SystemColors.Info;
            txt_auth_AB.Location = new Point(231, 193);
            txt_auth_AB.Name = "txt_auth_AB";
            txt_auth_AB.Size = new Size(260, 27);
            txt_auth_AB.TabIndex = 22;
            // 
            // numericUpDown_quantity_AB
            // 
            numericUpDown_quantity_AB.BackColor = SystemColors.Info;
            numericUpDown_quantity_AB.Location = new Point(231, 300);
            numericUpDown_quantity_AB.Name = "numericUpDown_quantity_AB";
            numericUpDown_quantity_AB.Size = new Size(261, 27);
            numericUpDown_quantity_AB.TabIndex = 21;
            // 
            // txt_title_AB
            // 
            txt_title_AB.BackColor = SystemColors.Info;
            txt_title_AB.Location = new Point(231, 126);
            txt_title_AB.Name = "txt_title_AB";
            txt_title_AB.Size = new Size(260, 27);
            txt_title_AB.TabIndex = 20;
            // 
            // txt_ISBN_AB
            // 
            txt_ISBN_AB.BackColor = SystemColors.Info;
            txt_ISBN_AB.Location = new Point(231, 62);
            txt_ISBN_AB.Name = "txt_ISBN_AB";
            txt_ISBN_AB.Size = new Size(260, 27);
            txt_ISBN_AB.TabIndex = 19;
            // 
            // lbl_categories_LF
            // 
            lbl_categories_LF.AutoSize = true;
            lbl_categories_LF.BackColor = Color.Transparent;
            lbl_categories_LF.BorderStyle = BorderStyle.FixedSingle;
            lbl_categories_LF.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            lbl_categories_LF.ForeColor = SystemColors.ButtonHighlight;
            lbl_categories_LF.Location = new Point(83, 359);
            lbl_categories_LF.Name = "lbl_categories_LF";
            lbl_categories_LF.Size = new Size(105, 30);
            lbl_categories_LF.TabIndex = 18;
            lbl_categories_LF.Text = "Category";
            // 
            // cmbBox_categories_AB
            // 
            cmbBox_categories_AB.BackColor = SystemColors.Info;
            cmbBox_categories_AB.FormattingEnabled = true;
            cmbBox_categories_AB.Location = new Point(231, 359);
            cmbBox_categories_AB.Name = "cmbBox_categories_AB";
            cmbBox_categories_AB.Size = new Size(260, 28);
            cmbBox_categories_AB.TabIndex = 30;
            // 
            // btn_save_AB
            // 
            btn_save_AB.BackColor = SystemColors.ActiveCaptionText;
            btn_save_AB.Cursor = Cursors.Hand;
            btn_save_AB.FlatStyle = FlatStyle.Flat;
            btn_save_AB.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            btn_save_AB.ForeColor = SystemColors.ButtonHighlight;
            btn_save_AB.Location = new Point(231, 414);
            btn_save_AB.Name = "btn_save_AB";
            btn_save_AB.Size = new Size(260, 49);
            btn_save_AB.TabIndex = 24;
            btn_save_AB.Text = "Save";
            btn_save_AB.UseVisualStyleBackColor = false;
            btn_save_AB.Click += btn_save_AB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(83, 123);
            label1.Name = "label1";
            label1.Size = new Size(61, 30);
            label1.TabIndex = 25;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(83, 190);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 26;
            label2.Text = "Author";
            // 
            // lbl_ISBN_AB
            // 
            lbl_ISBN_AB.AutoSize = true;
            lbl_ISBN_AB.BackColor = Color.Transparent;
            lbl_ISBN_AB.BorderStyle = BorderStyle.FixedSingle;
            lbl_ISBN_AB.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            lbl_ISBN_AB.ForeColor = SystemColors.ButtonHighlight;
            lbl_ISBN_AB.Location = new Point(83, 62);
            lbl_ISBN_AB.Name = "lbl_ISBN_AB";
            lbl_ISBN_AB.Size = new Size(64, 30);
            lbl_ISBN_AB.TabIndex = 27;
            lbl_ISBN_AB.Text = "ISBN";
            // 
            // lbl_puplishYear_AB
            // 
            lbl_puplishYear_AB.AutoSize = true;
            lbl_puplishYear_AB.BackColor = Color.Transparent;
            lbl_puplishYear_AB.BorderStyle = BorderStyle.FixedSingle;
            lbl_puplishYear_AB.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            lbl_puplishYear_AB.ForeColor = SystemColors.ButtonHighlight;
            lbl_puplishYear_AB.Location = new Point(83, 244);
            lbl_puplishYear_AB.Name = "lbl_puplishYear_AB";
            lbl_puplishYear_AB.Size = new Size(141, 30);
            lbl_puplishYear_AB.TabIndex = 28;
            lbl_puplishYear_AB.Text = "Puplish Year";
            // 
            // lbl_quantity_AB
            // 
            lbl_quantity_AB.AutoSize = true;
            lbl_quantity_AB.BackColor = Color.Transparent;
            lbl_quantity_AB.BorderStyle = BorderStyle.FixedSingle;
            lbl_quantity_AB.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            lbl_quantity_AB.ForeColor = SystemColors.ButtonHighlight;
            lbl_quantity_AB.Location = new Point(83, 300);
            lbl_quantity_AB.Name = "lbl_quantity_AB";
            lbl_quantity_AB.Size = new Size(104, 30);
            lbl_quantity_AB.TabIndex = 29;
            lbl_quantity_AB.Text = "Quantity";
            // 
            // numericUpDown_puplishYear_AB
            // 
            numericUpDown_puplishYear_AB.BackColor = SystemColors.Info;
            numericUpDown_puplishYear_AB.Location = new Point(231, 248);
            numericUpDown_puplishYear_AB.Name = "numericUpDown_puplishYear_AB";
            numericUpDown_puplishYear_AB.Size = new Size(261, 27);
            numericUpDown_puplishYear_AB.TabIndex = 31;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.BurlyWood;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(527, 13);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(573, 527);
            Controls.Add(pictureBox2);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity_AB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_puplishYear_AB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBook));
            numericUpDown_puplishYear_AB = new NumericUpDown();
            btn_save_AB = new Button();
            txt_auth_AB = new TextBox();
            numericUpDown_quantity_AB = new NumericUpDown();
            txt_title_AB = new TextBox();
            txt_ISBN_AB = new TextBox();
            cmbBox_categories_EB = new ComboBox();
            lbl_quantity_AB = new Label();
            lbl_puplishYear_AB = new Label();
            lbl_ISBN_AB = new Label();
            label2 = new Label();
            label1 = new Label();
            lbl_categories_LF = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_puplishYear_AB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity_AB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown_puplishYear_AB
            // 
            numericUpDown_puplishYear_AB.BackColor = SystemColors.Info;
            numericUpDown_puplishYear_AB.Location = new Point(244, 230);
            numericUpDown_puplishYear_AB.Name = "numericUpDown_puplishYear_AB";
            numericUpDown_puplishYear_AB.Size = new Size(260, 27);
            numericUpDown_puplishYear_AB.TabIndex = 44;
            // 
            // btn_save_AB
            // 
            btn_save_AB.BackColor = SystemColors.ActiveCaptionText;
            btn_save_AB.Cursor = Cursors.Hand;
            btn_save_AB.FlatStyle = FlatStyle.Flat;
            btn_save_AB.ForeColor = SystemColors.ButtonHighlight;
            btn_save_AB.Location = new Point(244, 406);
            btn_save_AB.Name = "btn_save_AB";
            btn_save_AB.Size = new Size(260, 49);
            btn_save_AB.TabIndex = 37;
            btn_save_AB.Text = "Save changes";
            btn_save_AB.UseVisualStyleBackColor = false;
            btn_save_AB.Click += btn_save_AB_Click;
            // 
            // txt_auth_AB
            // 
            txt_auth_AB.BackColor = SystemColors.Info;
            txt_auth_AB.Location = new Point(244, 173);
            txt_auth_AB.Name = "txt_auth_AB";
            txt_auth_AB.Size = new Size(260, 27);
            txt_auth_AB.TabIndex = 36;
            // 
            // numericUpDown_quantity_AB
            // 
            numericUpDown_quantity_AB.BackColor = SystemColors.Info;
            numericUpDown_quantity_AB.Location = new Point(244, 287);
            numericUpDown_quantity_AB.Name = "numericUpDown_quantity_AB";
            numericUpDown_quantity_AB.Size = new Size(260, 27);
            numericUpDown_quantity_AB.TabIndex = 35;
            // 
            // txt_title_AB
            // 
            txt_title_AB.BackColor = SystemColors.Info;
            txt_title_AB.Location = new Point(244, 109);
            txt_title_AB.Name = "txt_title_AB";
            txt_title_AB.Size = new Size(260, 27);
            txt_title_AB.TabIndex = 34;
            // 
            // txt_ISBN_AB
            // 
            txt_ISBN_AB.BackColor = SystemColors.Info;
            txt_ISBN_AB.Location = new Point(244, 45);
            txt_ISBN_AB.Name = "txt_ISBN_AB";
            txt_ISBN_AB.Size = new Size(260, 27);
            txt_ISBN_AB.TabIndex = 33;
            // 
            // cmbBox_categories_EB
            // 
            cmbBox_categories_EB.BackColor = SystemColors.Info;
            cmbBox_categories_EB.FormattingEnabled = true;
            cmbBox_categories_EB.Location = new Point(244, 346);
            cmbBox_categories_EB.Name = "cmbBox_categories_EB";
            cmbBox_categories_EB.Size = new Size(260, 28);
            cmbBox_categories_EB.TabIndex = 43;
            // 
            // lbl_quantity_AB
            // 
            lbl_quantity_AB.AutoSize = true;
            lbl_quantity_AB.BackColor = Color.Transparent;
            lbl_quantity_AB.BorderStyle = BorderStyle.FixedSingle;
            lbl_quantity_AB.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            lbl_quantity_AB.ForeColor = SystemColors.ButtonHighlight;
            lbl_quantity_AB.Location = new Point(91, 283);
            lbl_quantity_AB.Name = "lbl_quantity_AB";
            lbl_quantity_AB.Size = new Size(104, 30);
            lbl_quantity_AB.TabIndex = 50;
            lbl_quantity_AB.Text = "Quantity";
            // 
            // lbl_puplishYear_AB
            // 
            lbl_puplishYear_AB.AutoSize = true;
            lbl_puplishYear_AB.BackColor = Color.Transparent;
            lbl_puplishYear_AB.BorderStyle = BorderStyle.FixedSingle;
            lbl_puplishYear_AB.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            lbl_puplishYear_AB.ForeColor = SystemColors.ButtonHighlight;
            lbl_puplishYear_AB.Location = new Point(91, 227);
            lbl_puplishYear_AB.Name = "lbl_puplishYear_AB";
            lbl_puplishYear_AB.Size = new Size(141, 30);
            lbl_puplishYear_AB.TabIndex = 49;
            lbl_puplishYear_AB.Text = "Puplish Year";
            // 
            // lbl_ISBN_AB
            // 
            lbl_ISBN_AB.AutoSize = true;
            lbl_ISBN_AB.BackColor = Color.Transparent;
            lbl_ISBN_AB.BorderStyle = BorderStyle.FixedSingle;
            lbl_ISBN_AB.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            lbl_ISBN_AB.ForeColor = SystemColors.ButtonHighlight;
            lbl_ISBN_AB.Location = new Point(91, 45);
            lbl_ISBN_AB.Name = "lbl_ISBN_AB";
            lbl_ISBN_AB.Size = new Size(64, 30);
            lbl_ISBN_AB.TabIndex = 48;
            lbl_ISBN_AB.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(91, 173);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 47;
            label2.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(91, 106);
            label1.Name = "label1";
            label1.Size = new Size(61, 30);
            label1.TabIndex = 46;
            label1.Text = "Title";
            // 
            // lbl_categories_LF
            // 
            lbl_categories_LF.AutoSize = true;
            lbl_categories_LF.BackColor = Color.Transparent;
            lbl_categories_LF.BorderStyle = BorderStyle.FixedSingle;
            lbl_categories_LF.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            lbl_categories_LF.ForeColor = SystemColors.ButtonHighlight;
            lbl_categories_LF.Location = new Point(91, 342);
            lbl_categories_LF.Name = "lbl_categories_LF";
            lbl_categories_LF.Size = new Size(105, 30);
            lbl_categories_LF.TabIndex = 45;
            lbl_categories_LF.Text = "Category";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.BurlyWood;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(545, 13);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(591, 502);
            Controls.Add(pictureBox2);
            Controls.Add(lbl_quantity_AB);
            Controls.Add(lbl_puplishYear_AB);
            Controls.Add(lbl_ISBN_AB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_categories_LF);
            Controls.Add(numericUpDown_puplishYear_AB);
            Controls.Add(btn_save_AB);
            Controls.Add(txt_auth_AB);
            Controls.Add(numericUpDown_quantity_AB);
            Controls.Add(txt_title_AB);
            Controls.Add(txt_ISBN_AB);
            Controls.Add(cmbBox_categories_EB);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_puplishYear_AB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity_AB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown_puplishYear_AB;
        private Button btn_save_AB;
        private TextBox txt_auth_AB;
        private NumericUpDown numericUpDown_quantity_AB;
        private TextBox txt_title_AB;
        private TextBox txt_ISBN_AB;
        private ComboBox cmbBox_categories_EB;
        private Label lbl_quantity_AB;
        private Label lbl_puplishYear_AB;
        private Label lbl_ISBN_AB;
        private Label label2;
        private Label label1;
        private Label lbl_categories_LF;
        private PictureBox pictureBox2;
    }
}
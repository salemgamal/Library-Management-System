namespace Library.Presentation.Admin
{
    partial class ManageMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMembers));
            showIcon = new PictureBox();
            hideIcon = new PictureBox();
            btn_back_ML = new Button();
            btn_delete_MM = new Button();
            btn_update_MM = new Button();
            btn_add_MM = new Button();
            txt_Phone_MM = new TextBox();
            label7 = new Label();
            txt_userPass_MM = new TextBox();
            label5 = new Label();
            txt_userEmail_MM = new TextBox();
            label4 = new Label();
            txt_Name_MM = new TextBox();
            label3 = new Label();
            txt_userName_MM = new TextBox();
            label2 = new Label();
            dgv_Members = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)showIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hideIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Members).BeginInit();
            SuspendLayout();
            // 
            // showIcon
            // 
            showIcon.Image = (Image)resources.GetObject("showIcon.Image");
            showIcon.Location = new Point(662, 147);
            showIcon.Name = "showIcon";
            showIcon.Size = new Size(23, 22);
            showIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            showIcon.TabIndex = 40;
            showIcon.TabStop = false;
            showIcon.Click += showIcon_Click;
            // 
            // hideIcon
            // 
            hideIcon.Image = (Image)resources.GetObject("hideIcon.Image");
            hideIcon.Location = new Point(662, 147);
            hideIcon.Name = "hideIcon";
            hideIcon.Size = new Size(24, 22);
            hideIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            hideIcon.TabIndex = 39;
            hideIcon.TabStop = false;
            hideIcon.Click += hideIcon_Click;
            // 
            // btn_back_ML
            // 
            btn_back_ML.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back_ML.Location = new Point(49, 404);
            btn_back_ML.Name = "btn_back_ML";
            btn_back_ML.Size = new Size(82, 29);
            btn_back_ML.TabIndex = 38;
            btn_back_ML.Text = "back";
            btn_back_ML.UseVisualStyleBackColor = true;
            btn_back_ML.Click += btn_back_ML_Click;
            // 
            // btn_delete_MM
            // 
            btn_delete_MM.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete_MM.Location = new Point(627, 369);
            btn_delete_MM.Name = "btn_delete_MM";
            btn_delete_MM.Size = new Size(75, 31);
            btn_delete_MM.TabIndex = 37;
            btn_delete_MM.Text = "Delete";
            btn_delete_MM.UseVisualStyleBackColor = true;
            btn_delete_MM.Click += btn_delete_MM_Click;
            // 
            // btn_update_MM
            // 
            btn_update_MM.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_MM.Location = new Point(528, 369);
            btn_update_MM.Name = "btn_update_MM";
            btn_update_MM.Size = new Size(75, 31);
            btn_update_MM.TabIndex = 36;
            btn_update_MM.Text = "update";
            btn_update_MM.UseVisualStyleBackColor = true;
            btn_update_MM.Click += btn_update_MM_Click;
            // 
            // btn_add_MM
            // 
            btn_add_MM.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_MM.Location = new Point(436, 369);
            btn_add_MM.Name = "btn_add_MM";
            btn_add_MM.Size = new Size(75, 31);
            btn_add_MM.TabIndex = 35;
            btn_add_MM.Text = "Add";
            btn_add_MM.UseVisualStyleBackColor = true;
            btn_add_MM.Click += btn_add_MM_Click;
            // 
            // txt_Phone_MM
            // 
            txt_Phone_MM.Location = new Point(528, 284);
            txt_Phone_MM.Name = "txt_Phone_MM";
            txt_Phone_MM.Size = new Size(158, 23);
            txt_Phone_MM.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(436, 283);
            label7.Name = "label7";
            label7.Size = new Size(52, 19);
            label7.TabIndex = 32;
            label7.Text = "Phone";
            // 
            // txt_userPass_MM
            // 
            txt_userPass_MM.Location = new Point(528, 146);
            txt_userPass_MM.Name = "txt_userPass_MM";
            txt_userPass_MM.PasswordChar = '●';
            txt_userPass_MM.Size = new Size(158, 23);
            txt_userPass_MM.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(436, 145);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 29;
            label5.Text = "Password";
            // 
            // txt_userEmail_MM
            // 
            txt_userEmail_MM.Location = new Point(528, 190);
            txt_userEmail_MM.Name = "txt_userEmail_MM";
            txt_userEmail_MM.Size = new Size(158, 23);
            txt_userEmail_MM.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(440, 238);
            label4.Name = "label4";
            label4.Size = new Size(49, 19);
            label4.TabIndex = 27;
            label4.Text = "Name";
            // 
            // txt_Name_MM
            // 
            txt_Name_MM.Location = new Point(528, 238);
            txt_Name_MM.Name = "txt_Name_MM";
            txt_Name_MM.Size = new Size(158, 23);
            txt_Name_MM.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(440, 190);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 25;
            label3.Text = "Email";
            // 
            // txt_userName_MM
            // 
            txt_userName_MM.Location = new Point(528, 103);
            txt_userName_MM.Name = "txt_userName_MM";
            txt_userName_MM.Size = new Size(158, 23);
            txt_userName_MM.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(436, 102);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 23;
            label2.Text = "UserName";
            // 
            // dgv_Members
            // 
            dgv_Members.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Members.Location = new Point(26, 102);
            dgv_Members.Name = "dgv_Members";
            dgv_Members.Size = new Size(373, 256);
            dgv_Members.TabIndex = 22;
            dgv_Members.RowHeaderMouseDoubleClick += dgv_Members_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 12);
            label1.Name = "label1";
            label1.Size = new Size(245, 35);
            label1.TabIndex = 21;
            label1.Text = "Manage Librarian";
            // 
            // ManageMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 449);
            Controls.Add(showIcon);
            Controls.Add(hideIcon);
            Controls.Add(btn_back_ML);
            Controls.Add(btn_delete_MM);
            Controls.Add(btn_update_MM);
            Controls.Add(btn_add_MM);
            Controls.Add(txt_Phone_MM);
            Controls.Add(label7);
            Controls.Add(txt_userPass_MM);
            Controls.Add(label5);
            Controls.Add(txt_userEmail_MM);
            Controls.Add(label4);
            Controls.Add(txt_Name_MM);
            Controls.Add(label3);
            Controls.Add(txt_userName_MM);
            Controls.Add(label2);
            Controls.Add(dgv_Members);
            Controls.Add(label1);
            Name = "ManageMembers";
            Text = "ManageMembers";
            Load += ManageMembers_Load;
            ((System.ComponentModel.ISupportInitialize)showIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)hideIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Members).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox showIcon;
        private PictureBox hideIcon;
        private Button btn_back_ML;
        private Button btn_delete_MM;
        private Button btn_update_MM;
        private Button btn_add_MM;
        private TextBox txt_Phone_MM;
        private Label label7;
        private TextBox txt_userPass_MM;
        private Label label5;
        private TextBox txt_userEmail_MM;
        private Label label4;
        private TextBox txt_Name_MM;
        private Label label3;
        private TextBox txt_userName_MM;
        private Label label2;
        private DataGridView dgv_Members;
        private Label label1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Presentation.Forms.Authentication_Forms;

namespace Library.Presentation.Forms.Librarian_Forms
{
    public partial class HomeLibrarian : Form
    {
        Login preForm;
        public HomeLibrarian(Login login)
        {
            InitializeComponent();
            preForm = login;
        }

        private void btn_managment_HL_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageBooks manage = new ManageBooks(this);
            manage.ShowDialog();
            this.Show();
        }

        private void btn_reports_HL_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowReturn borrowReturn = new BorrowReturn(this);
            borrowReturn.ShowDialog();
            this.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            preForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

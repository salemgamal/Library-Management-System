using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Presentation.Admin
{
    public partial class AdminDashBoard : Form
    {
        Form oldForm;
        public AdminDashBoard(Form old)
        {
            InitializeComponent();
            oldForm = old;
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btn_Manage_Librarian_AD_Click(object sender, EventArgs e)
        {
            ManageLibrarian manageLibrarian = new ManageLibrarian(this);
            this.Hide();
            manageLibrarian.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageAdmins manageAdmins = new ManageAdmins(this);
            this.Hide();
            manageAdmins.Show();
        }

        private void btn_ManageMembers_AD_Click(object sender, EventArgs e)
        {
            ManageMembers manageMembers = new ManageMembers(this);
            this.Hide();
            manageMembers.Show();
        }

        private void btn_ManageBooks_AD_Click(object sender, EventArgs e)
        {
            ManageBooks manageBooks = new ManageBooks(this);
            this.Hide();
            manageBooks.Show();
        }



        private void btn_back_AD_Click(object sender, EventArgs e)
        {
            this.Close();
            oldForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

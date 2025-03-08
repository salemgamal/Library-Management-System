using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Presentation.Forms.Librarian_Forms
{
    public partial class HomeLibrarian : Form
    {
        public HomeLibrarian()
        {
            InitializeComponent();
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
    }
}

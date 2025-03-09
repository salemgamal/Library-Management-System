using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Presentation.Forms.Authentication_Forms
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btn_login_W_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Login login = new Login(this);
            login.ShowDialog();
            
        }

        private void btn_register_W_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register(this);
            register.ShowDialog();
            
        }

        
    }
}

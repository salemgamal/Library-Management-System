using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.BusinessLogic.Services;
using Library.DataAccess.Models;
using Library.DataAccess.Repositry;

namespace Library.Presentation.Forms.Authentication_Forms
{
    public partial class Login : Form
    {
        LibraryDbContext context;
        UserRepository userRepo;
        UserService userService;
        Form oldForm;

        public Login(Form oldF)
        {
            InitializeComponent();
            context = new LibraryDbContext();
            userRepo = new UserRepository(context);
            userService = new UserService(userRepo);
            oldForm = oldF;
        }

        //login button click
        private void btn_login_L_Click(object sender, EventArgs e)
        {
            string username = txt_userName_L.Text.Trim();
            string password = txt_pass_L.Text;

            //check username and pass are filled
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //authenticate user

            try
            {
                User user = userService.AuthenticateUser(username, password);
                //redirect user based on his role
                if (user.Role == UserRole.Admin)
                {
                    //this.Hide();
                    MessageBox.Show("admin");
                }
                else if (user.Role == UserRole.Librarian)
                {
                    //this.Hide();
                    MessageBox.Show("libr");

                }
                else if (user.Role == UserRole.Member)
                {
                    //this.Hide();
                    MessageBox.Show("user");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




        }

        // show and hide password
        private void pictureBox_passEye_Click(object sender, EventArgs e)
        {
            if (txt_pass_L.PasswordChar == '●')
            {
                txt_pass_L.PasswordChar = '\0';
                pictureBox_passEye.Image = Properties.Resources.eyeopen;
            }
            else
            {
                txt_pass_L.PasswordChar = '●';
                pictureBox_passEye.Image = Properties.Resources.eyeclosed;
            }
        }

        private void btn_back_L_Click(object sender, EventArgs e)
        {
            this.Hide();
            oldForm.Show();
        }
    }
}

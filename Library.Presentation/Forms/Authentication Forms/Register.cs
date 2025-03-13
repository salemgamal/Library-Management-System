using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.BusinessLogic.Services;
using Library.DataAccess.Models;
using Library.DataAccess.Repositry;

namespace Library.Presentation.Forms.Authentication_Forms
{
    public partial class Register : Form
    {
        LibraryDbContext context;
        UserRepository userRepo;
        UserService userService;
        Form oldForm;
        public Register(Form oldF)
        {
            InitializeComponent();
            context = new LibraryDbContext();
            userRepo = new UserRepository(context);
            userService = new UserService(userRepo);
            oldForm = oldF;
        }

        // button register click
        private void btn_register_R_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string username = txt_userName_R.Text;
            string email = txt_email_R.Text;
            string phone = txt_phone_R.Text;
            string pass = txt_pass_R.Text;
            string confirmPass = txt_confirmPass_R.Text;

            //check all field are filled
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check for email validity
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //check if username or email already exists
            if (userService.GetAllUsers().ToList().Find(user => user.UserName == username || user.Email == email) != null)
            {
                MessageBox.Show("Username or email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //check for phone validity
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Please enter a valid Egyptian phone number.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //check if password match confirm password
            if (pass != confirmPass)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //inserting new user
            User user = new User
            {
                Name = name,
                UserName = username,
                Email = email,
                Phone = phone,
                Password = pass,
                Role = UserRole.Member
            };

            userService.AddUser(user);

            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //redirection to login
            Register register = this;
            register.Hide();
            Login login = new Login(this);
            login.ShowDialog();
            register.Close();
        }

        //function email validity
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        //function phone validity
        private bool IsValidPhone(string phoneNumber)
        {
            string pattern = @"^(\+20)?(010|011|012|015)\d{8}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        // show and hide password
        private void pictureBox_passEye_Click(object sender, EventArgs e)
        {
            if (txt_pass_R.PasswordChar == '●')
            {
                txt_pass_R.PasswordChar = txt_confirmPass_R.PasswordChar = '\0';
                pictureBox_passEye.Image = Properties.Resources.eyeopen;
            }
            else
            {
                txt_pass_R.PasswordChar = txt_confirmPass_R.PasswordChar = '●';
                pictureBox_passEye.Image = Properties.Resources.eyeclosed;
            }
        }

        private void btn_back_R_Click(object sender, EventArgs e)
        {
            this.Hide();
            oldForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
    }
}

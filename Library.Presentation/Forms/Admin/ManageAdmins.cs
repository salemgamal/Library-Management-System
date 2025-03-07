using Library.BusinessLogic.Services;
using Library.DataAccess.Models;
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

namespace Library.Presentation.Admin
{
    public partial class ManageAdmins : Form

    {
        UserService userService;
        LibraryDbContext context;
        Form newF;
        public ManageAdmins(Form newForm)
        {
            InitializeComponent();
            context = new LibraryDbContext();
            userService = new UserService(new DataAccess.Repositry.UserRepository(context));
            newF = newForm;
        }

        private void ManageAdmins_Load(object sender, EventArgs e)
        {
            load_DGV();

        }


        //load data to dgv
        public void load_DGV()
        {
            var admins = userService.GetUserByRole(UserRole.Admin);
            if (admins != null && admins.Any())
            {
                dgv_Admins.DataSource = admins;
            }
            else
            {
                MessageBox.Show("no admins found");
            }
        }

        //clear Inputs

        public void ClearInouts()
        {
            txt_userName_MA.Text = txt_userPass_MA.Text = txt_userEmail_MA.Text = txt_Name_MA.Text = txt_Phone_MA.Text = "";
            cb_Role.SelectedValue = null;
        }



        //function email validity
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Enter a valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

        }

        //function phone validity
        public bool IsValidPhone(string phoneNumber)
        {
            string pattern = @"^(\+20)?(010|011|012|015)\d{8}$";
            if (Regex.IsMatch(phoneNumber, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Enter a valid Phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

        }



        //}
        public bool validateEmpty(string username, string Password, string email, string name, string phone)
        {
            return (string.IsNullOrWhiteSpace(username) ||
              string.IsNullOrWhiteSpace(Password) ||
              string.IsNullOrWhiteSpace(email) ||
              string.IsNullOrWhiteSpace(name) ||
              string.IsNullOrWhiteSpace(phone));
        }

        private void btn_add_MA_Click(object sender, EventArgs e)
        {
            string username = txt_userName_MA.Text;
            string password = txt_userPass_MA.Text;
            string email = txt_userEmail_MA.Text;
            string name = txt_Name_MA.Text;
            string phone = txt_Phone_MA.Text;



            //validate and add
            if (validateEmpty(username, password, email, name, phone))
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

            //check for phone validity
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Please enter a valid Egyptian phone number.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User newUser = new User()
            {
                UserName = username,
                Password = password,
                Email = email,
                Name = name,
                Phone = phone,
                Role = UserRole.Admin,

            };

            userService.AddUser(newUser);
            load_DGV();
            ClearInouts();
            MessageBox.Show("Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void btn_update_MA_Click(object sender, EventArgs e)
        {
            string username = txt_userName_MA.Text;
            string password = txt_userPass_MA.Text;
            string email = txt_userEmail_MA.Text;
            string name = txt_Name_MA.Text;
            string phone = txt_Phone_MA.Text;

            //check that user select arow 
            if (!(dgv_Admins.SelectedRows.Count > 0))
            {
                MessageBox.Show("No row selected.");
                return;
            }

            //validate and add
            if (validateEmpty(username, password, email, name, phone))
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

            //check for phone validity
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Please enter a valid Egyptian phone number.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User admin = userService.GetUserById(ID);

            if (admin != null)
            {
                admin.UserName = txt_userName_MA.Text;
                admin.Password = txt_userPass_MA.Text;
                admin.Email = txt_userEmail_MA.Text;
                admin.Name = txt_Name_MA.Text;
                admin.Phone = txt_Phone_MA.Text;
                admin.Role = UserRole.Admin;

                userService.UpdateUser(admin);
                load_DGV();
                ClearInouts();
                MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            btn_add_MA.Show();
        }


        int ID;
        private void dgv_Admins_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            btn_add_MA.Hide();

            ID = (int)dgv_Admins.SelectedRows[0].Cells[0].Value;
            User admin = userService.GetUserById(ID);
            if (admin != null)
            {
                txt_userName_MA.Text = admin.UserName;
                txt_userPass_MA.Text = admin.Password;
                txt_userEmail_MA.Text = admin.Email;
                txt_Name_MA.Text = admin.Name;
                txt_Phone_MA.Text = admin.Phone;
                cb_Role.SelectedItem = admin.Role.ToString();
            }
        }

        private void btn_delete_MA_Click(object sender, EventArgs e)
        {

            if (!(dgv_Admins.SelectedRows.Count > 0))
            {
                MessageBox.Show("No row selected.");
                return;
            }

            userService.DeleteUser(ID);
            load_DGV();
            ClearInouts();
            btn_add_MA.Show();
            MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void showIcon_Click(object sender, EventArgs e)
        {
            if (txt_userPass_MA.PasswordChar == '●')
            {
                txt_userPass_MA.PasswordChar = '\0';
                hideIcon.Visible = true;
                showIcon.Visible = false;

            }
        }

        private void hideIcon_Click(object sender, EventArgs e)
        {
            if (txt_userPass_MA.PasswordChar == '\0')
            {
                txt_userPass_MA.PasswordChar = '●';
                hideIcon.Visible = false;
                showIcon.Visible = true;
            }
        }

        private void btn_back_ML_Click(object sender, EventArgs e)
        {
            this.Hide();
            newF.Show();
        }
    }
}

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
    public partial class ManageMembers : Form
    {
        UserService userService;
        LibraryDbContext context;
        Form oldForm;
        public ManageMembers(Form oldf)
        {
            InitializeComponent();
            context = new LibraryDbContext();
            userService = new UserService(new DataAccess.Repositry.UserRepository(context));
            oldForm = oldf;
        }


        //load data to dgv
        private void ManageMembers_Load(object sender, EventArgs e)
        {
            load_DGV();

        }

        //clear Inputs
        public void ClearInouts()
        {
            txt_userName_MM.Text = txt_userPass_MM.Text = txt_userEmail_MM.Text = txt_Name_MM.Text = txt_Phone_MM.Text = "";

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

        //validate empty fields
        public bool validateEmpty(string username, string Password, string email, string name, string phone)
        {
            return (string.IsNullOrWhiteSpace(username) ||
              string.IsNullOrWhiteSpace(Password) ||
              string.IsNullOrWhiteSpace(email) ||
              string.IsNullOrWhiteSpace(name) ||
              string.IsNullOrWhiteSpace(phone));
        }


        public void load_DGV()
        {
            var members = userService.GetUserByRole(UserRole.Member);
            if (members != null && members.Any())
            {
                dgv_Members.DataSource = members;
            }
            else
            {
                MessageBox.Show("no members found");
            }
        }

        int ID;
        private void dgv_Members_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_add_MM.Hide();

            ID = (int)dgv_Members.SelectedRows[0].Cells[0].Value;
            User member = userService.GetUserById(ID);
            if (member != null)
            {
                txt_userName_MM.Text = member.UserName;
                txt_userPass_MM.Text = member.Password;
                txt_userEmail_MM.Text = member.Email;
                txt_Name_MM.Text = member.Name;
                txt_Phone_MM.Text = member.Phone;

            }
        }

        private void btn_add_MM_Click(object sender, EventArgs e)
        {
            string username = txt_userName_MM.Text;
            string password = txt_userPass_MM.Text;
            string email = txt_userEmail_MM.Text;
            string name = txt_Name_MM.Text;
            string phone = txt_Phone_MM.Text;



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
                Role = UserRole.Member,

            };

            userService.AddUser(newUser);
            load_DGV();
            ClearInouts();
            MessageBox.Show("Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void btn_update_MM_Click(object sender, EventArgs e)
        {
            string username = txt_userName_MM.Text;
            string password = txt_userPass_MM.Text;
            string email = txt_userEmail_MM.Text;
            string name = txt_Name_MM.Text;
            string phone = txt_Phone_MM.Text;

            //check that user select arow 
            if (!(dgv_Members.SelectedRows.Count > 0))
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

            User member = userService.GetUserById(ID);


            if (member != null)
            {
                member.UserName = username;
                member.Password = password;
                member.Email = email;
                member.Name = name;
                member.Phone = phone;
                member.Role = UserRole.Member;

                userService.UpdateUser(member);
                load_DGV();
                ClearInouts();
                MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            btn_add_MM.Show();

        }

        private void btn_delete_MM_Click(object sender, EventArgs e)
        {
            if (!(dgv_Members.SelectedRows.Count > 0))
            {
                MessageBox.Show("No row selected.");
                return;
            }

            userService.DeleteUser(ID);
            load_DGV();
            ClearInouts();
            btn_add_MM.Show();
            MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void showIcon_Click(object sender, EventArgs e)
        {
            if (txt_userPass_MM.PasswordChar == '●')
            {
                txt_userPass_MM.PasswordChar = '\0';
                hideIcon.Visible = true;
                showIcon.Visible = false;

            }
        }

        private void hideIcon_Click(object sender, EventArgs e)
        {
            if (txt_userPass_MM.PasswordChar == '\0')
            {
                txt_userPass_MM.PasswordChar = '●';
                hideIcon.Visible = false;
                showIcon.Visible = true;
            }
        }

        private void btn_back_ML_Click(object sender, EventArgs e)
        {
            this.Close();
            oldForm.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

using Library.BusinessLogic.Services;
using Library.DataAccess.Models;
using Library.DataAccess.Repositry;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Library.Presentation.Admin
{
    public partial class ManageLibrarian : Form
    {
        UserService userService;
        LibraryDbContext context;
        Form oldForm;
        public ManageLibrarian(Form newForm)
        {
            InitializeComponent();
            context = new LibraryDbContext();
            userService = new UserService(new DataAccess.Repositry.UserRepository(context));
            oldForm = newForm;
        }


        private void ManageLibrarian_Load(object sender, EventArgs e)
        {

            load_DGV();
            label6.Hide();
            cb_Role.Hide();


        }

        //load data to dgv
        public void load_DGV()
        {
            var librarians = userService.GetUserByRole(UserRole.Librarian);
            if (librarians != null && librarians.Any())
            {
                dgv_Libraian.DataSource = librarians;
            }
            else
            {
                MessageBox.Show("no libtarian found");
            }



        }

        //clear Inputs
        public void ClearInouts()
        {
            txt_userName_ML.Text = txt_userPass_ML.Text = txt_userEmail_ML.Text = txt_Name_ML.Text = txt_Phone_ML.Text = "";
            cb_Role.SelectedValue = null;
        }

        //validate inputs
        public bool validateInputs()
        {

            if (string.IsNullOrWhiteSpace(txt_userName_ML.Text) ||
            string.IsNullOrWhiteSpace(txt_userPass_ML.Text) ||
            string.IsNullOrWhiteSpace(txt_userEmail_ML.Text) ||
            string.IsNullOrWhiteSpace(txt_Name_ML.Text) ||
            string.IsNullOrWhiteSpace(txt_Phone_ML.Text) ||
            cb_Role.SelectedValue == null)
            {
                return true;
            }
            else
            {
                return false;
            }



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


        //validate empty Fields
        public bool validateEmpty(string username, string Password, string email, string name, string phone)
        {
            return (string.IsNullOrWhiteSpace(username) ||
              string.IsNullOrWhiteSpace(Password) ||
              string.IsNullOrWhiteSpace(email) ||
              string.IsNullOrWhiteSpace(name) ||
              string.IsNullOrWhiteSpace(phone));
        }


        private void btn_add_ML_Click(object sender, EventArgs e)
        {
            string username = txt_userName_ML.Text;
            string password = txt_userPass_ML.Text;
            string email = txt_userEmail_ML.Text;
            string name = txt_Name_ML.Text;
            string phone = txt_Phone_ML.Text;



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
                Role = UserRole.Librarian,

            };

            userService.AddUser(newUser);
            load_DGV();
            ClearInouts();
            MessageBox.Show("Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }



        int ID;
        private void dgv_Libraian_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label6.Show();
            cb_Role.Show();
            btn_add_ML.Hide();

            ID = (int)dgv_Libraian.SelectedRows[0].Cells[0].Value;
            User librarian = userService.GetUserById(ID);
            if (librarian != null)
            {
                txt_userName_ML.Text = librarian.UserName;
                txt_userPass_ML.Text = librarian.Password;
                txt_userEmail_ML.Text = librarian.Email;
                txt_Name_ML.Text = librarian.Name;
                txt_Phone_ML.Text = librarian.Phone;
                cb_Role.SelectedItem = librarian.Role.ToString();
            }


        }

        private void btn_update_ML_Click(object sender, EventArgs e)
        {
            string username = txt_userName_ML.Text;
            string password = txt_userPass_ML.Text;
            string email = txt_userEmail_ML.Text;
            string name = txt_Name_ML.Text;
            string phone = txt_Phone_ML.Text;



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
            //check that user select arow 
            if (!(dgv_Libraian.SelectedRows.Count > 0))
            {
                MessageBox.Show("No row selected.");
                return;
            }

            //get role and check its values
            string selectedRole = Convert.ToString(cb_Role.SelectedItem);
            UserRole role;

            if (selectedRole == "Admin")
            {
                role = UserRole.Admin;
            }
            else if (selectedRole == "Librarian")
            {
                role = UserRole.Librarian;
            }
            else
            {
                MessageBox.Show("Invalid user role selected.");
                return;
            }

            User librarian = userService.GetUserById(ID);


            if (librarian != null)
            {
                librarian.UserName = username;
                librarian.Password = password;
                librarian.Email = email;
                librarian.Name = name;
                librarian.Phone = phone;
                librarian.Role = role;

                userService.UpdateUser(librarian);
                load_DGV();
                ClearInouts();
                MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            label6.Hide();
            cb_Role.Hide();
            btn_add_ML.Show();
        }

        private void btn_delete_ML_Click(object sender, EventArgs e)
        {
            //check that user select arow 
            if (!(dgv_Libraian.SelectedRows.Count > 0))
            {
                MessageBox.Show("No row selected.");
                return;
            }


            userService.DeleteUser(ID);
            load_DGV();
            ClearInouts();
            btn_add_ML.Show();
            MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //hide pass
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (txt_userPass_ML.PasswordChar == '\0')
            {
                txt_userPass_ML.PasswordChar = '●';
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;


            }

        }
        //show pass
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txt_userPass_ML.PasswordChar == '●')
            {
                txt_userPass_ML.PasswordChar = '\0';
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;


            }

        }

        private void btn_back_ML_Click(object sender, EventArgs e)
        {
            this.Hide();
            oldForm.Show();
        }

        private void btn_manageLib_MLF_Click(object sender, EventArgs e)
        {
            this.Close();
            oldForm.Show();
        }
    }
}

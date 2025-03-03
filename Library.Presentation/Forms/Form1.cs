using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.DataAccess.Models;
using Library.DataAccess.Repositry;

namespace Library.Presentation.Forms
{
    public partial class Form1 : Form
    {
        public UserRepository userRepository;
        public Form1()
        {
            InitializeComponent();
            var context = new LibraryDbContext();
            userRepository = new UserRepository(context);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var users = userRepository.GetAllUsers();
            dataGridView1.DataSource = users;

        }
    }
}

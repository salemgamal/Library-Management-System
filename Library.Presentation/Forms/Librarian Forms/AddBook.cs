using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.BusinessLogic.Services;
using Library.DataAccess.Models;
using Library.DataAccess.Repositories;
using Library.DataAccess.Repositry;

namespace Library.Presentation.Forms.Librarian_Forms
{
    public partial class AddBook : Form
    {
        LibraryDbContext context;
        BookRepository bookRepo;
        BookService bookService;
        BorrowRecordRepository recordRepository;
        LogActionRepositry actionRepositry;
        public AddBook(ManageBooks MB)
        {
            InitializeComponent();
            context = new LibraryDbContext();
            bookRepo = new BookRepository(context);
            bookService = new BookService(bookRepo);

            cmbBox_categories_AB.Items.AddRange(new string[]
    {
        "Fiction",
        "Non-Fiction",
        "Science",
        "History",
        "Biography",
        "Technology",
        "Philosophy",
        "Children",
        "Self-Help",
        "Fantasy",
        "Politics"
    });

        }

        private void btn_save_AB_Click(object sender, EventArgs e)
        {

            string isbn = txt_ISBN_AB.Text.Trim();
            string title = txt_title_AB.Text.Trim();
            string author = txt_auth_AB.Text.Trim();
            int publishedYear = Convert.ToInt32(numericUpDown_puplishYear_AB.Value);
            int quantity = Convert.ToInt32(numericUpDown_quantity_AB.Value);
            string category = cmbBox_categories_AB.SelectedItem?.ToString() ?? "";

            //check all fields are filled
            if (string.IsNullOrWhiteSpace(isbn) ||
                string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(author) ||
                category == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate PublishedYear (should be a number within range)
            if (publishedYear < 1450 || publishedYear > 2100)
            {
                MessageBox.Show("Published Year must be a valid number between 1450 and 2100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Quantity (should be a positive integer)

            if (quantity < 0 || quantity > 1000)
            {
                MessageBox.Show("Quantity must be between 0 and 1000.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate ISBN (Must be 10 or 13 digits and contain only numbers)
            if (!(isbn.Length == 10 || isbn.Length == 13) || !isbn.All(char.IsDigit))
            {
                MessageBox.Show("ISBN must be a valid 10 or 13-digit number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //adding new book
            Book book = new Book
            {
                ISBN = txt_ISBN_AB.Text,
                Title = txt_title_AB.Text,
                Author = txt_auth_AB.Text,
                PublishedYear = publishedYear,
                Quantity = quantity,
                Category = cmbBox_categories_AB.SelectedItem?.ToString() ?? ""
            };

            bookService.AddBook(book);
            MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

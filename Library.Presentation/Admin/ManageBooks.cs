using Library.BusinessLogic.Services;
using Library.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library.Presentation.Admin
{
    public partial class ManageBooks : Form
    {
        BookService bookService;
        LibraryDbContext context;
        Form oldForm;
        public ManageBooks(Form oldF)
        {
            InitializeComponent();
            context = new LibraryDbContext();
            bookService = new BookService(new DataAccess.Repositry.BookRepository(context));
            oldForm = oldF;
        }



        private void ManageBooks_Load(object sender, EventArgs e)
        {
            load_DGV();
        }

        public void load_DGV()
        {
            var book = bookService.GetAllBooks();
            if (book != null)
            {
                dgv_books.DataSource = book;
            }
            else
            {
                MessageBox.Show("no Books found");
            }
        }



        int ID;
        private void dgv_books_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_add_MB.Hide();

            ID = (int)dgv_books.SelectedRows[0].Cells[0].Value;
            Book book = bookService.GetBookById(ID);
            if (book != null)
            {
                txt_title_MB.Text = book.Title;
                txt_author_MB.Text = book.Author;
                txt_category_MB.Text = book.Category;
                txt_ISBN_MB.Text = book.ISBN;
                txt_publish_MB.Text = book.PublishedYear.ToString();
                txt_QTY_MB.Value = book.Quantity;

            }
        }

        //validate empty feilds
        public bool validateEmpty(string title, string author, string category, int publish, string ISBN, int quantity)
        {
            return (string.IsNullOrWhiteSpace(title) ||
                    string.IsNullOrWhiteSpace(author) ||
                    string.IsNullOrWhiteSpace(category) ||
                    publish < 1800 || publish > DateTime.Now.Year ||
                    string.IsNullOrWhiteSpace(ISBN) ||
                    quantity == 0);
        }

        //clearInput
        public void ClearInouts()
        {
            txt_author_MB.Text = txt_category_MB.Text = txt_ISBN_MB.Text = txt_publish_MB.Text = txt_title_MB.Text = "";
            txt_QTY_MB.Value = 0;

        }

        private void btn_add_MB_Click(object sender, EventArgs e)
        {
            string title = txt_title_MB.Text;
            string author = txt_author_MB.Text;
            string category = txt_category_MB.Text;
            string ISBN = txt_ISBN_MB.Text;
            int quantity = (int)txt_QTY_MB.Value;
            int publish;
            if (!int.TryParse(txt_publish_MB.Text, out publish) || publish < 1800 || publish > DateTime.Now.Year)
            {
                MessageBox.Show($"Please enter a valid year between 1800 and {DateTime.Now.Year}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //validate and add
            if (validateEmpty(title, author, category, publish, ISBN, quantity))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Book newbook = new Book()
            {
                Title = title,
                Author = author,
                ISBN = ISBN,
                Category = category,
                Quantity = quantity,
                PublishedYear = publish,
            };
            bookService.AddBook(newbook);
            load_DGV();
            ClearInouts();
            MessageBox.Show("Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_update_MB_Click(object sender, EventArgs e)
        {
            string title = txt_title_MB.Text;
            string author = txt_author_MB.Text;
            string category = txt_category_MB.Text;
            string ISBN = txt_ISBN_MB.Text;
            int quantity = (int)txt_QTY_MB.Value;

            int publish;
            if (!int.TryParse(txt_publish_MB.Text, out publish) || publish < 1800 || publish > DateTime.Now.Year)
            {
                MessageBox.Show($"Please enter a valid year between 1800 and {DateTime.Now.Year}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //check that user select arow 
            if (!(dgv_books.SelectedRows.Count > 0))
            {
                MessageBox.Show("No row selected.");
                return;
            }

            //validate and add
            if (validateEmpty(title, author, category, publish, ISBN, quantity))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            Book book = bookService.GetBookById(ID);
            if (book != null)
            {

                book.Title = title;
                book.Author = author;
                book.Category = category;
                book.ISBN = ISBN;
                book.PublishedYear = publish;
                book.Quantity = quantity;

                bookService.UpdateBook(book);
                load_DGV();
                ClearInouts();
                MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            btn_add_MB.Show();
        }

        private void btn_delete_MB_Click(object sender, EventArgs e)
        {
            if (!(dgv_books.SelectedRows.Count > 0))
            {
                MessageBox.Show("No row selected.");
                return;
            }

            bookService.DeleteBook(ID);
            load_DGV();
            ClearInouts();
            btn_add_MB.Show();
            MessageBox.Show(" Successfully Deleted ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_back_ML_Click(object sender, EventArgs e)
        {
            this.Hide();
            oldForm.Show();

        }
    }
}

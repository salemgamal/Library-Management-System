using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.Components.DictionaryAdapter;
using Library.BusinessLogic.Services;
using Library.DataAccess.Models;
using Library.DataAccess.Repositry;

namespace Library.Presentation.Forms.Librarian_Forms
{
    public partial class ManageBooks : Form
    {
        LibraryDbContext context;
        BookRepository bookRepo;
        BookService bookService;
        int bookId;
        public ManageBooks(HomeLibrarian home)
        {
            InitializeComponent();
            context = new LibraryDbContext();
            bookRepo = new BookRepository(context);
            bookService = new BookService(bookRepo);

            btn_edit_LF.Hide();
            btn_delete.Hide();
            //assigning combobox of categories
            cmbBox_categories_LF.Items.AddRange(new string[]
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

        //search
        private void btn_search_LF_Click(object sender, EventArgs e)
        {
            string searchKey = (txt_search_LF.Text?.Trim() ?? string.Empty) + " " +
                   (cmbBox_categories_LF.SelectedItem?.ToString() ?? string.Empty);

            if (tabControl.SelectedIndex == 0)
            {
                var searchedBooks = bookService.SearchBook(searchKey);
                //Avoid Unnecessary Assignments if No Change in the search(ex: if search box is empty) 
                if (dgv_all_MB.DataSource != searchedBooks)
                    dgv_all_MB.DataSource = searchedBooks;
            }
            else if (tabControl.SelectedIndex == 1)
            {
                var searchedAvailBooks = bookService.SearchAvailBook(searchKey);
                if (dgv_Available_MB.DataSource != searchedAvailBooks)
                    dgv_Available_MB.DataSource = searchedAvailBooks;
            }
        }

        //add
        private void btn_add_LF_Click(object sender, EventArgs e)
        {
            AddBook add = new AddBook(this);
            add.ShowDialog();
        }

        //edit
        private void btn_edit_LF_Click(object sender, EventArgs e)
        {
            EditBook edit = new EditBook(this, bookId);
            edit.ShowDialog();

            
            btn_edit_LF.Hide();
            btn_delete.Hide();

            // Refresh DataGridView after editing
            RefreshBookList();
        }

        //double click on row to both dgv of All books + Available Books
        private void DataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            //validate that 1- dgv is not  null, 2- user not selecting header 3-user not selecting more than one row
            if (dgv != null && e.RowIndex >= 0 && dgv.SelectedRows.Count > 0)
            {
                bookId = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                btn_edit_LF.Show();
                btn_delete.Show();
            }
            else
            {
                MessageBox.Show("No valid row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //delete
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bookService.DeleteBook(bookId);
                MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh DataGridView after deletion
                RefreshBookList();
            }

            btn_delete.Hide();
            btn_edit_LF.Hide();
        }

        //book list is loaded when switching tabs.
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshBookList();
        }

        //for reloading book list when any change happen
        private void RefreshBookList()
        {
            string searchKey = txt_search_LF.Text?.Trim() ?? string.Empty;

            if (tabControl.SelectedIndex == 0)
            {
                dgv_all_MB.DataSource = bookRepo.SearchBook(searchKey);
            }
            else if (tabControl.SelectedIndex == 1)
            {
                dgv_Available_MB.DataSource = bookRepo.SearchAvailableBook(searchKey);
            }
        }

    }
}

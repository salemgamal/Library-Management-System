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
using Library.DataAccess.Models;
using Library.DataAccess.Repositry;

namespace Library.Presentation.Forms.Librarian_Forms
{
    public partial class ManageBooks : Form
    {
        LibraryDbContext context;
        BookRepository bookRepo;
        BorrowRecordRepository borrowRecord;
        int bookId;
        public ManageBooks(HomeLibrarian home)
        {
            InitializeComponent();
            context = new LibraryDbContext();
            bookRepo = new BookRepository(context);
            borrowRecord = new BorrowRecordRepository(context);

            btn_edit_LF.Hide();
            btn_delete.Hide();
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

        private void btn_search_LF_Click(object sender, EventArgs e)
        {
            List<Book> searchedBooks = bookRepo.SearchBook(txt_search_LF.Text);
            dgv_all_MB.DataSource = searchedBooks;
        }

        private void btn_add_LF_Click(object sender, EventArgs e)
        {
            AddBook add = new AddBook(this);
            add.ShowDialog();
        }

        private void btn_edit_LF_Click(object sender, EventArgs e)
        {
            EditBook edit = new EditBook(this, bookId);
            edit.ShowDialog();
            btn_edit_LF.Hide();
        }

        private void dgv_search_LF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_all_MB.SelectedRows.Count > 0)
            {
                bookId = Convert.ToInt32(dgv_all_MB.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            btn_edit_LF.Show();
            btn_delete.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Delete the book
                bookRepo.DeleteBook(bookId);
                MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btn_delete.Hide();
        }

        private void btn_available_LF_Click(object sender, EventArgs e)
        {
            List<Book> availableBooks = bookRepo.GetAvailableBooks();
            dgv_all_MB.DataSource = availableBooks;
        }

        private void btn_borrowed_LF_Click(object sender, EventArgs e)
        {
            List<BorrowRecord> borrowedBooks = borrowRecord.GetAllBorrowedBooks();
            dgv_all_MB.DataSource = borrowedBooks;
        }

        private void btn_overDue_LF_Click(object sender, EventArgs e)
        {
            List<BorrowRecord> overDueBooks = borrowRecord.GetOverdueBooks();
            dgv_all_MB.DataSource =overDueBooks;
        }
    }
}

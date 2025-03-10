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

namespace Library.Presentation.Forms.MemberForms
{
    public partial class MemberMainF : Form
    {
        public BookService BookService;
        public BorrowRecordService BorrowRecordService;
        public int MemberID;
        public int BookID;
        Form Old;
        public MemberMainF(int MemberID, Form oldForm)
        {
            InitializeComponent();
            this.MemberID = MemberID;
            var context = new LibraryDbContext();
            var bookRepositty = new BookRepository(context);
            var borrowRecordRepositty = new BorrowRecordRepository(context);
            var logActionRepositry = new LogActionRepositry(context);
            BookService = new BookService(bookRepositty);
            BorrowRecordService = new BorrowRecordService(borrowRecordRepositty, bookRepositty, new LogActionRepositry(context));
            this.Old = oldForm;
        }

        private void MemberMainF_Load(object sender, EventArgs e)
        {
            dgv_availableBooks_MF.DataSource = BookService.GetAvailableBooks();

        }

        private void dgv_availableBooks_MF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_availableBooks_MF.SelectedRows.Count > 0)
            {
                BookID = (int)dgv_availableBooks_MF.SelectedRows[0].Cells[0].Value;
                txt_title_MF.Text = dgv_availableBooks_MF.SelectedRows[0].Cells["Title"].Value.ToString();
                txt_author_MF.Text = dgv_availableBooks_MF.SelectedRows[0].Cells["Author"].Value.ToString();
                txt_category_MF.Text = dgv_availableBooks_MF.SelectedRows[0].Cells["Category"].Value.ToString();
                txt_year_MF.Text = dgv_availableBooks_MF.SelectedRows[0].Cells["PublishedYear"].Value.ToString();
                txt_dueDate_MF.Text = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd");
            }
            else
            {
                MessageBox.Show("Please select a row first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void brn_borrow_MF_Click(object sender, EventArgs e)
        {
            if (BookID == 0)
            {
                MessageBox.Show("Please select a book first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //try
            //{
                BorrowRecordService.AddBorrowRecord(BookID, MemberID);
                MessageBox.Show("Book borrowed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_availableBooks_MF.DataSource = BookService.GetAvailableBooks();
                ClearFields();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "You Alrady Borrowed this or You Borrowd more than 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void btn_memberRecords_MF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MemberBorrowedBooksF(MemberID, this).ShowDialog();
        }

        private void btn_back_MF_Click(object sender, EventArgs e)
        {
            this.Close();
            Old.Show();
        }

        private void ClearFields()
        {
            txt_title_MF.Text = txt_author_MF.Text = txt_category_MF.Text = txt_year_MF.Text = txt_dueDate_MF.Text = "";
        }

        private void btn_clear_MF_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}

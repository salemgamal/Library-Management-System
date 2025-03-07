using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.BusinessLogic.Services;
using Library.DataAccess.Models;
using Library.DataAccess.Repositories;
using Library.DataAccess.Repositry;

namespace Library.Presentation.Forms.MemberForms
{
    public partial class MemberBorrowedBooksF : Form
    {
        public int MemberID;
        public int BookID;
        public BookService BookService;
        public BorrowRecordService BorrowRecordService;
        Form Old;
        public MemberBorrowedBooksF(int MemberId, Form oldForm)
        {
            InitializeComponent();
            this.MemberID = MemberId;
            var context = new LibraryDbContext();
            var bookRepositty = new BookRepository(context);
            var borrowRecordRepositty = new BorrowRecordRepository(context);
            var logActionRepositry = new LogActionRepositry(context);
            BookService = new BookService(bookRepositty);
            BorrowRecordService = new BorrowRecordService(borrowRecordRepositty, bookRepositty, new LogActionRepositry(context));
            this.Old = oldForm;
        }

        private void MemberBorrowedBooks_Load(object sender, EventArgs e)
        {
            dgv_borrowedBooks_MBF.DataSource = BorrowRecordService.GetMemberBorrowedBooks(MemberID);
        }
        private void dgv_borrowedBooks_MBF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BookID = (int)dgv_borrowedBooks_MBF.SelectedRows[0].Cells[1].Value;
            //get book title
            var title = BookService.GetBookById(BookID).Title;
            txt_title_MBF.Text = title;
            var dueDate = (DateTime)dgv_borrowedBooks_MBF.SelectedRows[0].Cells[4].Value;
            int days = (dueDate - DateTime.Now).Days;
            txt_dueDate_MBF.Text = $"{days} days";
        }

        private void btn_back_MBF_Click(object sender, EventArgs e)
        {
            this.Close();
            Old.Show();
        }

        private void btn_return_MBF_Click(object sender, EventArgs e)
        {
            if (BookID == 0)
            {
                MessageBox.Show("Please select a book first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                BorrowRecordService.ReturnBook(MemberID, BookID);
                MessageBox.Show("Book Returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_borrowedBooks_MBF.DataSource = BorrowRecordService.GetMemberBorrowedBooks(MemberID);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearFields()
        {
            txt_title_MBF.Text = "";
            txt_dueDate_MBF.Text = "";
        }
        private NotificationF notificationForm = null;
        private void btn_notification_MBF_Click(object sender, EventArgs e)
        {
            if(notificationForm == null)
            {
                ShowNotification(MemberID);
            }
            else
            {
                HideNotificationFrom();
            }
        }

        private void ShowNotification(int memberId)
        {
            panel1.Controls.Clear();

            notificationForm = new NotificationF(memberId)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panel1.Controls.Add(notificationForm);
            notificationForm.Show();
        }

        private void HideNotificationFrom()
        {
            if (notificationForm != null)
            {
                panel1.Controls.Remove(notificationForm);
                notificationForm.Dispose();
                notificationForm = null;
            }
        }
    }
}

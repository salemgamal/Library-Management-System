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
    public partial class NotificationF : Form
    {
        public int MemberID;
        public BookService BookService;
        public BorrowRecordService BorrowRecordService;
        //private static NotificationF notificationf;
        public NotificationF(int MemberId)
        {
            InitializeComponent();
            this.MemberID = MemberId;
            var context = new LibraryDbContext();
            var bookRepositty = new BookRepository(context);
            var borrowRecordRepositty = new BorrowRecordRepository(context);
            var logActionRepositry = new LogActionRepositry(context);
            BookService = new BookService(bookRepositty);
            BorrowRecordService = new BorrowRecordService(borrowRecordRepositty, bookRepositty, new LogActionRepositry(context));
            
        }

        //public static void Visible(int MemberID)
        //{
        //    if (notificationf == null)
        //    {
        //        notificationf = new NotificationF(MemberID);
        //        notificationf.Show();
        //    }
        //    else
        //    {
        //        notificationf.Close();
        //        notificationf = null;
        //    }
        //}
        public void SetNotificationData(List<Notification> notifications)
        {
            if (dgv_notificationF_MBF != null) // Ensure the DataGridView exists
            {
                dgv_notificationF_MBF.DataSource = notifications;
            }
        }

        private void NotificationF_Load(object sender, EventArgs e)
        {
            var notificationBooks = BorrowRecordService.GetMemberBorrowedBooks(MemberID)
                .Where(b => b.DueDate < DateTime.Now.Date).Select(b =>
                new{
                     Message = $"Book '{b.Book.Title}' is overdue! Due date was {b.DueDate:yyyy-MM-dd}"
                    }).ToList();

            dgv_notificationF_MBF.DataSource = notificationBooks;
        }
    }
}

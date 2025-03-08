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
    public partial class BorrowReturn : Form
    {
        LibraryDbContext context;
        BookRepository bookRepo;
        BorrowRecordRepository borrowRecordRepo;
        BorrowRecordService borrowRecordService;
        LogActionRepositry logActionRepo;
        public BorrowReturn(HomeLibrarian home)
        {
            InitializeComponent();

            context = new LibraryDbContext();
            bookRepo = new BookRepository(context);
            borrowRecordRepo = new BorrowRecordRepository(context);
            logActionRepo = new LogActionRepositry(context);
            borrowRecordService = new BorrowRecordService(borrowRecordRepo, bookRepo, logActionRepo);

            cmbBox_categories_BR.Items.AddRange(new string[]
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

        private void btn_search_BR_Click(object sender, EventArgs e)
        {
            string searchKey = (txt_search_BR.Text?.Trim() ?? string.Empty) + " " +
                   (cmbBox_categories_BR.SelectedItem?.ToString() ?? string.Empty);


            if (tabControl.SelectedIndex == 0)
            {
                var borrBookSearched = borrowRecordService.SearchBorrowedBook(searchKey);
                if (borrBookSearched != dgv_borrowed_BR.DataSource)
                    dgv_borrowed_BR.DataSource = borrBookSearched;
            }
            else if (tabControl.SelectedIndex == 1)
            {
                var overDueSearched = borrowRecordService.SearchOverDueBook(searchKey);
                if (overDueSearched != dgv_overDue_MB.DataSource)
                    dgv_overDue_MB.DataSource = overDueSearched;
            }
        }

        private void btn_generateReport_Click(object sender, EventArgs e)
        {

        }
    }
}

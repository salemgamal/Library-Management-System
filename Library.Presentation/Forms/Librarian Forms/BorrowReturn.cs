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
        Form preForm;
        public BorrowReturn(Form preF)
        {
            InitializeComponent();

            context = new LibraryDbContext();
            bookRepo = new BookRepository(context);
            borrowRecordRepo = new BorrowRecordRepository(context);
            logActionRepo = new LogActionRepositry(context);
            borrowRecordService = new BorrowRecordService(borrowRecordRepo, bookRepo, logActionRepo);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = " ";
            preForm = preF;
            //         cmbBox_categories_BR.Items.AddRange(new string[]
            //{
            //     "Fiction",
            //     "Non-Fiction",
            //     "Science",
            //     "History",
            //     "Biography",
            //     "Technology",
            //     "Philosophy",
            //     "Children",
            //     "Self-Help",
            //     "Fantasy",
            //     "Politics"
            //});
        }

        private void btn_search_BR_Click(object sender, EventArgs e)
        {
            string searchKey = txt_search_BR.Text?.Trim() ?? string.Empty;

            DateTime? date = dateTimePicker.CustomFormat == " " ? (DateTime?)null : dateTimePicker.Value;


            if (tabControl.SelectedIndex == 0)
            {
                dgv_borrowed_BR.DataSource = borrowRecordService.SearchBorrowedBook(searchKey, date);
            }
            else if (tabControl.SelectedIndex == 1)
            {
                dgv_overDue_MB.DataSource = borrowRecordService.SearchOverDueBook(searchKey, date);
            }
            else if (tabControl.SelectedIndex == 2)
            {
                dgv_logActions_MB.DataSource = borrowRecordService.searchLogActions(searchKey, date);
            }
        }

        private void btn_generateReport_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "yyyy-MM-dd";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search_BR.Clear();
            dateTimePicker.CustomFormat = " ";

            btn_search_BR.PerformClick();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();

            if (preForm != null && !preForm.IsDisposed)
            {
                preForm.Show();
            }
            else
            {
                // Optional: Handle the case where preForm is disposed
                MessageBox.Show("The previous page is no longer available.");
            }
        }
    }
}

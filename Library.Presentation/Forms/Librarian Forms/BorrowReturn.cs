using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Library.BusinessLogic.Services;
using Library.DataAccess.Models;
using Library.DataAccess.Repositories;
using Library.DataAccess.Repositry;
using DevExpress.XtraReports.UI;

namespace Library.Presentation.Forms.Librarian_Forms
{
    public partial class BorrowReturn : Form
    {
        LibraryDbContext context;
        BookRepository bookRepo;
        BookService bookService;
        BorrowRecordRepository borrowRecordRepo;
        BorrowRecordService borrowRecordService;
        LogActionRepositry logActionRepo;
        Form preForm;
        public BorrowReturn(Form preF)
        {
            InitializeComponent();

            context = new LibraryDbContext();
            bookRepo = new BookRepository(context);
            bookService = new BookService(bookRepo);
            borrowRecordRepo = new BorrowRecordRepository(context);
            logActionRepo = new LogActionRepositry(context);
            borrowRecordService = new BorrowRecordService(borrowRecordRepo, bookRepo, logActionRepo);

            preForm = preF;

        }

        private void btn_search_BR_Click(object sender, EventArgs e)
        {
            string searchKey = txt_search_BR.Text?.Trim() ?? string.Empty;


            if (tabControl.SelectedIndex == 0)
            {
                dgv_borrowed_BR.DataSource = borrowRecordService.SearchBorrowedBook(searchKey);
                dgv_borrowed_BR.Columns["Book"].Visible = false;
                dgv_borrowed_BR.Columns["Member"].Visible = false;

            }
            else if (tabControl.SelectedIndex == 1)
            {
                dgv_availbleBooks.DataSource = bookService.SearchAvailBook(searchKey);
            }
            else if (tabControl.SelectedIndex == 2)
            {
                dgv_overDue_MB.DataSource = borrowRecordService.SearchOverDueBook(searchKey);
                dgv_overDue_MB.Columns["Book"].Visible = false;
                dgv_overDue_MB.Columns["Member"].Visible = false;

            }
            else if (tabControl.SelectedIndex == 3)
            {
                dgv_logActions_MB.DataSource = borrowRecordService.searchLogActions(searchKey);
                dgv_logActions_MB.Columns["Book"].Visible = false;
                dgv_logActions_MB.Columns["Member"].Visible = false;


            }
        }

        private void btn_generateReport_Click(object sender, EventArgs e)
        {

            ReportPrintTool printTool;
            if (tabControl.SelectedIndex == 0)
            {
                BorrowdBooksReport report = new BorrowdBooksReport();
                printTool = new ReportPrintTool(report);
                printTool.ShowPreview();
            }
            else if (tabControl.SelectedIndex == 1)
            {
                AvailBooksReport report = new AvailBooksReport();
                printTool = new ReportPrintTool(report);
                printTool.ShowPreview();
            }
            else if (tabControl.SelectedIndex == 2)
            {
                OverdueBooksReport report = new OverdueBooksReport();
                printTool = new ReportPrintTool(report);
                printTool.ShowPreview();
            }
            else if (tabControl.SelectedIndex == 3)
            {
                LogActionsReport report = new LogActionsReport();
                printTool = new ReportPrintTool(report);
                printTool.ShowPreview();
            }


        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search_BR.Clear();


            btn_search_BR.PerformClick();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            preForm.Show();
        }

        private void BorrowReturn_Load(object sender, EventArgs e)
        {
            btn_clear.PerformClick();
            btn_search_BR.PerformClick();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

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
using QRCoder;
using System.Drawing;
using System.Globalization;
using ZXing;
using ZXing.QrCode;
using ZXing.Common;
using ZXing.Rendering;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using IronBarCode;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;
using DevExpress.XtraReports.Templates;
namespace Library.Presentation.Forms.MemberForms
{
    public partial class MemberBorrowedBooksF : Form
    {
        public int MemberID;
        public int BookID;
        public BookService BookService;
        public BorrowRecordService BorrowRecordService;
        Form Old;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
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

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboDevice.Items.Add(filterInfo.Name);
            }
            cboDevice.SelectedIndex = 0;
        }
        private void dgv_borrowedBooks_MBF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgv_borrowedBooks_MBF.SelectedRows.Count > 0)
                {
                    BookID = (int)dgv_borrowedBooks_MBF.SelectedRows[0].Cells[1].Value;
                    var title = BookService.GetBookById(BookID).Title;
                    txt_title_MBF.Text = title;
                    var dueDate = (DateTime)dgv_borrowedBooks_MBF.SelectedRows[0].Cells[4].Value;
                    int days = (dueDate - DateTime.Now).Days;
                    txt_dueDate_MBF.Text = $"{days} days";

                    string qrCodeData = $"📚 Book Details:\n\n🆔 BookID: {BookID}\n📖 Title: {title}\n";
                    Bitmap qrCodeImage = GenerateQRCode(qrCodeData);
                    ShowQRInPanel(qrCodeImage);
                }
                else
                {
                    MessageBox.Show("Please select a book first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowQRInPanel(Bitmap qrCodeImage)
        {
            panel_QR_MF.Controls.Clear();

            PictureBox pictureBoxQR = new PictureBox
            {
                Image = qrCodeImage,
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill
            };
            panel_QR_MF.Controls.Add(pictureBoxQR);
        }
        private Bitmap GenerateQRCode(string data)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
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

            if (dgv_borrowedBooks_MBF.SelectedRows.Count > 0)
            {
                dgv_borrowedBooks_MBF.ClearSelection();
                dgv_borrowedBooks_MBF.CurrentCell = null;
            }
            panel_QR_MF.Controls.Clear();
            BookID = 0;
            btn_return_MBF.Enabled = false;
            pictureBox1.Image = null;
            txtQRCode.Text = string.Empty;
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                videoCaptureDevice = null;
            }
        }
        private NotificationF notificationForm = null;
        private void btn_notification_MBF_Click(object sender, EventArgs e)
        {
            if (notificationForm == null)
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += CaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }
        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                pictureBox1.Image = (Bitmap)pictureBox1.Image.Clone(); // Save the frame
                ReadQRCode(); // Process the captured image
            }
            else
            {
                MessageBox.Show("Camera is not running. Start the camera first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ReadQRCode()
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    var results = IronBarCode.BarcodeReader.Read((Bitmap)pictureBox1.Image);

                    if (results != null)
                    {
                        txtQRCode.Text = results.First().Text;
                        videoCaptureDevice.SignalToStop();
                    }
                    else
                    {
                        txtQRCode.Text = "No QR code detected.";
                    }
                }
            }
            catch (Exception ex)
            {
                txtQRCode.Text = $"Error reading QR code: {ex.Message}";
            }
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void btnCapture_Click_1(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                pictureBox1.Image = (Bitmap)pictureBox1.Image.Clone(); // Save the frame
                ReadQRCode(); // Process the captured image
            }
            else
            {
                MessageBox.Show("Camera is not running. Start the camera first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_scan_MF_Click(object sender, EventArgs e)
        {
            try
            {

                // Extract the BookID from the decoded QR code data
                int bookId = ExtractBookIdFromQRCodeData(txtQRCode.Text);

                if (bookId > 0)
                {
                    // Borrow the book if a valid BookID is found
                    ReturnBook(MemberID, bookId);
                }
                else
                {
                    MessageBox.Show("Invalid QR Code: No valid BookID found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the process
                MessageBox.Show($"Error scanning QR code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ExtractBookIdFromQRCodeData(string qrCodeData)
        {
            if (string.IsNullOrEmpty(qrCodeData))
            {
                return 0;
            }

            string[] lines = qrCodeData.Split('\n');
            foreach (string line in lines)
            {
                if (line.StartsWith("🆔 BookID:"))
                {
                    string bookIdStr = line.Replace("🆔 BookID:", "").Trim();
                    if (int.TryParse(bookIdStr, out int bookId))
                    {
                        return bookId;
                    }
                }
            }
            return 0;
        }

        private void ReturnBook(int MemberID, int BookID)
        {
            try
            {
                BorrowRecordService.ReturnBook(MemberID, BookID);
                MessageBox.Show("Book Returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView
                dgv_borrowedBooks_MBF.DataSource = BorrowRecordService.GetMemberBorrowedBooks(MemberID);

                // Clear fields and reset UI
                ClearFields();
                panel_QR_MF.Controls.Clear();
                BookID = 0;
                btn_return_MBF.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

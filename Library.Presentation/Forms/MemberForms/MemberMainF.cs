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


namespace Library.Presentation.Forms.MemberForms
{
    public partial class MemberMainF : Form
    {
        public BookService BookService;
        public BorrowRecordService BorrowRecordService;
        public int MemberID;
        public int BookID;
        Form Old;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
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

        //FilterInfoCollection filterInfoCollection;
        //VideoCaptureDevice captureDevice;

        private void MemberMainF_Load(object sender, EventArgs e)
        {
            dgv_availableBooks_MF.DataSource = BookService.GetAvailableBooks();
            brn_borrow_MF.Enabled = false;

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboDevice.Items.Add(filterInfo.Name);
            }
            cboDevice.SelectedIndex = 0;

        }
        private void btnStart_Click_1(object sender, EventArgs e)
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
                        videoCaptureDevice.SignalToStop(); // Stop the camera after successful scan
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
        

        private void dgv_availableBooks_MF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_availableBooks_MF.SelectedRows.Count > 0)
            {
                brn_borrow_MF.Enabled = true;
                BookID = (int)dgv_availableBooks_MF.SelectedRows[0].Cells[0].Value;
                txt_title_MF.Text = dgv_availableBooks_MF.SelectedRows[0].Cells["Title"].Value.ToString();
                txt_author_MF.Text = dgv_availableBooks_MF.SelectedRows[0].Cells["Author"].Value.ToString();
                txt_category_MF.Text = dgv_availableBooks_MF.SelectedRows[0].Cells["Category"].Value.ToString();
                txt_year_MF.Text = dgv_availableBooks_MF.SelectedRows[0].Cells["PublishedYear"].Value.ToString();
                txt_dueDate_MF.Text = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd");

                //for QR message
                string title = dgv_availableBooks_MF.SelectedRows[0].Cells["Title"].Value.ToString();
                string author = dgv_availableBooks_MF.SelectedRows[0].Cells["Author"].Value.ToString();
                string isbn = dgv_availableBooks_MF.SelectedRows[0].Cells["ISBN"].Value.ToString();
                string year = dgv_availableBooks_MF.SelectedRows[0].Cells["PublishedYear"].Value.ToString();

                string qrCodeData = $"📚 Book Details:\n\n" +
                    $"🆔 BookID: {BookID}\n" +
                    $"📖 Title: {title}\n" +
                    $"✍️ Author: {author}\n" +
                    $"🔖 ISBN: {isbn}\n" +
                    $"📅 Published in: {year}";

                Bitmap qrCodeImage = GenerateQRCode(qrCodeData);
                ShowQRInPanel(qrCodeImage);
            }
            else
            {
                MessageBox.Show("Please select a row first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //show QR in panel
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


        private void brn_borrow_MF_Click(object sender, EventArgs e)
        {
            if (BookID == 0)
            {
                MessageBox.Show("Please select a book first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                BorrowRecordService.AddBorrowRecord(BookID, MemberID);
                MessageBox.Show("Book borrowed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_availableBooks_MF.DataSource = BookService.GetAvailableBooks();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "You Alrady Borrowed this or You Borrowd more than 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            if (dgv_availableBooks_MF.SelectedRows.Count > 0)
            {
                dgv_availableBooks_MF.ClearSelection();
                dgv_availableBooks_MF.CurrentCell = null;
            }
            panel_QR_MF.Controls.Clear();
            BookID = 0;
            brn_borrow_MF.Enabled = false;
            pictureBox1.Image = null;
            txtQRCode.Text = string.Empty;
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                videoCaptureDevice = null;
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
                    BorrowBook(bookId);
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

        //}

        //public byte[] BitmapToByteArray(Bitmap bitmap)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // or another format
        //        return ms.ToArray();
        //    }
        //}

        //private string DecodeQRCode(Bitmap qrCodeImage)
        //{
        //    try
        //    {
        //        BarcodeReader reader = new BarcodeReader();

        //        byte[] byteArray = BitmapToByteArray(qrCodeImage);

        //        //ImageConverter converter = new ImageConverter();
        //        //byte[] bytes = (byte[])converter.ConvertTo(qrCodeImage, typeof(byte[]));

        //        var luminanceSource = new RGBLuminanceSource(byteArray, qrCodeImage.Width, qrCodeImage.Height);

        //        //ImageConverter converter = new ImageConverter();
        //        //byte[] bytes = (byte[])converter.ConvertTo(qrCodeImage, typeof(byte[]));
        //        // Decode directly from Bitmap
        //        Result result = reader.Decode(luminanceSource);

        //        if (result != null)
        //        {
        //            return result.Text;
        //        }
        //        else
        //        {
        //            throw new Exception("QR code could not be decoded.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error decoding QR Code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return string.Empty;
        //    }
        //}


        private int ExtractBookIdFromQRCodeData(string qrCodeData)
        {
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

        private void BorrowBook(int bookId)
        {
            try
            {
                BorrowRecordService.AddBorrowRecord(bookId, MemberID);
                MessageBox.Show("Book borrowed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView
                dgv_availableBooks_MF.DataSource = BookService.GetAvailableBooks();

                // Clear fields and reset UI
                ClearFields();
                panel_QR_MF.Controls.Clear();
                BookID = 0;
                brn_borrow_MF.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

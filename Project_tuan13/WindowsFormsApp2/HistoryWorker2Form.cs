using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HistoryWorker2Form : Form
    {
        private string workerID;
        private string userID;
        private string cv;
        public string WorkerID { get => workerID; set => workerID = value; }
        public string UserID { get => userID; set => userID = value; }
        public string Cv { get => cv; set => cv = value; }

        private List<Image> selectedImages = new List<Image>();
        public HistoryWorker2Form()
        {
            InitializeComponent();
        }

        public HistoryWorker2Form(string userID, string workerID, string congviec)
        {
            UserID = userID;
            WorkerID = workerID;
            Cv = congviec;
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoryWorker2Form_Load(object sender, EventArgs e)
        {
            //Load data worker
            Worker worker = UserDAO.History_Worker(workerID, userID);
            lbl_name.Text = "Họ tên: " + worker.Hoten;
            lbl_thanhtoan.Text = "Đã thanh toán: " + worker.Cv.Thanhtoan;
            lbl_date.Text = "Ngày làm việc: " + (worker.Cv.NgayLamViec.ToString("dd/MM/yyyy"));
            rating.Value = worker.Cv.Rate;
            txb_danhgia.Text = worker.Cv.DanhGia;
            lbl_congviec.Text = "Công việc: " + cv;
        }

        private void btn_danhgia_Click(object sender, EventArgs e)
        {
            UserDAO.Danhgia_Worker((int)rating.Value, txb_danhgia.Text, workerID, userID);          
            //them vao anh danh gia    
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            string queryString = "Insert Into ImgDanhGia Values(@userid, @workerid, @congviec, @image)";
            //string queryString = string.Format("Insert into ImgDanhGia Values('{0}','{1}','{2}',{3})",userID,workerID,cv, imageByteArray);
            conn.Open();
            foreach (Image image in selectedImages)
            {
                try
                {
                    byte[] imageByteArray = ImageToByteArray(image);
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Parameters.AddWithValue("@userid", userID);
                    cmd.Parameters.AddWithValue("@workerid", workerID);
                    cmd.Parameters.AddWithValue("@congviec", cv);
                    cmd.Parameters.AddWithValue("@image", imageByteArray);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Them anh thanh cong");

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            conn.Close();
            if (cbtn_yeuThich.Checked)
            {
                UserDAO.DanhDau_ThoYT(userID, workerID);
            }
            HistoryWorker2Form_Load(sender, e);
        }
        // chuyen anh sang byte[]
        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Chuyển hình ảnh vào MemoryStream
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Trả về mảng byte
                return ms.ToArray();
            }
        }

        // thêm ảnh đánh giá
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true; // Allow multiple file selection
            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"; // Filter for image formats

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog1.FileNames)
                {
                    try
                    {
                        Image image = Image.FromFile(fileName);
                        selectedImages.Add(image);
                        
                        // Create a PictureBox for each image
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = image;
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image size as needed
                        pictureBox.Cursor = Cursors.Hand; // Set cursor to indicate interaction
                        pictureBox.Click += pictureZoom_Click;

                        // Add close icon (optional) and event handler (explained later)
                        AddCloseIcon(pictureBox);

                        // Add PictureBox to FlowLayoutPanel
                        flContainer.Controls.Add(pictureBox);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }
        private void AddCloseIcon(PictureBox pictureBox)
        {
            // Create a close icon PictureBox
            PictureBox closeIcon = new PictureBox();
            closeIcon.Image = Properties.Resources.close; // Assuming your close icon image resource is named "close_icon"
            closeIcon.Size = new Size(20, 20); // Adjust size as needed
            closeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            closeIcon.Cursor = Cursors.Hand; // Set cursor to indicate interaction
            closeIcon.Click += pictureBox_Click; // Attach click event handler for deletion

            // Position the close icon on top-right corner (adjust as needed)
            closeIcon.Location = new Point(pictureBox.Width - closeIcon.Width, 0);

            // Add the close icon as the first child of the PictureBox
            pictureBox.Controls.Add(closeIcon);
        }
        private void DeletePreviewImage(PictureBox pictureBox)
        {
            // Remove image from selectedImages list
            selectedImages.Remove(pictureBox.Image);

            // Remove PictureBox from FlowLayoutPanel
            flContainer.Controls.Remove(pictureBox);

            // Dispose of the image object (optional)
            pictureBox.Image?.Dispose();
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender; // Cast sender to PictureBox (the close icon)

            if (pictureBox.Parent is PictureBox imagePictureBox) // Check if parent is a PictureBox
            {
                // Remove image from selectedImages list and FlowLayoutPanel
                DeletePreviewImage(imagePictureBox);
            }
        }
        private void pictureZoom_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            // Check if close icon is clicked (optional, skip zooming if close icon)

            // Create a new Form for zooming
            Form zoomForm = new Form();
            zoomForm.Height = 400;
            zoomForm.Width = 600;
            //zoomForm.WindowState = FormWindowState.Maximized; // Maximize zoom form
            zoomForm.StartPosition = FormStartPosition.CenterScreen;
            zoomForm.Name = "Image";
            // Create a larger PictureBox for zoomed image
            PictureBox zoomedPictureBox = new PictureBox();
            zoomedPictureBox.Image = pictureBox.Image; // Assign image from clicked PictureBox
            zoomedPictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Adjust size as needed
            zoomedPictureBox.Dock = DockStyle.Fill; // Fill the entire zoom form

            // Add zoomedPictureBox to the zoomForm
            zoomForm.Controls.Add(zoomedPictureBox);

            // Show the zoom form
            zoomForm.Show();
        }

        private void cbtn_yeuThich_CheckedChanged(object sender, EventArgs e)
        {
            //
        }
    }
}

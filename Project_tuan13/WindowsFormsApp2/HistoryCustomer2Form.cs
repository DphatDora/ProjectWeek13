using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HistoryCustomer2Form : Form
    {
        private string userID;
        private string workerID;
        private string cv;
        public string UserID { get => userID; set => userID = value; }
        public string WorkerID { get => workerID; set => workerID = value; }
        public string Cv { get => cv; set => cv = value; }

        public HistoryCustomer2Form()
        {
            InitializeComponent();
        }
        public HistoryCustomer2Form(string userID, string workerID, string cv)
        {
            UserID = userID;
            WorkerID = workerID;
            Cv = cv;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoryCustomer2Form_Load(object sender, EventArgs e)
        {
            User user = WorkerDAO.History_User(userID, workerID, cv);
            lbl_name.Text = "Họ tên: " + user.Hoten;
            lbl_thanhtoan.Text = "Đã thanh toán: " + user.Congviec.Thanhtoan;
            lbl_date.Text = "Ngày làm việc: " + (user.Congviec.NgayLamViec.ToString("dd/MM/yyyy"));
            rating.Value = user.Congviec.Rate;
            txb_danhgia.Text = user.Congviec.DanhGia;
            lbl_congviec.Text = "Công việc: " + cv;
            //Load ảnh đánh giá của khách
            List<PictureBox> commentImage = WorkerDAO.CommentImage(userID, workerID, cv);
            foreach(PictureBox pictureBox in commentImage)
            {
                panelPicture.Controls.Add(pictureBox);
            }
        }
    }
}

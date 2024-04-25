using Guna.UI2.WinForms;
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
    public partial class UCNotifica : UserControl
    {
        private string workerID;
        public Label Hoten
        {
            get => lbl_hoten; set => lbl_hoten = value;
        }
        public Label SDT
        {
            get => lbl_phone; set => lbl_phone = value;
        }
        public Label DiaChi
        {
            get => lbl_diachi; set => lbl_diachi = value;
        }
        public Label NgayLamViec
        {
            get => lbl_ngaylamviec; set => lbl_ngaylamviec = value;
        }
        public Label GhiChu
        {
            get => lbl_ghichu; set => lbl_ghichu = value;
        }
        public Label CongViec
        {
            get => lbl_congviec; set => lbl_congviec = value;
        }
        public Label UserID
        {
            get => lbl_userID; set => lbl_userID = value;
        }
        public Guna2PictureBox Ptb_avt
        {
            get => ptb_avt; set => ptb_avt = value;

        }
        public string WorkerID { get => workerID; set => workerID = value; }

        public UCNotifica()
        {
            InitializeComponent();
        }
        private void UCNotifica_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_chapnhan_Click(object sender, EventArgs e)
        {
            WorkerDAO.Accept_Order(UserID.Text, WorkerID);
        }

        private void btn_tuchoi_Click(object sender, EventArgs e)
        {
            WorkerDAO.Denine_Order(UserID.Text, WorkerID);
        }
    }
}

using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UCComment : UserControl
    {
        public UCComment()
        {
            InitializeComponent();
        }
        private string userID;
        private string workerID;
        private string congViec;
        public Label LblName
        {
            get => lbl_name; set => lbl_name = value;
        }
        public Guna2RatingStar Rating
        {
            get => rating; set => rating = value;
        }
        public Guna2TextBox TxbDanhgia
        {
            get => txb_danhgia; set => txb_danhgia = value;
        }
        public Guna2CirclePictureBox Ptb_avt
        {
            get => ptb_avt; set => ptb_avt = value;
        }
        public Label Lbl_Congviec
        {
            get => lbl_Congviec; set => lbl_Congviec = value;
        }
        public Label Lbl_NgayLamViec
        {
            get => lbl_ngaylamviec; set => lbl_ngaylamviec = value;
        }
        public FlowLayoutPanel Panel_Anh
        {
            get => panel_anh; set => panel_anh = value;
        }
        public string UserID { get => userID; set => userID = value; }
        public string WorkerID { get => workerID; set => workerID = value; }
        public string CongViec { get => congViec; set => congViec = value; }
    }
}

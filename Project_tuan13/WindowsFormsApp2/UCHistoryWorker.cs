using Guna.UI2.WinForms;
using ServiceStack;
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
    public partial class UCHistoryWorker : UserControl
    {
        private string workerID;
        private string userID;
        private string cv;
        public Label Lbl_TrangThai
        {
            get => lbl_trangthai; set => lbl_trangthai = value;
        }

        public Label LblName
        {
            get => lbl_name; set => lbl_name = value;
        }
        public Label LblTienThanhtoan
        {
            get => lbl_tienthanhtoan; set => lbl_tienthanhtoan = value;
        }
        public Label LblNgay
        {
            get => lbl_date; set => lbl_date = value;
        }
        public Guna2RatingStar Rating
        {
            get => rating; set => rating= value;
        }
        public Guna2PictureBox Ptb_avt
        {
            get => ptb_avt; set => ptb_avt = value;
        }
        public string WorkerID { get => workerID; set => workerID = value; }
        public string UserID { get => userID; set => userID = value; }
        public string Cv { get => cv; set => cv = value; }

        public UCHistoryWorker()
        {
            InitializeComponent();
        }

        private void UCHistoryWorker_Click(object sender, EventArgs e)
        {
            HistoryWorker2Form form = new HistoryWorker2Form(userID, workerID, cv);
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

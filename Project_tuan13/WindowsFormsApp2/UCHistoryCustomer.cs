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
    public partial class UCHistoryCustomer : UserControl
    {
        private string userID;
        private string workerID;
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
            get => rating; set => rating = value;
        }
        public Guna2PictureBox Ptb_avt
        {
            get => ptb_avt; set => ptb_avt = value;
        }
        public string UserID { get => userID; set => userID = value; }
        public string WorkerID { get => workerID; set => workerID = value; }
        public string Cv { get => cv; set => cv = value; }

        public UCHistoryCustomer()
        {
            InitializeComponent();
        }

        private void UCHistoryCustomer_Load(object sender, EventArgs e)
        {

        }

        private void UCHistoryCustomer_Click(object sender, EventArgs e)
        {
            HistoryCustomer2Form f = new HistoryCustomer2Form(UserID, WorkerID, Cv);
            f.ShowDialog();
        }
    }
}

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
    public partial class UCWork : UserControl
    {
        public UCWork()
        {
            InitializeComponent();
        }
        private string workerID;
        private string congviec;
        public string WorkerID { get => workerID; set => workerID = value; }
        public string Congviec { get => congviec; set => congviec = value; }

        private void UCWork_Load(object sender, EventArgs e)
        {
            CongViecTho cv = WorkerDAO.Chitiet_Congviec(workerID, congviec);
            txb_congviec.Text = cv.CongViec;
            txb_chitiet.Text = cv.ChiTietCV;
            txb_day.Text = cv.TgLamViecDay;
            txb_kinhnghiem.Text = cv.KinhNghiem;
            txb_tiencong.Text = cv.TienCong;
            txb_week.Text = cv.TgLamViecWeek;

        }
    }
}

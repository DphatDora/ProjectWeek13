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
using System.Windows.Forms;
using static ServiceStack.Script.Lisp;

namespace WindowsFormsApp2
{
    public partial class InfoWorkerForm : Form
    {
        private string workerID;
        private string cv;
        public string WorkerID { get => workerID; set => workerID = value; }
        public string Cv { get => cv; set => cv = value; }

        public InfoWorkerForm()
        {
            InitializeComponent();
            panelPage2.Hide();
            
        }

        //btn_datlich
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm f = new OrderForm();
            f.WorkerID = this.WorkerID;
            f.CongViec = this.Cv;
            f.GiaTien.Text = txb_tiencong.Text;
            f.ShowDialog();
            f = null;
            this.Show();
            
        }
        //btn_huy
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageForm f = new MessageForm();
            f.ShowDialog();
            f = null;
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
        }

        private void InfoWorkerForm_Load(object sender, EventArgs e)
        {
            Worker worker = UserDAO.Load_ChiTiet_Worker(workerID, cv);
            
            txb_name.Text = worker.Hoten;
            txb_phone.Text = worker.Sdt;
            txb_kinhnghiem.Text = worker.Congviec.KinhNghiem;
            txb_tiencong.Text = worker.Congviec.TienCong;
            txb_tgTrongTuan.Text = worker.Congviec.TgLamViecWeek;
            txb_tgTrongNgay.Text = worker.Congviec.TgLamViecDay;
            txb_chiTiet.Text = worker.Congviec.ChiTietCV;
            rating.Value = worker.Rate;
            if (worker.Avatar == null)
            {
                //
            }
            else
            {
                MemoryStream ms = new MemoryStream(worker.Avatar);
                ptb_avt.Image = Image.FromStream(ms);
            }

            //load comment
            List<UCComment> comments = UserDAO.Load_Comment(workerID);
            foreach (UCComment uc in comments)
            {
                flContainer.Controls.Add(uc);
            }
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            panelPage2.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelPage2.Hide();
        }
    }
}

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
    public partial class HistoryWorkerForm : Form
    {
        public string role;
        public static string userID;
        public static string workerID;
        public HistoryWorkerForm(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HistoryWorkerForm_Load(object sender, EventArgs e)
        {
            if (role == "Worker")
            {
                cb_thoYT.Visible = false;
                List<UCHistoryCustomer> userList = WorkerDAO.Load_User(workerID);
                foreach (UCHistoryCustomer uc in userList)
                {
                    flContainer.Controls.Add(uc);
                }
            }
            else
            {

                List<UCHistoryWorker> workerList = UserDAO.Load_Worker(userID);
                foreach (UCHistoryWorker uc in workerList)
                {
                    flContainer.Controls.Add(uc);
                }
            }
        }
        //tim kiem theo ten 
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (role == "Worker")
            {
                flContainer.Controls.Clear();
                List<UCHistoryCustomer> userList = WorkerDAO.Timkiem_Ten(workerID, txb_timkiem.Text);
                foreach (UCHistoryCustomer uc in userList)
                {
                    flContainer.Controls.Add(uc);
                }
            }
            else
            {
                flContainer.Controls.Clear();
                List<UCHistoryWorker> workerList = UserDAO.Timkiem_Ten(userID, txb_timkiem.Text);
                foreach (UCHistoryWorker uc in workerList)
                {
                    flContainer.Controls.Add(uc);
                }
            }
        }
        //tim kiem theo ngay
        private void guna2Button11_Click(object sender, EventArgs e)
        {
            if (role == "Worker")
            {
                flContainer.Controls.Clear();
                List<UCHistoryCustomer> userList = WorkerDAO.Timkiem_Ngay(workerID, start_day.Value, end_day.Value);
                foreach (UCHistoryCustomer uc in userList)
                {
                    flContainer.Controls.Add(uc);
                }
            }
            else
            {
                flContainer.Controls.Clear();
                List<UCHistoryWorker> workerList = UserDAO.Timkiem_Ngay(userID, start_day.Value, end_day.Value);
                foreach (UCHistoryWorker uc in workerList)
                {
                    flContainer.Controls.Add(uc);
                }
            }
        }

        private void cb_thoYT_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_thoYT.Checked)
            {
                flContainer.Controls.Clear();
                List<UCWorkerYT> workerList = UserDAO.Load_ThoYT(userID);
                foreach (UCWorkerYT uc in workerList)
                {
                    flContainer.Controls.Add(uc);
                }
            }
            else
            {
                flContainer.Controls.Clear();
                HistoryWorkerForm_Load(sender, e);
            }
        }
        private void LocTheoTrangThai(string state)
        {
            if (role == "Worker")
            {
                flContainer.Controls.Clear();
                List<UCHistoryCustomer> userList = WorkerDAO.DaHoanThanh(workerID, state);
                foreach (UCHistoryCustomer uc in userList)
                {
                    flContainer.Controls.Add(uc);
                }
            }
            else
            {
                flContainer.Controls.Clear();
                List<UCHistoryWorker> workerList = UserDAO.DaHoanThanh(userID, state);
                foreach (UCHistoryWorker uc in workerList)
                {
                    flContainer.Controls.Add(uc);
                }
            }
        }
        private void btn_daHoanThanh_Click(object sender, EventArgs e)
        {
            string state = "Da hoan thanh";
            LocTheoTrangThai(state);
        }

        private void btn_danglam_Click(object sender, EventArgs e)
        {
            string state = "Da nhan";
            LocTheoTrangThai(state);
        }
    }
}

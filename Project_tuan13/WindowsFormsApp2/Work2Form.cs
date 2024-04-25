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
    public partial class Work2Form : Form
    {
        public static string workerID;
        public Work2Form()
        {
            InitializeComponent();
        }

        private void Work2Form_Load(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            panelWork.Show();
            panelAdd.Hide();
            List<UCWork> listWork = WorkerDAO.Danhsach_Congviec(workerID);
            foreach (UCWork work in listWork)
            {
                flContainer.Controls.Add(work);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Show();
            panelWork.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //panelAdd.Hide();
            //panelWork.Show();
            Work2Form_Load(sender, e);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            WorkerDAO.Dangviec(workerID, CongViecBox.Text, KinhNghiemBox.Text + " " + kn_num.Text, tienCongBox.Text, day_start.Text + " den " + day_end.Text, hour_start.Text + " den " + hour_end.Text, chitiet_txb.Text, tc_num.Text);
            
        }
    }
}

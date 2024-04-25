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
    public partial class WorkForm : Form
    {
        public static string workerID;
        public WorkForm()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //btn_Save -- Dang viec
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WorkerDAO.Dangviec(workerID, CongViecBox.Text, KinhNghiemBox.Text + " " + kn_num.Text, tienCongBox.Text, day_start.Text + " den " + day_end.Text, hour_start.Text + " den " + hour_end.Text, chitiet_txb.Text, tc_num.Text);     
        }

        
        private void WorkForm_Load(object sender, EventArgs e)
        {
            List<UCWork> listWork = WorkerDAO.Danhsach_Congviec(workerID);
            foreach (UCWork work in listWork)
            {
                flowLayoutPanel1.Controls.Add(work);
            }
        }
    }
}

using ServiceStack;
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
    public partial class OrderWorker2Form : Form
    {
        private int day;
        public int Day { get => day; set => day = value; }
        public OrderWorker2Form()
        {
            InitializeComponent();
        }

        private void OrderWorker2Form_Load(object sender, EventArgs e)
        {
            DateTime date = new DateTime(OrderWorkerForm.static_year, OrderWorkerForm.static_month, day);
            lblday.Text = date.Date.ToString("dd/MM/yyyy");
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string queryString = string.Format("Select HoTen, SDT, MaCongViec, DiaChiCongViec, GhiChu " +
                                                    "From CongViec inner join UserInfoDB on CongViec.UserID=UserInfoDB.UserID " +
                                                    "Where WorkerID = '{0}' and NgayLamViec = '{1}' and TrangThai='Da nhan'", WorkerForm.workerID, date.Date);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbl_name.Text = "Họ tên khách hàng: " + reader[0].ToString();
                    lbl_phone.Text = "Số điện thoại: " + reader[1].ToString();
                    lbl_congviec.Text = "Công việc: " + reader[2].ToString();
                    lbl_diachi.Text = "Địa chỉ làm việc: " + reader[3].ToString();
                    lbl_ghichu.Text = "Ghi chú: " + reader[4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

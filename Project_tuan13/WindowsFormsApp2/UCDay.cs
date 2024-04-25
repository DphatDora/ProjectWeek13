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
    public partial class UCDay : UserControl
    {
        public UCDay()
        {
            InitializeComponent();
        }
        public void days(int numday)
        {
            lblday.Text = numday + "";
        }
        
        private void UCDay_Load(object sender, EventArgs e)
        {
            DateTime date = new DateTime(OrderWorkerForm.static_year, OrderWorkerForm.static_month, int.Parse(lblday.Text));
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string queryString = string.Format("Select HoTen " +
                                                    "From UserInfoDB inner join CongViec on UserInfoDB.UserID=CongViec.UserID " +
                                                    "Where WorkerID = '{0}' and NgayLamViec = '{1}' and TrangThai='Da nhan'", WorkerForm.workerID, date.Date);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbl_sukien.Text = "Khách hàng:" + reader[0].ToString();
                    this.BackColor = Color.GreenYellow;
                }    
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void UCDay_Click(object sender, EventArgs e)
        {
            
            OrderWorker2Form f = new OrderWorker2Form();
            f.Day = int.Parse(lblday.Text);
            f.ShowDialog();  
        }
    }
}

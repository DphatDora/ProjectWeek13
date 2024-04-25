using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using System.Data.SqlTypes;
using System.IO;
using Org.BouncyCastle.Math.EC.Multiplier;
using System.Web;

namespace WindowsFormsApp2
{   
    public class WorkerDAO
    {
        ppConnection huy= new ppConnection();
        // tạo worker mới
        public static void New_Worker(Worker worker,string password)
        {
            string sqlStr = string.Format("INSERT INTO WorkerInfoDB VALUES ('{0}','{1}', '', '1/1/2000', '{2}', '{3}', '{4}', '', '', 0, null)", worker.Id, worker.Hoten, worker.Sdt, worker.Email, password);
            ppConnection.ThucThi(sqlStr);
        }
        // Edit thông tin
        public static void Edit_Info(Worker worker) 
        {
            string sqlStr = string.Format("Update WorkerInfoDB Set HoTen='{0}', DiaChi='{1}', NgaySinh='{2}', SDT='{3}', Email='{4}', GioiTinh='{5}', CCCD='{6}' Where WorkerID='{7}'", worker.Hoten, worker.Diachi, worker.Ngaysinh, worker.Sdt, worker.Email, worker.Gioitinh, worker.Cccd, worker.Id);
        }
        //tim kiem theo ten user
        public static List<UCHistoryCustomer> Timkiem_Ten(string workerID, string username)
        {
            string queryStr = string.Format("Select UserInfoDB.UserID, NgayLamViec, TrangThai, ThanhToan, CongViec.Rate, HoTen, Avatar " +
                                                "From CongViec inner join UserInfoDB on CongViec.UserID=UserInfoDB.UserID " +
                                                "Where CongViec.WorkerID='{0}' and TrangThai!='Cho nhan' and HoTen Like '%{1}%'", workerID, username);
            return ppConnection.load_Tim_kiem_KhachHang(queryStr, workerID);
        }

        // Tìm kiếm theo ngày làm việc
        public static List<UCHistoryCustomer> Timkiem_Ngay(string workerID, DateTime startDay, DateTime endDay)
        {
            string queryStr = string.Format("Select UserInfoDB.UserID, NgayLamViec, TrangThai, ThanhToan, CongViec.Rate, HoTen, Avatar " +
                                                "From CongViec inner join UserInfoDB on CongViec.UserID=UserInfoDB.UserID " +
                                                "Where CongViec.WorkerID='{0}' and TrangThai!='Cho nhan' and NgayLamViec Between '{1}' and '{2}'", workerID, startDay.Date, endDay.Date);

            return ppConnection.load_Tim_kiem_KhachHang(queryStr, workerID);
        }
        //Lọc theo trạng thái công việc
        public static List<UCHistoryCustomer> DaHoanThanh(string workerID, string trangThai)
        {
            string queryStr = string.Format("Select UserInfoDB.UserID, NgayLamViec, TrangThai, ThanhToan, CongViec.Rate, HoTen, Avatar " +
                                                "From CongViec inner join UserInfoDB on CongViec.UserID=UserInfoDB.UserID " +
                                                "Where CongViec.WorkerID='{0}' and TrangThai='{1}'", workerID, trangThai);
            return ppConnection.load_Tim_kiem_KhachHang(queryStr, workerID);
        }
        // Chap nhap yeu cau dat lich
        public static void Accept_Order(string userID, string workerID)
        {
            string queryString = string.Format("Update CongViec Set TrangThai='Da nhan' Where UserID='{0}' and WorkerID='{1}'", userID, workerID);
            ppConnection.ThucThi(queryString);
        }
        //Tu choi yeu cau dat lich
        public static void Denine_Order(string userID, string workerID)
        {
            string queryString = string.Format("Update CongViec Set TrangThai='Da huy' Where UserID='{0}' and WorkerID='{1}'", userID, workerID);
            ppConnection.ThucThi(queryString);
        }

        //Đăng việc
        public static void Dangviec(string workerID, string congviec, string kinhnghiem, string tiencong, string ngaylamviec, string giolamviec, string chitiet, string donViTien)
        {
            string queryString = string.Format("Insert Into CongViecThoDB Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}')",
                                     workerID, congviec, kinhnghiem, tiencong, ngaylamviec, giolamviec, chitiet, donViTien);
            ppConnection.ThucThi(queryString);
        }
        // Load danh sách user
        public static List<UCHistoryCustomer> Load_User(string workerID)
        {
            string queryStr = string.Format("Select UserInfoDB.UserID, NgayLamViec, TrangThai, ThanhToan, CongViec.Rate, HoTen, Avatar, MaCongViec " +
                                                "From CongViec inner join UserInfoDB on CongViec.UserID=UserInfoDB.UserID " +
                                                "Where CongViec.WorkerID='{0}' and TrangThai!='Cho nhan'", workerID);
            List<UCHistoryCustomer> userList = new List<UCHistoryCustomer>();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(queryStr, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UCHistoryCustomer uc = new UCHistoryCustomer();
                    uc.WorkerID = workerID;
                    uc.UserID = reader.GetString(0);
                    uc.Cv = reader[7].ToString();
                    uc.LblName.Text = "Họ tên: " + reader.GetString(5);
                    uc.Rating.Value = reader.GetInt32(4);
                    uc.LblTienThanhtoan.Text = "Đã thanh toán: " + reader.GetString(3);
                    uc.LblNgay.Text = "Ngày làm việc: " + (reader.GetDateTime(1)).ToString("dd/MM/yyyy");
                    uc.Lbl_TrangThai.Text = "Trạng thái: " + reader[2].ToString();
                    
                    if (reader.IsDBNull(6))
                    {
                        //
                    }
                    else
                    {
                        object value = reader[6];
                        byte[] avt = (byte[])value;
                        MemoryStream ms = new MemoryStream(avt);
                        uc.Ptb_avt.Image = Image.FromStream(ms);
                    }
                    userList.Add(uc);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return userList;
        }
        // check dang nhap
        public static bool check_Login(string sdt, string password)
        {
            string sqlStr = string.Format("SELECT COUNT(*) FROM WorkerInfoDB WHERE SDT='{0}' AND Password='{1}'", sdt, password);
            return ppConnection.check_Login(sqlStr);
        }
        //Load thông tin worker
        public static Worker Load_info_Worker(string workerID)
        {
            Worker worker = new Worker();
            string queryString = string.Format("Select * From WorkerInfoDB Where WorkerID = '{0}'", workerID);
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        worker.Hoten = reader.GetString(1);
                        worker.Diachi = reader.GetString(2);
                        worker.Ngaysinh = reader.GetDateTime(3);
                        worker.Sdt = reader.GetString(4);
                        worker.Email = reader.GetString(5);
                        worker.Gioitinh = reader.GetString(7);
                        worker.Cccd = reader.GetString(8);
                        if (reader.IsDBNull(10))
                        {
                            //
                        }
                        else
                        {
                            object value = reader[10];
                            worker.Avatar = (byte[])value;
                        }
                    }
                    else
                    {
                        MessageBox.Show(workerID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
                
            }
            return worker;
        }
        //Load lich su danh sach khach hang
        
        public static User History_User(string userID, string workerID, string cv)
        {
            User user = new User();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string queryString = string.Format("Select UserInfoDB.UserID, HoTen, ThanhToan, NgayLamViec, CongViec.Rate, DanhGia, MaCongViec" +
                                                " From UserInfoDB, CongViec" +
                                                " Where UserInfoDB.UserID=CongViec.UserID and UserInfoDB.UserID='{0}' and CongViec.WorkerID='{1}' and MaCongViec='{2}'", userID, workerID, cv);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user.Hoten = reader.GetString(1);
                    user.Congviec.Thanhtoan = reader.GetString(2);
                    user.Congviec.NgayLamViec = reader.GetDateTime(3);
                    user.Congviec.Rate = reader.GetInt32(4);
                    user.Congviec.DanhGia = reader.GetString(5);
                    user.Congviec.MaCongViec = reader.GetString(6);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return user;
        }
        // hien thông báo
        public static List<UCNotifica> Load_ThongBao(string workerID)
        {
            List<UCNotifica> uCNotificas = new List<UCNotifica>();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string queryString = string.Format("Select HoTen, DiaChi, SDT, MaCongViec, NgayLamViec, GhiChu, CongViec.UserID, CongViec.WorkerID, Avatar " +
                                                   "From CongViec inner join UserInfoDB on CongViec.UserID=UserInfoDB.UserID " +
                                                   "Where CongViec.WorkerID='{0}' and CongViec.TrangThai='Cho nhan'", workerID);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UCNotifica uc = new UCNotifica();
                    uc.Hoten.Text = "Họ tên: " + reader[0].ToString();
                    uc.SDT.Text = "Số điện thoại: " + reader[2].ToString();
                    uc.DiaChi.Text = "Địa chỉ: " + reader[1].ToString();
                    uc.CongViec.Text = "Công việc: " + reader[3].ToString();
                    uc.NgayLamViec.Text = "Ngày làm việc: " + reader[4].ToString();
                    uc.GhiChu.Text = "Ghi chú: " + reader[5].ToString();
                    uc.UserID.Text = reader[6].ToString();
                    uc.WorkerID = reader[7].ToString();
                    if (reader.IsDBNull(8))
                    {
                        //
                    }
                    else
                    {
                        object value = reader[8];
                        byte[] avt = (byte[])value;
                        MemoryStream ms = new MemoryStream(avt);
                        uc.Ptb_avt.Image = Image.FromStream(ms);
                    }
                    uCNotificas.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
            return uCNotificas;
        }

       

        // Load chi tiet cong viec
        public static CongViecTho Chitiet_Congviec(string workerID, string congviec)
        {
            CongViecTho cv = new CongViecTho();
            string queryString = string.Format("Select * From CongViecThoDB Where WorkerID = '{0}' and CongViec = '{1}'", workerID, congviec);
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cv.CongViec = reader[1].ToString();
                    cv.KinhNghiem = reader[2].ToString();
                    cv.TienCong = reader[3].ToString();
                    cv.TgLamViecWeek = reader[4].ToString();
                    cv.TgLamViecDay = reader[5].ToString();
                    cv.ChiTietCV = reader[6].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
            return cv;
        }
        // Load danh sach chi tiet cong viec
        public static List<UCWork> Danhsach_Congviec(string workerID)
        {
            List < UCWork > listWork = new List<UCWork> ();
            string queryString = string.Format("Select * From CongViecThoDB Where WorkerID = '{0}'", workerID);
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UCWork cv = new UCWork();
                    cv.WorkerID = reader[0].ToString();
                    cv.Congviec = reader[1].ToString();
                    listWork.Add(cv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
            return listWork;
        }
        //Luu anh
        public static void Save_Anh(string workerID, byte[] imageData)
        {
            string queryString = string.Format("Update WorkerInfoDB Set Avatar = @avatar Where WorkerID = @workerid");
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string sqlStr = queryString;
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@workerid", workerID);
                cmd.Parameters.AddWithValue("@avatar", imageData);

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        
     

        //Load ảnh đánh giá của khách trong Form HistoryCustomer2
        public static List<PictureBox> CommentImage(string userID, string workerID, string cv)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            string queryStr = string.Format("Select * From ImgDanhGia Where UserID = '{0}' and WorkerID = '{1}' and MaCongViec = '{2}'", userID, workerID, cv);
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(queryStr, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    PictureBox picturebox = new PictureBox();
                    picturebox.SizeMode = PictureBoxSizeMode.Zoom;
                    picturebox.Click += ppConnection.ZoomImage;
                    if (reader.IsDBNull(3))
                    {
                        //
                    }
                    else
                    {
                        object value = reader[3];
                        byte[] avt = (byte[])value;
                        MemoryStream ms = new MemoryStream(avt);
                        picturebox.Image = Image.FromStream(ms);
                    }
                    pictureBoxes.Add(picturebox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return pictureBoxes;
        }
    }
}

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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public class UserDAO
    {
        ppConnection pp = new ppConnection();

        // tạo user mới
        public static void New_User(User user,string password)
        {
            string sqlStr = string.Format("INSERT INTO UserInfoDB VALUES ('{0}','{1}', '', '1/1/2000', '{2}', '{3}', '{4}', '', '', 5, null)", user.Id, user.Hoten, user.Sdt, user.Email, password);
            ppConnection.ThucThi(sqlStr);
        }
        // Edit thông tin
        public static void Edit_Info(User user)
        {
            string sqlStr = string.Format("Update UserInfoDB Set HoTen='{0}', DiaChi='{1}', NgaySinh='{2}', SDT='{3}', Email='{4}', GioiTinh='{5}', CCCD='{6}' Where UserID='{7}'", user.Hoten, user.Diachi, user.Ngaysinh, user.Sdt, user.Email, user.Gioitinh, user.Cccd, user.Id);
            ppConnection.ThucThi(sqlStr);
        }
        //Load thông tin user
        public static User Load_info_User(string userID)
        {
            User user = new User();
            string queryString = string.Format("Select * From UserInfoDB Where UserID = '{0}'", userID);
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        user.Hoten = reader.GetString(1);
                        user.Diachi = reader.GetString(2);
                        user.Ngaysinh = reader.GetDateTime(3);
                        user.Sdt = reader.GetString(4);
                        user.Email = reader.GetString(5);
                        user.Gioitinh = reader.GetString(7);
                        user.Cccd = reader.GetString(8);
                        if (reader.IsDBNull(10))
                        {
                            //
                        }
                        else
                        {
                            object value = reader[10];
                            user.Avatar = (byte[])value;
                        }
                            
                    }
                    else
                    {
                        MessageBox.Show("KHong read dc" + userID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
                
            }
            return user;
        }
        //Load lich su danh sách thợ
        public static List<UCHistoryWorker> Load_Worker(string userID)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, NgayLamViec, TrangThai, ThanhToan, CongViec.Rate, HoTen, Avatar, MaCongViec " +
                                                "From CongViec inner join WorkerInfoDB on CongViec.WorkerID=WorkerInfoDB.WorkerID " +
                                                "Where UserID='{0}' and TrangThai!='Cho nhan'", userID);
            return ppConnection.load_Tim_Kiem_Tho(queryStr, userID);
        }
        public static int Rating(string ID)
        {
            int rate=0;
            string query = string.Format("SELECT AVG(Rate) FROM CongViec WHERE WorkerID = '{0}' group by WorkerID ", ID);
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                rate = Convert.ToInt32(reader.GetInt32(0)); // Chuyển đổi từ kiểu decimal sang int
                            }
                            else
                            {
                                // Xử lý trường hợp NULL nếu cần
                            }
                        }
                        else
                        {
                            // Xử lý trường hợp không tìm thấy bản ghi nếu cần
                        }
                    }
                }
            }
            return rate;

        }

        //Load danh sách công việc thợ
        public static List<UCWorker> Load_CongViecTho(string tho)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, WorkerInfoDB.HoTen, WorkerInfoDB.SDT, CongViecThoDB.KinhNghiem, CongViecThoDB.TienCong, WorkerInfoDB.Rate, Avatar" +
                              " From WorkerInfoDB, CongViecThoDB" +
                              " Where WorkerInfoDB.WorkerID = CongViecThoDB.WorkerID and CongViecThoDB.CongViec = '{0}'", tho);
            List<UCWorker> workerList = new List<UCWorker>();
            try
            {
                SqlConnection cnn = new SqlConnection(Properties.Settings.Default.connStr);
                cnn.Open();
                SqlCommand sqlCommand = new SqlCommand(queryStr, cnn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UCWorker uc = new UCWorker();
                    uc.Cv = tho;
                    uc.WorkerID = reader.GetString(0);
                    uc.LblName.Text = "Họ tên: " + reader.GetString(1);
                    uc.LblPhone.Text = "Số điện thoại: " + reader.GetString(2);
                    uc.LblKinhnghiem.Text = "Kinh nghiệm: " + reader.GetString(3);
                    uc.LblTiencong.Text = "Tiền công: " + reader.GetString(4);
                    uc.Rating.Value = reader.GetInt32(5);
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
                    workerList.Add(uc);
                }
                reader.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return workerList;
        }
        // tìm kiếm thợ theo tên
        public static List<UCWorker> tim_kiem_Tho(string tho,string tentho)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, WorkerInfoDB.HoTen, WorkerInfoDB.SDT, CongViecThoDB.KinhNghiem, CongViecThoDB.TienCong, WorkerInfoDB.Rate, Avatar" +
                              " From WorkerInfoDB, CongViecThoDB" +
                              " Where WorkerInfoDB.WorkerID = CongViecThoDB.WorkerID and CongViecThoDB.CongViec = '{0}' and HoTen Like '%{1}%'", tho, tentho);
            List<UCWorker> workerList = new List<UCWorker>();
            try
            {
                SqlConnection cnn = new SqlConnection(Properties.Settings.Default.connStr);
                cnn.Open();
                SqlCommand sqlCommand = new SqlCommand(queryStr, cnn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UCWorker uc = new UCWorker();
                    uc.WorkerID = reader.GetString(0);
                    uc.LblName.Text = "Họ tên: " + reader.GetString(1);
                    uc.LblPhone.Text = "Số điện thoại: " + reader.GetString(2);
                    uc.LblKinhnghiem.Text = "Kinh nghiệm: " + reader.GetString(3);
                    uc.LblTiencong.Text = "Tiền công: " + reader.GetString(4);
                    uc.Rating.Value = reader.GetInt32(5);
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
                    workerList.Add(uc);
                }
                reader.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return workerList;
        }
        public static List<UCWorker> TimKiem_Star(string tho, int star)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, WorkerInfoDB.HoTen, WorkerInfoDB.SDT, CongViecThoDB.KinhNghiem, CongViecThoDB.TienCong, WorkerInfoDB.Rate, Avatar" +
                              " From WorkerInfoDB, CongViecThoDB" +
                              " Where WorkerInfoDB.WorkerID = CongViecThoDB.WorkerID and CongViecThoDB.CongViec = '{0}' and WorkerInfoDB.Rate = {1}", tho, star);
            List<UCWorker> workerList = new List<UCWorker>();
            try
            {
                SqlConnection cnn = new SqlConnection(Properties.Settings.Default.connStr);
                cnn.Open();
                SqlCommand sqlCommand = new SqlCommand(queryStr, cnn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UCWorker uc = new UCWorker();
                    uc.WorkerID = reader.GetString(0);
                    uc.LblName.Text = "Họ tên: " + reader.GetString(1);
                    uc.LblPhone.Text = "Số điện thoại: " + reader.GetString(2);
                    uc.LblKinhnghiem.Text = "Kinh nghiệm: " + reader.GetString(3);
                    uc.LblTiencong.Text = "Tiền công: " + reader.GetString(4);
                    uc.Rating.Value = reader.GetInt32(5);
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
                    workerList.Add(uc);
                }
                reader.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return workerList;
        }
        public static void SapXep_Gia(List<UCWorker> workersList)
        {
            workersList.Sort((x, y) => {
                // Chuyển đổi giá tiền công từ chuỗi sang số
                int tiengcongX = int.Parse(x.LblTiencong.Text.Split(':')[1].Trim());
                int tiengcongY = int.Parse(y.LblTiencong.Text.Split(':')[1].Trim());
                // So sánh giá tiền công của hai đối tượng
                return tiengcongX.CompareTo(tiengcongY);
            });
        }
        // check dang nhap
        public static bool check_Login(string sdt, string password)
        {
            string sqlStr = string.Format("SELECT COUNT(*) FROM UserInfoDB WHERE SDT='{0}' AND Password='{1}'", sdt, password);
            return ppConnection.check_Login(sqlStr);
        }
        //Load thong tin chi tiet tho
        public static Worker Load_ChiTiet_Worker(string workerID, string congviec)
        {
            Worker worker = new Worker();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string queryString = string.Format("Select CongViecThoDB.WorkerID, KinhNghiem, TienCong, TgLamViecWeek, TgLamViecDay, ChiTietCV, HoTen, SDT, CongViec, WorkerInfoDB.Rate, Avatar" +
                                                   " From CongViecThoDB, WorkerInfoDB" +
                                                   " Where CongViecThoDB.WorkerID=WorkerInfoDB.WorkerID and CongViecThoDB.WorkerID='{0}' and CongViecThoDB.CongViec='{1}'", workerID, congviec);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    
                    worker.Hoten = reader[6].ToString();
                    worker.Sdt = reader[7].ToString();
                    worker.Congviec.KinhNghiem = reader[1].ToString();
                    worker.Congviec.TienCong = reader[2].ToString();
                    worker.Congviec.TgLamViecWeek = reader[3].ToString();
                    worker.Congviec.TgLamViecDay = reader[4].ToString();
                    worker.Congviec.ChiTietCV = reader[5].ToString();
                    worker.Rate = reader.GetInt32(9);
                    worker.Congviec.CongViec = reader[8].ToString();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return worker;
        }
        //load comment danh gia tho
        public static List<UCComment> Load_Comment(string workerID)
        {
            List<UCComment> comments = new List<UCComment>();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string queryString = string.Format("Select CongViec.UserID, CongViec.Rate, DanhGia, HoTen, Avatar, CongViec.MaCongViec, CongViec.NgayLamViec, CongViec.WorkerID" +
                                                " From CongViec inner join UserInfoDB on CongViec.UserID = UserInfoDB.UserID" +
                                                " Where CongViec.WorkerID='{0}'", workerID);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UCComment uc = new UCComment();
                    uc.UserID = reader[0].ToString();
                    uc.WorkerID = reader[7].ToString();
                    uc.CongViec = reader[5].ToString();
                    uc.LblName.Text = reader[3].ToString();
                    uc.Rating.Value = reader.GetInt32(1);
                    uc.TxbDanhgia.Text = reader[2].ToString();
                    uc.Lbl_Congviec.Text = "Công việc: " + reader[5].ToString();
                    uc.Lbl_NgayLamViec.Text = "Ngày làm việc: " + reader.GetDateTime(6).ToString("dd/MM/yyyy");
                    if (reader.IsDBNull(4))
                    {
                        //
                    }
                    else
                    {
                        object value = reader[4];
                        byte[] avt = (byte[])value;
                        MemoryStream ms = new MemoryStream(avt);
                        uc.Ptb_avt.Image = Image.FromStream(ms);
                    }
                    comments.Add(uc);
                }
                reader.Close();
                //load anh danh gia
                foreach (UCComment comment in comments)
                {
                    string queryImg = string.Format("Select * From ImgDanhGia Where UserID='{0}' and WorkerID='{1}' and MaCongViec='{2}'", comment.UserID, comment.WorkerID, comment.CongViec);
                    List<PictureBox> listImg = new List<PictureBox>();
                    SqlCommand cmd2 = new SqlCommand(queryImg, conn);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        PictureBox pictureBox = new PictureBox();
                        MemoryStream ms = new MemoryStream((byte[])reader2[3]);
                        pictureBox.Image = Image.FromStream(ms);
                        listImg.Add(pictureBox);
                    }
                    reader2.Close();
                    foreach (PictureBox img in listImg)
                    {
                        comment.Panel_Anh.Controls.Add(img);
                    }
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
            return comments;
        }
        //load lich su tho
        public static Worker History_Worker(string workerID, string userID)
        {
            Worker worker = new Worker();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string queryString = string.Format("Select WorkerInfoDB.WorkerID, HoTen, ThanhToan, NgayLamViec, CongViec.Rate, DanhGia From WorkerInfoDB, CongViec Where WorkerinfoDB.WorkerID=CongViec.WorkerID and WorkerInfoDB.WorkerID='{0}' and CongViec.UserID='{1}'", workerID, userID);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    worker.Hoten = reader[1].ToString();
                    worker.Cv.Thanhtoan = reader[2].ToString();
                    worker.Cv.NgayLamViec = reader.GetDateTime(3);
                    worker.Cv.Rate = reader.GetInt32(4);
                    worker.Cv.DanhGia = reader[5].ToString();
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
            return worker;
        }
        //Danh gia tho
        public static void Danhgia_Worker(int rate, string danhgia, string workerID, string userID)
        {
            int thanhtoan = ThanhToan_Worker(workerID, userID);
            string queryString = string.Format("Update CongViec Set Rate='{0}', DanhGia='{1}', TrangThai = 'Da hoan thanh', ThanhToan = '{4}' "+
                                                    " Where WorkerID='{2}' and UserID = '{3}'", rate, danhgia, workerID, userID,thanhtoan);
            ppConnection.ThucThi(queryString);
            Average_Rate(workerID);

        }

        //Order tho
        public static void Order_Worker(string userID, string congviec, DateTime ngaylamviec, string giolamviec, string ghichi, string workerID, string diachi, string giatien)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

            try
            {
                conn.Open();
                string queryString = string.Format("Insert Into CongViec Values('{0}', '{1}', '{2}', '{3}', '{4}','Cho nhan', 0, 0, '{5}', ' ', '{6}', '{7}')",
                                                    userID, congviec, ngaylamviec.Date, giolamviec, ghichi, workerID, diachi, giatien);
                SqlCommand cmd = new SqlCommand(queryString, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageForm f = new MessageForm();
                    f.ShowDialog(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + UserForm.UserID);
            }
            finally { conn.Close(); }
        }
        // luu anh
        public static void Save_Anh(string userID, byte[] imageData)
        {
            //string queryString = string.Format("DECLARE @varbinaryData VARBINARY(MAX) = CONVERT(VARBINARY(MAX), '{0}')\nUPDATE UserInfoDB SET Avatar = @varbinaryData Where UserID = '{1}'", imageData, userID);
            string queryString = string.Format("Update UserInfoDB Set Avatar = @avatar Where UserID = @userid");
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string sqlStr = queryString;
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@userid", userID);
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

        //Tim kiem theo so sao
        
        // tìm kiếm theo tên thợ trong form lịch sử
        public static List<UCHistoryWorker> Timkiem_Ten(string userID, string tentho)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, NgayLamViec, TrangThai, ThanhToan, CongViec.Rate, HoTen, Avatar, MaCongViec " +
                                                "From CongViec inner join WorkerInfoDB on CongViec.WorkerID=WorkerInfoDB.WorkerID " +
                                                "Where CongViec.UserID='{0}' and TrangThai!='Cho nhan' and HoTen Like '%{1}%'", userID, tentho);

            return ppConnection.load_Tim_Kiem_Tho(queryStr, userID);
        }

        // Tìm kiếm theo ngày làm việc trong form lịch sử
        public static List<UCHistoryWorker> Timkiem_Ngay(string userID, DateTime startDay, DateTime endDay)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, NgayLamViec, TrangThai, ThanhToan, CongViec.Rate, HoTen, Avatar, MaCongViec " +
                                                "From CongViec inner join WorkerInfoDB on CongViec.WorkerID=WorkerInfoDB.WorkerID " +
                                                "Where CongViec.UserID='{0}' and TrangThai!='Cho nhan' and NgayLamViec Between '{1}' and '{2}'", userID, startDay.Date, endDay.Date);

            return ppConnection.load_Tim_Kiem_Tho(queryStr, userID);
        }

        //Hiển thị thợ yêu thích
        public static List<UCWorkerYT> Load_ThoYT(string userID)
        {
            List <UCWorkerYT> workerList = new List<UCWorkerYT>();
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, HoTen, SDT, Rate, Avatar" +
                                            " From WorkerInfoDB inner join ThoYeuThich on WorkerInfoDB.WorkerID = ThoYeuThich.WorkerID_YT" +
                                            " Where ThoYeuThich.UserID = '{0}'", userID);
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            try
            {

                SqlCommand sqlCommand = new SqlCommand(queryStr, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UCWorkerYT uc = new UCWorkerYT();
                    uc.WorkerID = reader.GetString(0);
                    uc.LblName.Text = "Họ tên: " + reader.GetString(1);
                    uc.LblPhone.Text = "Số điện thoại: " + reader[2].ToString();
                    uc.Rating.Value = reader.GetInt32(3);
                    if (reader.IsDBNull(4))
                    {
                        //
                    }
                    else
                    {
                        object value = reader[4];
                        byte[] avt = (byte[])value;
                        MemoryStream ms = new MemoryStream(avt);
                        uc.PtbAvt.Image = Image.FromStream(ms);
                    }
                    workerList.Add(uc);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); }
            return workerList;
        }

        // Danh dau tho yeu thich
        public static void DanhDau_ThoYT(string userID, string workerID)
        {
            string queryString = string.Format("Insert into ThoYeuThich values('{0}', '{1}')", userID, workerID);
            ppConnection.ThucThi(queryString);
        }

        // Lọc theo trạng thái công việc
        public static List<UCHistoryWorker> DaHoanThanh(string userID, string trangthai)
        {
            string queryStr = string.Format("Select WorkerInfoDB.WorkerID, NgayLamViec, TrangThai, ThanhToan, CongViec.Rate, HoTen, Avatar, MaCongViec " +
                                                "From CongViec inner join WorkerInfoDB on CongViec.WorkerID=WorkerInfoDB.WorkerID " +
                                                "Where CongViec.UserID='{0}' and TrangThai='{1}'", userID, trangthai);
            return ppConnection.load_Tim_Kiem_Tho(queryStr, userID);
        }
        public static int ThanhToan_Worker(string workerID,string  userID)
        {
            int gio=0;
            int tien=0;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string query = string.Format("Select GioLamViec, TienCong from CongViec where UserID='{0}' and WorkerID='{1}'", userID, workerID);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    gio = reader.GetInt32(0);
                    tien = Convert.ToInt32(reader.GetString(1));
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
          
            return  gio * tien;
            
        }

        //tim kiem theo top doanh thu
        public static UCWorker TopDoanhThu_Worker(string congviec)
        {
            string queryString = string.Format("SELECT DISTINCT WorkerInfoDB.WorkerID, WorkerInfoDB.HoTen, WorkerInfoDB.SDT, CongViecThoDB.KinhNghiem, CongViecThoDB.TienCong, WorkerInfoDB.Rate, WorkerInfoDB.Avatar \r\nFROM WorkerInfoDB \r\nINNER JOIN CongViecThoDB ON WorkerInfoDB.WorkerID = CongViecThoDB.WorkerID \r\nWHERE WorkerInfoDB.WorkerID = (\r\n    SELECT TOP 1 WorkerID\r\n    FROM (\r\n        SELECT WorkerID, SUM(CAST(ThanhToan AS INT)) AS ThuNhap \r\n        FROM CongViec \r\n        WHERE MaCongViec = '{0}' \r\n        GROUP BY WorkerID\r\n    ) AS Subquery\r\n    ORDER BY ThuNhap DESC\r\n)", congviec);
            UCWorker uc = new UCWorker();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    uc.WorkerID = reader.GetString(0);
                    uc.LblName.Text = "Họ tên: " + reader.GetString(1);
                    uc.LblPhone.Text = "Số điện thoại: " + reader.GetString(2);
                    uc.LblKinhnghiem.Text = "Kinh nghiệm: " + reader.GetString(3);
                    uc.LblTiencong.Text = "Tiền công: " + reader.GetString(4);
                    uc.Rating.Value = reader.GetInt32(5);
                    if (!reader.IsDBNull(6))
                    {
                        object value = reader[6];
                        byte[] avt = (byte[])value;
                        MemoryStream ms = new MemoryStream(avt);
                        uc.Ptb_avt.Image = Image.FromStream(ms);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return uc;
        }

        //tim kiem top booking
        public static UCWorker TopBooking(string congviec)
        {
            string queryString = string.Format("Select Distinct A.WorkerID, A.HoTen, A.SDT, A.KinhNghiem, A.TienCong, A.Rate, Avatar, Solan\r\nFrom (Select WorkerInfoDB.WorkerID, WorkerInfoDB.HoTen, WorkerInfoDB.SDT, CongViecThoDB.KinhNghiem, CongViecThoDB.TienCong, WorkerInfoDB.Rate, Avatar From WorkerInfoDB inner join CongViecThoDB on WorkerInfoDB.WorkerID = CongViecThoDB.WorkerID Where CongViec = '{0}') as A, (SELECT WorkerID, Count(WorkerID) as SoLan FROM CongViec GROUP BY WorkerID HAVING COUNT(*) = (SELECT MAX(counts) FROM (SELECT COUNT(*) AS counts FROM CongViec GROUP BY WorkerID) AS counts)) as Q\r\nWhere A.WorkerID = Q.WorkerID", congviec);
            UCWorker uc = new UCWorker();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    uc.WorkerID = reader.GetString(0);
                    uc.LblName.Text = "Họ tên: " + reader.GetString(1);
                    uc.LblPhone.Text = "Số điện thoại: " + reader.GetString(2);
                    uc.LblKinhnghiem.Text = "Kinh nghiệm: " + reader.GetString(3);
                    uc.LblTiencong.Text = "Tiền công: " + reader.GetString(4);
                    uc.Rating.Value = reader.GetInt32(5);
                    if (!reader.IsDBNull(6))
                    {
                        object value = reader[6];
                        byte[] avt = (byte[])value;
                        MemoryStream ms = new MemoryStream(avt);
                        uc.Ptb_avt.Image = Image.FromStream(ms);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return uc;
        }

        //Tinh rate trung binh cua tho
        public static void Average_Rate(string workerID)
        {
            int rate = Rating(workerID);
            string queryString = string.Format("Update WorkerInfoDB Set Rate = {0} Where WorkerID = '{1}'",rate, workerID);
            ppConnection.ThucThi(queryString);
        }
    }
}

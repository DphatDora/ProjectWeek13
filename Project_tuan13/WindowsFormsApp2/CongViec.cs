using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class CongViec
    {
        private string userID;
        private string maCongViec;
        private string GioLamViec;
        private DateTime ngayLamViec;
        private string ghiChu;
        private string trangThai;
        private int rate;
        private string workerID;
        private string danhGia;
        private string diaChiCV;
        private string thanhtoan;
        public string UserID { get => userID; set => userID = value; }
        public string MaCongViec { get => maCongViec; set => maCongViec = value; }
        public string GioLamViec1 { get => GioLamViec; set => GioLamViec = value; }
        public DateTime NgayLamViec { get => ngayLamViec; set => ngayLamViec = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public int Rate { get => rate; set => rate = value; }
        public string WorkerID { get => workerID; set => workerID = value; }
        public string DanhGia { get => danhGia; set => danhGia = value; }
        public string DiaChiCV { get => diaChiCV; set => diaChiCV = value; }
        public string Thanhtoan { get => thanhtoan; set => thanhtoan = value; }

        public CongViec()
        {

        }
    }
}

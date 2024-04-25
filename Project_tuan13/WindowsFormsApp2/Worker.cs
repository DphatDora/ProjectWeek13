using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp2
{
    public class Worker
    {
        private string id;
        private string hoten;
        private string diachi;
        private DateTime ngaysinh;
        private string sdt;
        private string email;
        private string gioitinh;
        private string cccd;
        private int rate;
        private byte[] avatar;
        private CongViecTho congviec = new CongViecTho();
        private CongViec cv = new CongViec();

        public string Id { get => id; set => id = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public int Rate { get => rate; set => rate = value; }
        public CongViecTho Congviec { get => congviec; set => congviec = value; }
        public CongViec Cv { get => cv; set => cv = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }

        public Worker()
        {

        }
        public Worker(string id, string hoten, string diachi, DateTime ngaysinh, string sdt, string email, string gioitinh, string cccdcongViecTho)
        {
            Id = id;
            Hoten = hoten;
            Diachi = diachi;
            Ngaysinh = ngaysinh;
            Sdt = sdt;
            Email = email;
            Gioitinh = gioitinh;
            Cccd = cccd;
            Avatar = Avatar;
        }
        public Worker(string id, string hoten, string sdt, string email)
        {
            Id = id;
            Hoten = hoten;
            Sdt = sdt;
            Email = email;
        }
        public Worker(string hoten, string sdt, string kinhnghiem, string tiencong, string weekTime, string dayTime, string chitiet, int rate, string congviec)
        {
            Hoten = hoten;
            Sdt = sdt;
            Congviec.KinhNghiem = kinhnghiem;
            Congviec.TienCong = tiencong;
            Congviec.TgLamViecWeek = weekTime;
            Congviec.TgLamViecDay = dayTime;
            Congviec.ChiTietCV = chitiet;
            Rate = rate;
            Congviec.CongViec = congviec;
        }

    }
}

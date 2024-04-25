using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class User
    {
        private string id;
        private string hoten;
        private string diachi;
        private DateTime ngaysinh;
        private string sdt;
        private string email;
        private string gioitinh;
        private string cccd;
        private byte[] avatar = null;
        private CongViec congviec = new CongViec();
        public string Id { get => id; set => id = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public CongViec Congviec { get => congviec; set => congviec = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }

        public User()
        {

        }
        public User(string id, string hoten, string sdt, string email)
        {
            Id = id;
            Hoten = hoten;
            Sdt = sdt;
            Email = email;
        }
        public User(string id, string hoten, string diachi, DateTime ngaysinh, string sdt, string email, string gioitinh, string cccd)
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
    }
}

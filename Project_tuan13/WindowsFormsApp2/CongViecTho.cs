using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class CongViecTho
    {
        private string congViec;
        private string kinhNghiem;
        private string tienCong;
        private string tgLamViecWeek;
        private string tgLamViecDay;
        private string chiTietCV;

        public string CongViec { get => congViec; set => congViec = value; }
        public string KinhNghiem { get => kinhNghiem; set => kinhNghiem = value; }
        public string TienCong { get => tienCong; set => tienCong = value; }
        public string TgLamViecWeek { get => tgLamViecWeek; set => tgLamViecWeek = value; }
        public string TgLamViecDay { get => tgLamViecDay; set => tgLamViecDay = value; }
        public string ChiTietCV { get => chiTietCV; set => chiTietCV = value; }
        public CongViecTho() { }
        public CongViecTho(string congViec, string kinhNghiem, string tienCong, string tgLamViecWeek, string tgLamViecDay, string chiTietCV)
        {
            CongViec = congViec;
            KinhNghiem = kinhNghiem;
            TienCong = tienCong;
            TgLamViecWeek = tgLamViecWeek;
            TgLamViecDay = tgLamViecDay;
            ChiTietCV = chiTietCV;
        }
    }
}

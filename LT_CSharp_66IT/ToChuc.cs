using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_CSharp_66IT
{
    internal class ToChuc
    {
        string ma_tochuc;//Mã tổ chức
        string ten_tochuc;//Tên tổ chức
        List<NguoiDung> dsnguoidung = new List<NguoiDung>();

        public string Ma_tochuc { get => ma_tochuc; set => ma_tochuc = value; }
        public string Ten_tochuc { get => ten_tochuc; set => ten_tochuc = value; }

        public ToChuc()
        {
            this.ma_tochuc = "VNUF";
            this.ten_tochuc = "Vietnam National University of Forestry";
        }

        public void AddThanhVien(NguoiDung nguoidung)
        {
            this.dsnguoidung.Add(nguoidung);
        }

        public NguoiDung MaxTuoi()
        {
            return this.dsnguoidung.OrderByDescending(nd => nd.Tuoi).FirstOrDefault();
        }

        public NguoiDung MinTuoi()
        {
            return this.dsnguoidung.OrderByDescending(nd => nd.Tuoi).Reverse().FirstOrDefault();
        }

    }
}

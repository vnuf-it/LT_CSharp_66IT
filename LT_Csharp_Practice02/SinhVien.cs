using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_Csharp_Practice02
{
    internal class SinhVien : NguoiDung
    {
        string lop;
        string khoavien;
        string nganhhoc;
        double diemtb;
        double diemrl;


        // Test từ khóa base
        string color = "green";
        public string Color { get => color; set => color = value; }
        
        public string Lop { get => lop; set => lop = value; }
        public string Khoavien { get => khoavien; set => khoavien = value; }
        public string Nganhhoc { get => nganhhoc; set => nganhhoc = value; }
        public double Diemtb { get => diemtb; set => diemtb = value; }
        public double Diemrl { get => diemrl; set => diemrl = value; }

        public SinhVien(string _hodem, string _ten, int _tuoi) : base(_hodem, _ten, _tuoi)
        {
        }

        public SinhVien(string _hodem, string _ten, int _tuoi, string _dienthoai) : base(_hodem, _ten, _tuoi, _dienthoai)
        {
        }

        public SinhVien(string _hodem, string _ten, double _diemtb, double _diemrl): base(_hodem, _ten)
        {
            this.diemtb = _diemtb;
            this.diemrl = _diemrl;
        }

        public override void InThongTinLienHe()
        {
            var thongtin = $"Ho Ten SV: {this.Hodem} {this.Ten} \t\t\t| Tuoi: {base.Tuoi} \t| DT: {base.Dienthoai}";
            Console.WriteLine(thongtin);
        }

        public override string GetThongTin()
        {
            var thongtin = $"Ho va Ten: {this.Hodem} {this.Ten} \t\t\t | DiemTB: {this.Diemtb} | DiemRL: {this.Diemrl}";
            return thongtin;
        }

        public void ShowColor()
        {
            Console.WriteLine(Color);
            Console.WriteLine(base.Color);
        }

        public static bool IsDatHocBong(double _diemtb, double _diemrl)
        {
            if (_diemtb >= 2.5 && _diemrl >= 8.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<SinhVien> GetSvDuocXetHocBong(List<SinhVien> ds_sinhvien)
        {
            List<SinhVien> ds_hocbong = new List<SinhVien>();

            ds_sinhvien.ForEach(s => { if (IsDatHocBong(s.Diemtb, s.Diemrl)) ds_hocbong.Add(s); });

            Console.WriteLine($"Danh sach sinh vien duoc xet hoc bong: \n");
            ds_hocbong.OrderByDescending(i => i.Diemtb) // Sap xep DiemTB cao xuong thap
            .ThenByDescending(i => i.Diemrl)            // Sap xep DiemRL cao xuong thap
            .ToList()
            .ForEach(i => Console.WriteLine(i.GetThongTin()));
            return ds_hocbong;
        }

    }

}

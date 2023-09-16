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

        public SinhVien(string _hodem, string _ten, int _tuoi, double _diemtb, double _diemrl) : base(_hodem, _ten, _tuoi)
        {
            this.diemtb = _diemtb;
            this.diemrl = _diemrl;
        }


        public void ShowColor()
        {
            Console.WriteLine(Color);
            Console.WriteLine(base.Color);
        }

    }

}

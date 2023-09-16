using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_Csharp_Practice02
{
    internal abstract class NguoiDung
    {
        decimal cccd;
        string hodem;
        string ten;
        string bietdanh;
        string email;
        decimal dienthoai;
        int tuoi;



        public decimal Cccd { get => cccd; set => cccd = value; }
        public string Hodem { get => hodem; set => hodem = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Bietdanh { get => bietdanh; set => bietdanh = value; }
        public string Email { get => email; set => email = value; }
        public decimal Dienthoai { get => dienthoai; set => dienthoai = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        // Test từ khóa base
        string color = "red";
        public string Color { get => color; set => color = value; }

        public NguoiDung(string _hodem, string _ten, int _tuoi)
        {
            this.hodem = _hodem;
            this.ten = _ten;
            this.tuoi = _tuoi;
        }

        public virtual void InThongTin()
        {
            var thongtin = $"Ho va Ten: {this.Hodem} {this.Ten} \t\t\t| Tuoi: {this.Tuoi}";
            Console.WriteLine(thongtin);
        }

        public virtual string GetThongTin()
        {
            var thongtin = $"Ho va Ten: {this.Hodem} {this.Ten} \t\t\t| Tuoi: {this.Tuoi}";
            return thongtin;
        }

    }
}

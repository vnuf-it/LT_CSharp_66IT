using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        string dienthoai;
        int tuoi;

        public decimal Cccd { get => cccd; set => cccd = value; }
        public string Hodem { get => hodem; set => hodem = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Bietdanh { get => bietdanh; set => bietdanh = value; }
        public string Email { get => email; set => email = value; }
        public string Dienthoai {
            get => this.dienthoai;
            set 
            {
                string regex_pattern = "(((\\+|)84)|0)(3|5|7|8|9)+([0-9]{8})\b";
                if (Regex.IsMatch(value, regex_pattern))
                {
                    this.dienthoai = value;
                }
                else
                {
                    throw new ArgumentException($"Error - Dien thoai khong dung cu phap");
                }
            }

        }
        public int Tuoi { 
            get => this.tuoi;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Error - Tuoi khong phai so nguyen duong");
                }
                else
                { 
                    this.tuoi = value; 
                }
            }

        }

        // Test từ khóa base
        string color = "red";
        public string Color { get => color; set => color = value; }

        public NguoiDung(string _hodem, string _ten)
        {
            this.Hodem = _hodem;
            this.Ten = _ten;
        }

        public NguoiDung(string _hodem, string _ten, int _tuoi)
        {
            this.Hodem = _hodem;
            this.Ten = _ten;
            this.Tuoi = _tuoi;
        }

        public NguoiDung(string _hodem, string _ten, int _tuoi, string _dienthoai)
        {
            this.Hodem = _hodem;
            this.Ten = _ten;
            this.Tuoi = _tuoi;
            this.Dienthoai = _dienthoai;
        }

        public virtual void InThongTin()
        {
            var thongtin = $"Ho va Ten: {this.Hodem} {this.Ten} \t\t\t| Tuoi: {this.Tuoi}";
            Console.WriteLine(thongtin);
        }

        public virtual void InThongTinLienHe()
        {
            var thongtin = $"Ho Ten: {this.Hodem} {this.Ten} \t\t\t| Tuoi: {this.Tuoi} \t| DT: {this.Dienthoai}";
            Console.WriteLine(thongtin);
        }

        public virtual string GetThongTin()
        {
            var thongtin = $"Ho va Ten: {this.Hodem} {this.Ten} \t\t\t| Tuoi: {this.Tuoi}";
            return thongtin;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_CSharp_66IT
{
    abstract class NguoiDung
    {

        decimal cccd;   //Số CCCD
        string hodem;   //Họ đệm
        string ten;     //Tên
        string nickname;//Biệt danh(nickname)
        string email;   //Email
        decimal phone;  //Điện thoại
        int tuoi;       //Tuổi
        List<TaiKhoanNganHang> dstaikhoan = new List<TaiKhoanNganHang>();

        public decimal Cccd { get => cccd; set => cccd = value; }
        public string Hodem { get => hodem; set => hodem = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Email { get => email; set => email = value; }
        public decimal Phone { get => phone; set => phone = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public void AddTaiKhoanNganHang(TaiKhoanNganHang tk)
        {
            this.dstaikhoan.Add(tk);
        }

        public abstract string GetFullName();
        
        public double GetTongSoDuTaiKhoan()
        {
            return this.dstaikhoan.Sum(taikhoan => taikhoan.Bank_balance);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_CSharp_66IT
{
    /// <summary>
    /// Đối tượng Tài khoản ngân hàng
    /// </summary>
    internal class TaiKhoanNganHang
    {
        //Biến thành viên
        int bank_code;
        decimal bank_account;
        double bank_balance;

        //Thuộc tính
        public int Bank_code { get => bank_code; set => bank_code = value; }
        public decimal Bank_account { get => bank_account; set => bank_account = value; }
        public double Bank_balance { get => bank_balance; set => bank_balance = value; }


        //Phương thức

        /// <summary>
        /// Phương thức khởi tạo
        /// </summary>
        public TaiKhoanNganHang()
        {
            this.bank_code = 0;
            this.bank_account = 00000000;
            this.bank_balance = 0;
        }

        public TaiKhoanNganHang(int _bank_code, decimal _bank_account, double _bank_balance)
        {
            Bank_code = _bank_code;
            Bank_account = _bank_account;
            Bank_balance = _bank_balance;

        }

        public void GuiTien(double sotien)
        {
            Bank_balance += sotien;
        }

        public double RutTien(double sotien)
        {
            return Bank_balance -= sotien;
        }

        public double SoDuKhaDung()
        {
            return Bank_balance -= 50000;
        }
    }
}

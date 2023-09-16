using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_CSharp_66IT
{
    internal class SinhVien : NguoiDung
    {
        decimal msv;

        public decimal Msv { get => msv; set => msv = value; }

        public override string GetFullName()
        {
            return "["+ Msv +"]"+ "" + Hodem + " " + Ten;
        }
    }
}

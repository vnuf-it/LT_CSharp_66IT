﻿namespace Core_WebAPI.Models
{
    public class Student : People
    {
        string msv; // 221070001 (22 năm | 107 mã ngành | 0001 số thứ tự nhập học)
        string lop; // 66A-HTTT, 66B-HTTT
        string khoavien; // Khoa Cơ điện Công trình

        public string Msv { get => msv; set => msv = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Khoavien { get => khoavien; set => khoavien = value; }

        public Student(string _hodem, string _ten) : base(_hodem, _ten)
        {
        }

        public Student(string _msv, string _lop, string _khoavien, string _cccd, string _hodem, string _ten) : base(_cccd, _hodem, _ten)
        {
            this.Msv = _msv;
            this.Lop = _lop;
            this.Khoavien = _khoavien;
        }

        public Student(string _hodem, string _ten, int _tuoi) : base(_hodem, _ten, _tuoi)
        {
        }

        public Student(string _hodem, string _ten, string _dienthoai, string _email) : base(_hodem, _ten, _dienthoai, _email)
        {
        }     

        public override string GetHoVaTen()
        {
            return $"{Hodem} {Ten}";
        }
    }
}

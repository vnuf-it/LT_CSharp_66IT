// See https://aka.ms/new-console-template for more information
using LT_CSharp_66IT;

Console.WriteLine("Hello, World!");

SinhVien hoatx = new SinhVien();
hoatx.Cccd = 0011223344;
hoatx.Hodem = "Tran Xuan";
hoatx.Ten = "Hoa";
hoatx.Tuoi = 33;

TaiKhoanNganHang vietin_1 = new TaiKhoanNganHang();
TaiKhoanNganHang vietco_1 = new TaiKhoanNganHang();
TaiKhoanNganHang bidvbk_1 = new TaiKhoanNganHang();

vietin_1.Bank_balance = 10;
vietco_1.Bank_balance = 20;
bidvbk_1.Bank_balance = 30;

hoatx.AddTaiKhoanNganHang(vietin_1);
hoatx.AddTaiKhoanNganHang(vietco_1);
hoatx.AddTaiKhoanNganHang(bidvbk_1);

SinhVien abcxy = new SinhVien();
abcxy.Cccd = 0011223355;
abcxy.Hodem = "Nguyen Van";
abcxy.Ten = "ABC";
abcxy.Tuoi = 15;

TaiKhoanNganHang vietin_2 = new TaiKhoanNganHang();
TaiKhoanNganHang vietco_2 = new TaiKhoanNganHang();
TaiKhoanNganHang bidvbk_2 = new TaiKhoanNganHang();

vietin_2.Bank_balance = 50;
vietco_2.Bank_balance = 50;
bidvbk_2.Bank_balance = 50;

abcxy.AddTaiKhoanNganHang(vietin_2);
abcxy.AddTaiKhoanNganHang(vietco_2);
abcxy.AddTaiKhoanNganHang(bidvbk_2);

SinhVien abczo = new SinhVien();
abczo.Cccd = 0011223355;
abczo.Hodem = "Nguyen Van";
abczo.Ten = "ABC";
abczo.Tuoi = 60;

TaiKhoanNganHang vietin_3 = new TaiKhoanNganHang();
TaiKhoanNganHang bidvbk_3 = new TaiKhoanNganHang();

vietin_3.Bank_balance = 70;
bidvbk_3.Bank_balance = 50;

abczo.AddTaiKhoanNganHang(vietin_3);
abczo.AddTaiKhoanNganHang(bidvbk_3);

ToChuc tc = new ToChuc();
tc.AddThanhVien(hoatx);
tc.AddThanhVien(abcxy);
tc.AddThanhVien(abczo);

Console.WriteLine("Fullname: " + tc.MaxTuoi().GetFullName() + "\n" 
    + "MaxTuoi: " + tc.MaxTuoi().Tuoi);
Console.WriteLine("Fullname: " + tc.MinTuoi().GetFullName() + "\n" 
    + "MinTuoi: " + tc.MinTuoi().Tuoi);

//List<NguoiDung> ds_nguoidung = new List<NguoiDung>();
//ds_nguoidung.Add(hoatx);
//ds_nguoidung.Add(abcxy);
//ds_nguoidung.Add(abczo);


Console.WriteLine("Fullname: " + hoatx.GetFullName() + "\n"
    + "Tong tien: " + hoatx.GetTongSoDuTaiKhoan());
Console.WriteLine("Fullname: " + abcxy.GetFullName() + "\n"
    + "Tong tien: " + abcxy.GetTongSoDuTaiKhoan());
Console.WriteLine("Fullname: " + abcxy.GetFullName() + "\n"
    + "Tong tien: " + abczo.GetTongSoDuTaiKhoan());

Console.ReadKey();



// See https://aka.ms/new-console-template for more information
using LT_Csharp_Practice02;
using System;


int lines = int.Parse(Console.ReadLine());
List<SinhVien> ds_sinhvien = new List<SinhVien>();

// Demo Data Validation with Regex Phone

for (int i = 0; i < lines; i++)
{
    string[] arr_thongtin = Console.ReadLine().Split(",");

    var str_hodem = arr_thongtin[0].TrimStart().TrimEnd();                 // Ho dem
    var str_ten = arr_thongtin[1].TrimStart().TrimEnd();                   // Ten
    var int_tuoi = int.Parse(arr_thongtin[2].TrimStart().TrimEnd());       // Tuoi
    var str_dienthoai = arr_thongtin[3].TrimStart().TrimEnd();             // Dien thoai

    try
    {
        SinhVien sinhvien = new SinhVien(str_hodem, str_ten, int_tuoi, str_dienthoai);
        ds_sinhvien.Add(sinhvien);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"SV {str_hodem} {str_ten}: {ex.Message.ToString()}");
        Console.WriteLine($"Vui long nhap lai !!!");
    }
    
}



ds_sinhvien.OrderBy(ng => ng.Ten)
    .ThenBy(ng => ng.Tuoi)
    .ToList()
    .ForEach(ng => ng.InThongTinLienHe());
Console.ReadKey();





//// Demo Xet hoc bong
//for (int i = 0; i < lines; i++)
//{
//    string[] arr_thongtin = Console.ReadLine().Split(",");
//    SinhVien sinhvien = new SinhVien(
//        arr_thongtin[0].TrimStart().TrimEnd(), // Ho dem
//        arr_thongtin[1].TrimStart().TrimEnd(), // Ten
//        Convert.ToDouble(arr_thongtin[2].TrimStart().TrimEnd()), // DiemTB
//        Convert.ToDouble(arr_thongtin[3].TrimStart().TrimEnd())  // DiemRL
//        );

//    ds_sinhvien.Add(sinhvien);
//}

//SinhVien.GetSvDuocXetHocBong(ds_sinhvien);
//Console.ReadKey();

//ds_sinhvien.OrderBy(ng => ng.Ten)
//    .ThenBy(ng => ng.Tuoi)
//    .ToList()
//    .ForEach(ng => Console.WriteLine(ng.GetThongTin()));

//CÁC CÁCH ĐỂ LOOP DANH SÁCH ĐỐI TƯỢNG
// Tham khảo: https://www.techiedelight.com/loop-through-a-list-in-csharp/

//// Cách 1:
//for (int i = 0; i < ds_sinhvien.Count(); i++ )
//{
//    Console.WriteLine(ds_sinhvien[i].GetThongTin());
//}

//// Cách 2:
//foreach (var i in ds_sinhvien)
//{
//    Console.WriteLine(i.GetThongTin());
//}

//// Cách 3:
//ds_sinhvien.ForEach(i => Console.WriteLine(i.GetThongTin()));

//// Test từ khóa base
//SinhVien sv = new SinhVien("Nguyen Van", "A", 18);
//sv.ShowColor();

//Console.ReadKey();



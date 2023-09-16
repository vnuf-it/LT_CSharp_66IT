// See https://aka.ms/new-console-template for more information
using LT_Csharp_Practice02;
using System;


int lines = int.Parse(Console.ReadLine());
List<SinhVien> ds_sinhvien = new List<SinhVien>();

for (int i = 0; i < lines; i++)
{
    string[] arr_thongtin = Console.ReadLine().Split(",");
    SinhVien sinhvien = new SinhVien(
        arr_thongtin[0].TrimStart().TrimEnd(), // Ho dem
        arr_thongtin[1].TrimStart().TrimEnd(), // Ten
        int.Parse(arr_thongtin[2].TrimStart().TrimEnd()), // Tuoi
        Convert.ToDouble(arr_thongtin[3].TrimStart().TrimEnd()), // DiemTB
        Convert.ToDouble(arr_thongtin[4].TrimStart().TrimEnd())  // DiemRL
        );

    ds_sinhvien.Add(sinhvien);
}

Core.GetSvDuocXetHocBong(ds_sinhvien);
Console.ReadKey();

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



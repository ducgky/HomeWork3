using ClassLibraryCheckNull.Common;
using System;
using System.Collections.Generic;
using System.Linq;



public class QuanLySinhVien
{
    private List<SinhVien> danhSachSinhVien = new List<SinhVien>();

    public void NhapDanhSachSinhVien()
    {
        for (int i = 0; i < 5; i++)
        {
            string id = CheckInvalidInput.NhapChuoi($"Nhập ID sinh viên {i + 1}: ");
            string ten = CheckInvalidInput.NhapChuoi("Nhập tên: ");
            int tuoi = CheckInvalidInput.NhapSoNguyen("Nhập tuổi: ");
            double diemHK1 = CheckInvalidInput.NhapSoThuc("Nhập điểm HK1: ");
            double diemHK2 = CheckInvalidInput.NhapSoThuc("Nhập điểm HK2: ");

            danhSachSinhVien.Add(new SinhVien { ID = id, Ten = ten, Tuoi = tuoi, DiemHK1 = diemHK1, DiemHK2 = diemHK2 });
        }
    }


    public  void HienThiDanhSach() //Danh Sách Sinh Viên
    {
        foreach (var SinhVien in danhSachSinhVien)
        {
            Console.WriteLine(SinhVien);
        }
    }

    public void TimSinhVienDiemCaoNhat()
    {
        if (danhSachSinhVien.Count == 0)
        {
            Console.WriteLine("Danh sách trống!");
            return;
        }

        SinhVien SinhVienDiemCaoNhat = danhSachSinhVien[0]; // Giả sử sinh viên đầu tiên có điểm cao nhất
        for (int i = 1; i < danhSachSinhVien.Count; i++)
        {
            if (danhSachSinhVien[i].DiemTB > SinhVienDiemCaoNhat.DiemTB)
            {
                SinhVienDiemCaoNhat = danhSachSinhVien[i];
            }
        }

        Console.WriteLine("Sinh viên có điểm trung bình cao nhất:");
        Console.WriteLine(SinhVienDiemCaoNhat);
    }


    public void ThongKeHocLuc()
    {
        if (danhSachSinhVien.Count == 0)
        {
            Console.WriteLine("Danh sách trống!");
            return;
        }
        var thongKe = danhSachSinhVien.GroupBy(sv => sv.XepLoai)
                                .ToDictionary(g => g.Key, g => g.Count());

        Console.WriteLine("Thống kê học lực:");
        foreach (var entry in thongKe)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} sinh viên");
        }
    }
}
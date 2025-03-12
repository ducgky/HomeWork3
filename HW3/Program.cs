using System;
using ClassLibraryCheckNull.Common;
using HW3.DataAccess;


class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== CHỌN CHƯƠNG TRÌNH =====");
            Console.WriteLine("1. Quan Ly Sinh Vien");
            Console.WriteLine("2. Phep Toan Phan So");
            Console.WriteLine("3. Quit !");
            string luaChon = CheckInvalidInput.NhapChuoi("Chọn chương trình: ");

            switch (luaChon)
            {
                case "1":
                    QuanLySinhVien qlsv = new QuanLySinhVien();
                    while (true)
                    {
                        Console.WriteLine("\n===== MENU =====");
                        Console.WriteLine("1. Nhập danh sách sinh viên");
                        Console.WriteLine("2. Hiển thị danh sách sinh viên");
                        Console.WriteLine("3. Tìm sinh viên có điểm trung bình cao nhất");
                        Console.WriteLine("4. Thống kê học lực");
                        Console.WriteLine("5. Quay lại");
                        string chon = CheckInvalidInput.NhapChuoi("Chọn chức năng: ");

                        switch (chon)
                        {
                            case "1":
                                qlsv.NhapDanhSachSinhVien();
                                break;
                            case "2":
                                qlsv.HienThiDanhSach();
                                break;
                            case "3":
                                qlsv.TimSinhVienDiemCaoNhat();
                                break;
                            case "4":
                                qlsv.ThongKeHocLuc();
                                break;
                            case "5":
                                goto MainMenu;
                            default:
                                Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại!");
                                break;
                        }
                    }
                    MainMenu:
                    break;
                case "2":
                    int tuso1 = CheckInvalidInput.NhapSoNguyen("Nhập tử số phân số 1: ");
                    int mauso1 = CheckInvalidInput.NhapSoNguyen("Nhập mẫu số phân số 1: ");
                    int tuso2 = CheckInvalidInput.NhapSoNguyen("Nhập tử số phân số 2: ");
                    int mauso2 = CheckInvalidInput.NhapSoNguyen("Nhập mẫu số phân số 2: ");
                    PhanSo ps1 = new PhanSo(tuso1, mauso1);
                    PhanSo ps2 = new PhanSo(tuso2, mauso2);
                    Console.WriteLine($"Tổng: {ps1 + ps2}");
                    Console.WriteLine($"Hiệu: {ps1 - ps2}");
                    Console.WriteLine($"Tích: {ps1 * ps2}");
                    Console.WriteLine($"Thương: {ps1 / ps2}");
                    break;
                case "3":
                    Console.WriteLine("Thoát chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại!");
                    break;
            }
        }
    }
}


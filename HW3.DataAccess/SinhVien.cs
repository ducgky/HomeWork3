using System;

enum HocLuc
{
    XuatSac,
    Gioi,
    Kha,
    TrungBinh,
    Yeu
}

class  SinhVien
{
    public string ID { get; set; }
    public string Ten { get; set; }
    public int Tuoi { get; set; }
    public double DiemHK1 { get; set; }
    public double DiemHK2 { get; set; }
    public double DiemTB => (DiemHK1 + DiemHK2) / 2;
    public HocLuc XepLoai => XepLoaiHocLuc(DiemTB);

    private HocLuc XepLoaiHocLuc(double diemTB)
    {
        if (diemTB >= 9) return HocLuc.XuatSac;
        if (diemTB >= 8) return HocLuc.Gioi;
        if (diemTB >= 6.5) return HocLuc.Kha;
        if (diemTB >= 5) return HocLuc.TrungBinh;
        return HocLuc.Yeu;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Tên: {Ten}, Tuổi: {Tuoi}, Điểm TB: {DiemTB:F2}, Học lực: {XepLoai}";
    }
}
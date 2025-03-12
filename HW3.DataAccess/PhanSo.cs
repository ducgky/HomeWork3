using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3.DataAccess
{
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo(int tuSo, int mauSo)
        {
            if (mauSo == 0)
            {
                throw new ArgumentException("Mẫu số không thể bằng 0");
            }
            TuSo = tuSo;
            MauSo = mauSo;
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.TuSo * b.MauSo + b.TuSo * a.MauSo, a.MauSo * b.MauSo);
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.TuSo * b.MauSo - b.TuSo * a.MauSo, a.MauSo * b.MauSo);
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.TuSo * b.TuSo, a.MauSo * b.MauSo);
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.TuSo * b.MauSo, a.MauSo * b.TuSo);
        }

        public override string ToString()
        {
            return $"{TuSo}/{MauSo}";
        }
    }
}

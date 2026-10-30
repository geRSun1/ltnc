using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geRSun1.VuongTronTamgiac
{
    internal class HinhVuong
    {
        private double canh;

        public double Canh
        {
            get => canh;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Canh phai > 0");
                }
                canh = value;
            }
        }

        public HinhVuong() { }

        public HinhVuong(double canh)
        {
            Canh = canh;
        }

        private double NhapKichThuoc(string tenKichThuoc)
        {
            double giatri = 0;
            bool hopLe = false;

            while (!hopLe)
            {
                Console.Write($"Nhap {tenKichThuoc} (> 0): ");
                string input = Console.ReadLine();

                if (!double.TryParse(input, out giatri))
                {
                    Console.WriteLine($"Loi: {tenKichThuoc} phai la mot so. Vui long nhap lai!\n");
                }
                else if (giatri <= 0)
                {
                    Console.WriteLine($"Loi: {tenKichThuoc} phai > 0. Vui long nhap lai!\n");
                }
                else
                {
                    hopLe = true;
                }
            }

            return giatri;
        }

        public void Nhap()
        {
            Canh = NhapKichThuoc("canh");
        }

        public double TinhDienTich() => Canh * Canh;

        public double TinhChuVi() => 4 * Canh;

        public string ThongTin()
        {
            return $"Hinh vuong co Canh = {Canh}, " +
                   $"Dien tich = {TinhDienTich():F2}, Chu vi = {TinhChuVi():F2}";
        }

        public void HienThi() => Console.WriteLine(ThongTin());
    }
}

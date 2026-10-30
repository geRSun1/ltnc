using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geRSun1.VuongTronTamgiac
{
    internal class HinhTron
    {
            private double banKinh;

            public double BanKinh
            {
                get => banKinh;
                set
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Ban kinh phai > 0");
                    }
                    banKinh = value;
                }
            }

            public HinhTron() { }

            public HinhTron(double banKinh)
            {
                BanKinh = banKinh;
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
                        hopLe = true; // Bán kính hợp lệ
                    }
                }

                return giatri;
            }

            public void Nhap()
            {
                BanKinh = NhapKichThuoc("ban kinh");
            }

            public double TinhDienTich() => Math.PI * BanKinh * BanKinh;

            public double TinhChuVi() => 2 * Math.PI * BanKinh;

            public string ThongTin()
            {
                return $"Hinh tron co Ban kinh = {BanKinh}, " +
                       $"Dien tich = {TinhDienTich():F2}, Chu vi = {TinhChuVi():F2}";
            }

            public void HienThi() => Console.WriteLine(ThongTin());
    }
}

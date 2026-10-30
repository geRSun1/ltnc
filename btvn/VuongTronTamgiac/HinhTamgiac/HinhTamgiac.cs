using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geRSun1.VuongTronTamgiac
{
    internal class HinhTamgiac
    {
        public class HinhTamGiac
        {
            private double canhA;
            private double canhB;
            private double canhC;

            public double CanhA
            {
                get => canhA;
                set
                {
                    if (value <= 0) throw new ArgumentException("Canh A phai > 0");
                    canhA = value;
                }
            }

            public double CanhB
            {
                get => canhB;
                set
                {
                    if (value <= 0) throw new ArgumentException("Canh B phai > 0");
                    canhB = value;
                }
            }

            public double CanhC
            {
                get => canhC;
                set
                {
                    if (value <= 0) throw new ArgumentException("Canh C phai > 0");
                    canhC = value;
                }
            }

            public HinhTamGiac() { }

            public HinhTamGiac(double a, double b, double c)
            {
                if (a <= 0 || b <= 0 || c <= 0 || (a + b <= c) || (a + c <= b) || (b + c <= a))
                {
                    throw new ArgumentException("Ba canh khong thoa man bat dang thuc tam giac!");
                }
                canhA = a;
                canhB = b;
                canhC = c;
            }

            private double NhapMotCanh(string tenCanh)
            {
                double giatri = 0;
                bool hopLe = false;

                while (!hopLe)
                {
                    Console.Write($"Nhap {tenCanh} (> 0): ");
                    string input = Console.ReadLine();

                    if (!double.TryParse(input, out giatri))
                    {
                        Console.WriteLine($"Loi: {tenCanh} phai la mot so. Vui long nhap lai!\n");
                    }
                    else if (giatri <= 0)
                    {
                        Console.WriteLine($"Loi: {tenCanh} phai > 0. Vui long nhap lai!\n");
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
                while (true)
                {
                    double a = NhapMotCanh("canh A");
                    double b = NhapMotCanh("canh B");
                    double c = NhapMotCanh("canh C");

                    // Kiểm tra điều kiện tạo thành tam giác
                    if ((a + b > c) && (a + c > b) && (b + c > a))
                    {
                        canhA = a;
                        canhB = b;
                        canhC = c;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Loi: Tong hai canh bat ky phai lon hon canh con lai! Vui long nhap lai ca 3 canh.\n");
                    }
                }
            }

            public double TinhChuVi() => CanhA + CanhB + CanhC;

            // Tính diện tích sử dụng công thức Heron
            public double TinhDienTich()
            {
                double p = TinhChuVi() / 2.0;
                return Math.Sqrt(p * (p - CanhA) * (p - CanhB) * (p - CanhC));
            }

            public string ThongTin()
            {
                return $"Hinh tam giac co Canh A = {CanhA}, Canh B = {CanhB}, Canh C = {CanhC}, " +
                       $"Dien tich = {TinhDienTich():F2}, Chu vi = {TinhChuVi():F2}";
            }

            public void HienThi() => Console.WriteLine(ThongTin());
        }
    }
}

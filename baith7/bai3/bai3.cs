using System;
using System.Collections.Generic;
using System.Text;

namespace baith7.NewFolder
{
    abstract class Xe
    {
        protected double sogio;
        public Xe(double sogio)
        {
            this.sogio = sogio;
        }
        public abstract double Tinhtien();
        public abstract void Hien();
    }
    class XeDL : Xe
    {
        public XeDL(double sogio) : base(sogio) { }
        public override double Tinhtien()
        {
            if (sogio <= 1) return 250;
            else
                return 250 + (sogio - 1) * 75;
        }
        public override void Hien()
        {
            Console.WriteLine("Xe du lich");
        }
    }
    class XeTai : Xe
    {
        public XeTai(double sogio) : base(sogio) { }
        public override double Tinhtien()
        {
            if (sogio <= 1) return 220;
            else
                return 220 + (sogio - 1) * 85;
        }
        public override void Hien()
        {
            Console.WriteLine("Xe Tai");
        }
    }
    class Khach
    {
        private string hoten, quequan;
        private DateTime ngaysinh;
        private double sogio;
        private Xe loaixe;
        public void Nhap()
        {
            Console.WriteLine("nhap thong tin cua khach hang thue xe");
            Console.Write("ho ten:"); hoten = Console.ReadLine();
            Console.Write("que quan:"); quequan = Console.ReadLine();
            Console.Write("ngay sinh:"); ngaysinh = DateTime.Parse(Console.ReadLine());
            Console.Write("so gio:"); sogio = double.Parse(Console.ReadLine());
            Console.Write("Khach hang muon thue loai xe nao XeDl(L) hay XeTai(T)?");
            char ch = char.Parse(Console.ReadLine());
            switch (char.ToUpper(ch))
            {
                case 'L':
                    loaixe = new XeDL(sogio);
                    Console.WriteLine("Khach hang vua thue xe "); loaixe.Hien();
                    break;
                case 'T':
                    loaixe = new XeTai(sogio);
                    Console.WriteLine("Khach hang vua thue xe "); loaixe.Hien();
                    break;
            }
        }
        public void Hien()
        {
            Console.WriteLine("thong tin khach hang thue xe");
            Console.WriteLine("Ho ten:" + hoten);
            Console.WriteLine("Que quan:" + quequan);
            Console.WriteLine("Ngay sinh:" + ngaysinh.ToString("dd/MM/yyyy"));
            Console.WriteLine("So gio thue:" + sogio);
            Console.WriteLine("Dich vu xe khach hang da thue:"); loaixe.Hien();
            Console.WriteLine("Tien thue xe:" + loaixe.Tinhtien());
        }
    }
    class QL
    {
        private Khach[] ds;
        private int sck;
        public void Nhap()
        {
            Console.Write("Nhap so khach hang"); sck = int.Parse(Console.ReadLine());
            ds = new Khach[sck];
            for (int i = 0; i < sck; i++)
            {
                ds[i] = new Khach();
                ds[i].Nhap();
            }
        }
        public void Hien()
        {
            Console.WriteLine("Thong tin cac khach hang da thue xe:");
            for (int i = 0; i < sck; ++i)
            {
                Console.WriteLine("------------------------------------");
                ds[i].Hien();
            }
        }
    }
    class App
    {
        static void Main()
        {
            QL t = new QL();
            t.Nhap();
            Console.Clear();
            t.Hien();
            Console.ReadLine();

        }
    }

}
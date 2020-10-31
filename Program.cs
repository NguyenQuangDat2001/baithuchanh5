using System;
using System.Reflection.Metadata.Ecma335;

namespace bài_1
{
    class TienDien
    {
        private string tench;
        private string DiaChi;
        private int socongtothangtr, socongtothangn;
        public TienDien()
        {
            tench = DiaChi = " ";
            socongtothangtr = socongtothangn = 0;
        }
        public TienDien(string tench,string DiaChi,int socongtothangtr,int socongtothangn)
        {
            this.tench = tench;
            this.DiaChi = DiaChi;
            this.socongtothangtr = socongtothangtr;
            this.socongtothangn = socongtothangn;
        }
        public void nhap()
        {
            Console.Write("nhap ten chu ho :");
            tench = Console.ReadLine();
            Console.Write("nhap Dia chi :");
            DiaChi = Console.ReadLine();
            Console.Write("nhap so cong to thang truoc :");
            socongtothangtr = int.Parse( Console.ReadLine());
            Console.Write("nhap so cong to thang nay :");
            socongtothangn = int.Parse(Console.ReadLine());
        }
        public void hien()
        {
            Console.WriteLine("ten chu ho\t\tdia chi\t\tsocongtotieudung");
            Console.WriteLine("{0}\t\t{1}\t\t{2}", tench, DiaChi, socongtothangn - socongtothangtr);
            Console.WriteLine("so tien can thanh toan:" + tinhtien());
        }
        public int Tinhsocongtodadung
        {
            get
            {
                return socongtothangn - socongtothangtr;
            }
        }
        public int tinhtien()
        {
            return Tinhsocongtodadung * 500;
        }
    }
    class TienDienMoi : TienDien
    {
        private int dinhmuc;
        public TienDienMoi()
        {
            dinhmuc = 0;
        }
        public TienDienMoi(string tench, string DiaChi, int socongtothangtr, int socongtothangnay, int dinhmuc)
        {
            this.dinhmuc = dinhmuc;
        }
        public new void nhap()
        {
            base.nhap();
            Console.Write("nhap dinh muc :");
            dinhmuc = int.Parse(Console.ReadLine());
        }
        public new void hien()
        {
            base.hien();            
        }
        public int TienDien()
        {
            if (Tinhsocongtodadung < dinhmuc)
                return Tinhsocongtodadung * 500;
            else
                return Tinhsocongtodadung * 600;
                
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            TienDienMoi t = new TienDienMoi();
            t.nhap();
            t.hien();
            t.tinhtien();
        }
    }
}

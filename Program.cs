using System;

namespace bài_2
{
    class TamGiac
    {
        private double A,B,C;
        
        public TamGiac()
        {
            A = B = C = 0;
        }
        public TamGiac(double canhA,double canhB,double canhC)
        {
            this.A = canhA;
            this.B = canhB;
            this.C = canhC;
        }
        public void nhap()
        {
            Console.Write(" nhap do dai canh A:"); A = int.Parse(Console.ReadLine());
            Console.Write(" nhap do dai canh B:"); B = int.Parse(Console.ReadLine());
            Console.Write(" nhap do dai canh C:"); C = int.Parse(Console.ReadLine());
        }
        public void hien()
        {
            Console.WriteLine("thông tin về hình ......");
            Console.WriteLine("Canh A = {0}\n\n Canh B = {1}\n\n Canh C = {2}", A, B, C);
            Console.WriteLine("dien tich day = {0}", TinhDienTich);
        }
        public bool kiemtra(double A,double B,double C)
        {
            return A + B > C && A + C > B && B + C > A;
        }
        public double TinhDienTich
        {
            get
            {
                if (kiemtra(A, B, C))
                {
                    double p = A + B + C / 2;
                    double s = Math.Sqrt(p * ((p - A) * (p - B) * (p - C)));
                    return s;
                }
                else
                {
                    Console.WriteLine("ba diem thang hang");
                }
                return TinhDienTich;
            }

        }
    }    
    class TuDien : TamGiac
    {
        private double h;
        public TuDien()
        {
            h = 0;
        }
        public TuDien(double A,double B,double C,double h)
        {
            this.h = h;
        }
        public new void nhap()
        {
            base.nhap();
            Console.Write("nhap chieu cao :");h = int.Parse(Console.ReadLine());
        }
        public new void hien()
        {
            base.hien();
            Console.WriteLine("chieu cao cua tu dien: " + h);
            Console.WriteLine("dien tich tu dien =" + tinhdienticTD());
        }
        public double tinhdienticTD()
        {
            double j = 1 / 3 * h *TinhDienTich;
            return j;      
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TamGiac t = new TamGiac();
            t.nhap();
            t.hien();
            Console.ReadKey();
            TuDien g = new TuDien();
            g.nhap();
            g.hien();
           
          
        }
    }
}

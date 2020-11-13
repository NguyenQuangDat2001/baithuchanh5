using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baith5
{
    class PTBH
    {
        protected double a, b, c;
        public PTBH()
        {
            a = b = c = 0;
        }
        public PTBH(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public void Nhap()
        {
            Console.Write("Nhap a="); a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b="); b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c="); c = double.Parse(Console.ReadLine());

        }
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value != 0) a = value;
            }
        }
        public double Delta()
        {
            return (b * b - 4 * A * c);
        }
        public void Giai()
        {

            if (Delta() > 0)
            {
                double x1 = (-b - Math.Sqrt(Delta())) / (2 * A);
                double x2 = (-b + Math.Sqrt(Delta())) / (2 * A);
                Console.WriteLine("Phuong trinh co hai nghiem \nx1={0}\nx2={1}", x1, x2);
            }
            else if (Delta() == 0) Console.WriteLine("Phuong trinh co nghiem duy nhat x={0}", -b / (2 * A));
            else Console.WriteLine("Phuong trinh vo nghiem");
        }


    }
    class PTTP : PTBH
    {
        public new void Giai()
        {
            double d = Delta();
            if (d == 0)
            {
                double y = -b / (2 * A);
                if (y < 0) Console.WriteLine("Phuong trinh vo nghiem!");
                else
                    Console.WriteLine("Phuong trinh trung phuong co 2 nghiem x1={0}\tx2={1}", -Math.Sqrt(y), Math.Sqrt(y));
            }
            else if (d < 0) Console.WriteLine("Phuong trinh vo nghiem");
            else
            {
                double y1 = (-b - Math.Sqrt(Delta())) / (2 * A);
                double y2 = (-b + Math.Sqrt(Delta())) / (2 * A);
                if (y1 < 0 && y2 < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (y1 > 0 && y2 < 0)
                    Console.WriteLine("Phuong trinh co 2 nghiem x1={0}\t x2={1}", Math.Sqrt(y1), -Math.Sqrt(y1));
                else if (y1 < 0 && y2 > 0)
                    Console.WriteLine("Phuong trinh co 2 nghiem x1={0}\t x2={1}", Math.Sqrt(y2), -Math.Sqrt(y2));
                else Console.WriteLine("Phuong trinh co 4 nghiem phan biet\n x1={0}\nx2={1}\nx3={2}\nx4={3}", Math.Sqrt(y1), -Math.Sqrt(y1), Math.Sqrt(y2), -Math.Sqrt(y2));
            }
        }
    }
    class App
    {
        static void Main()
        {
            PTTP p = new PTTP();
            p.Nhap();
            p.Giai();
            Console.ReadKey();
        }
    }
}
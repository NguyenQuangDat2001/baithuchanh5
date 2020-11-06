using System;
class Matran
{
    private static int n;
    private int[,] a;
    public Matran()
    {
        a = new int[n, n];
    }
    public static int N
    {
        get { return n; }
        set
        {
            if (value >= 2) n = value;
        }
    }
 
    public void Nhap()
    {
        for (int i = 0; i < n; ++i)
            for (int j = 0; j < n; ++j)
            {
                Console.Write("a[{0},{1}]=", i, j);
                a[i, j] = int.Parse(Console.ReadLine());
            }
    }
    
    public void Hien()
    {
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < n; ++j)
                Console.Write("{0}\t", a[i, j]);
            Console.WriteLine();
        }
    }
    
    public Matran Tong(Matran t2)
    {
        Matran t = new Matran();
        for (int i = 0; i < n; ++i)
            for (int j = 0; j < n; ++j)
                t.a[i, j] = this.a[i, j] + t2.a[i, j];
        return t;
    }
}
class QLMatran
{
    private Matran[] ds;
    private int somt;
    public void Nhap()
    {
        Console.Write("Nhap cap cho ma tran:");
        Matran.N = int.Parse(Console.ReadLine());
        Console.Write("Nhap so ma tran:");
        somt = int.Parse(Console.ReadLine());
        ds = new Matran[somt];
        for (int i = 0; i < somt; ++i)
        {
            Console.WriteLine("Nhap ma tran thu " + i);
            ds[i] = new Matran();
            ds[i].Nhap();
        }
    }
   
    public Matran Tong()
    {
        Matran t = new Matran
();
        for (int i = 0; i < somt; ++i)
            t = t.Tong(ds[i]);
        return t;
    }

}
  
class App
{
    static void Main()
    {
        QLMatran t = new QLMatran();
        t.Nhap();
        Console.WriteLine("Ma tran tong");
        t.Tong().Hien();
        Console.ReadLine();
    }
}


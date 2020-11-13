using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baith5
{
    class Person
    {
        private string name, nationality;
        private int age;
        public Person()
        {
            name = nationality = " ";
            age = 0;
        }
        public Person(string name, string nationality, int age)
        {
            this.name = name;
            this.nationality = nationality;
            this.age = age;
        }
        public void Nhap()
        {
            Console.Write("Nhap ten:"); name = Console.ReadLine();
            Console.Write("Nhap tuoi: "); age = int.Parse(Console.ReadLine());
            Console.Write("Nhap quoc tich:"); nationality = Console.ReadLine();
        }
        public void Hien()
        {
            Console.WriteLine("Ten:{0}\tTuoi:{1}\tQuoc tich:{2}", name, age, nationality);
        }

    }
    class Player : Person
    {
        private int number;
        private string position;
        private Team team;
        public Player() : base()
        {
            number = 0;
            position = " ";
        }

        public Player(string name, string nationality, int age, int number, string position, Team team) : base(name, nationality, age)
        {
            this.number = number;
            this.position = position;
            this.team = team;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so ao:"); number = int.Parse(Console.ReadLine());
            Console.Write("Nhap vi tri thi dau:"); position = Console.ReadLine();

        }
        public new void Hien()
        {
            base.Hien();
            Console.WriteLine("{0}\t{1}\t{2}", number, position, team);
        }


    }
    class Coach : Person
    {
        private int year;
        public Coach() : base()
        {
            year = 0;
        }
        public Coach(string name, string nationality, int age, int year) : base(name, nationality, age)
        {
            this.year = year;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so nam lam huan luyen vien:"); year = int.Parse(Console.ReadLine());
        }
        public new void Hien()
        {
            base.Hien();
            Console.Write("{0}", year);
        }
    }
    class Team

    {
        private string name;
        private Player[] ds;
        private Coach coach;

        public void Nhap()
        {
            Console.Write("Nhap ten doi: "); name = Console.ReadLine();
            ds = new Player[11];

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Nhap cau thu thu {0}", i + 1);
                ds[i] = new Player();
                ds[i].Nhap();

            }
        }
        public void Hien()
        {
            Console.WriteLine("{0}", name);
            for (int i = 0; i < 11; i++)
                ds[i].Hien();
        }
    }
    class App1
    {
        static void Main2()
        {
            Team t = new Team();
            t.Nhap();
            t.Hien();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class process
    {
        public abstract double processing();
    }
    class triangle : process
    {
        double side;
        
        public triangle(double s)
        {
            side = s;

        }

        public override double processing()

        {
            return ( 3 * side);
        }
    }
    class circle : process
    {
        double radius;
        public circle(double r)
        {
            radius = r;
        }
        public override double processing()

        {
            return (2 * (Convert.ToDouble(3.14)) * radius);
        }
    }
    class rectangle : process
    {
        double length;
        double width;
        public rectangle(double a, double b)
        {
            length = a;
            width = b;
        }
        public override double processing()
        {
            return (2 * (length + width));
        }
    }

    class trapezoid : process
    {
        double side;
        public trapezoid(double s)
        {
            side = s;
        }
        public override double processing()
        {
            return ( 4 * side);
        }
    }
    class Menu_Keliling
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ===================================");
            Console.WriteLine(" ===   PERHITUNGAN KELILING     ====");
            Console.WriteLine(" ===================================");
            Console.WriteLine(" ======     1. Segitiga      =======");
            Console.WriteLine(" ======     2. Lingkaran     =======");
            Console.WriteLine(" ======  3. Persegi Panjang  =======");
            Console.WriteLine(" =========  4. Trapesium     =======");
            Console.WriteLine(" ===================================");
            Console.WriteLine(" ===   PILIHAN MENU : ....     ====");
            Console.WriteLine(" ===================================");
            double nomor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("====================================");

            if (nomor == 1)
            {
                Console.WriteLine();
                Console.Write("Masukkan sisi  : ");
                double side = Convert.ToDouble(Console.ReadLine());
                process p = new triangle(side);
                double l = p.processing();
                Console.WriteLine("Keliling Segitiga : " + l);

            }
            else if (nomor == 2)

            {
                Console.Write("Masukkan jari-jari : ");
                double radius = Convert.ToDouble(Console.ReadLine());
                process a = new circle(radius);
                double b = a.processing();
                Console.WriteLine("Keliling Lingkaran : " + b);

            }
            else if (nomor == 3)
            {
                Console.Write("Masukkan panjang: ");
                double panjang = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan lebar : ");
                double lebar = Convert.ToDouble(Console.ReadLine());
                process x = new rectangle(panjang, lebar);
                double y = x.processing();
                Console.WriteLine("Keliling Persegi Panjang : " + y);

            }
            else
            {
                Console.Write("Masukkan side : ");
                double side = Convert.ToDouble(Console.ReadLine());
                process m = new trapezoid(side);
                double n = m.processing();
                Console.WriteLine("Keliling Trapesium : " + n);
            }
            Console.Read();
        }
    }
}


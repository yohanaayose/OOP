//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Boothcamp24
//{
//    class Tugas1
//    {
//        public int pilih = 0;
//        public static void main(string[] args)

//        {

//            Console.WriteLine(" ===================================");
//            Console.WriteLine(" ===   PERHITUNGAN KELILING     ====");
//            Console.WriteLine(" ===================================");
//            Console.WriteLine(" ======     1. Segitiga      =======");
//            Console.WriteLine(" ======     2. Lingkaran     =======");
//            Console.WriteLine(" ======  3. Persegi Panjang  =======");
//            Console.WriteLine(" =========  4. Trapesium     =======");

//            Console.WriteLine(" ===================================");
//            Console.WriteLine(" ===   PILIHAN MU : ....     ====");
//            Console.WriteLine(" ===================================");
//            Console.Read();
//            int pilih = int.Parse(Console.ReadLine());

//            switch (pilih)
//            {
//                case 1:
//                    {
//                        decimal side = (int.Parse(Console.ReadLine()));
//                        triangle a = new triangle(side);
//                        Console.WriteLine("Menghitung Keliling Segitiga");
//                        Console.WriteLine("------------------------");
//                        Console.Write("Side : ");
//                        a.side = (int.Parse(Console.ReadLine()));
//                        Console.WriteLine("result. " + a);

//                        break;
//                    }

//                case 2:
//                    {
//                        decimal radius = (int.Parse(Console.ReadLine()));
//                        circle b = new circle(radius);
//                        Console.WriteLine("Menghitung Keliling Lingkaran");
//                        Console.WriteLine("------------------------");
//                        Console.Write("radius : ");
//                        b.radius = (int.Parse(Console.ReadLine()));
//                        Console.WriteLine("result. " + b);


//                        break;
//                    }

//                case 3:
//                    {
//                        decimal length = (int.Parse(Console.ReadLine()));
//                        decimal width = (int.Parse(Console.ReadLine()));
//                        rectangle c = new rectangle(length, width);
//                        Console.WriteLine("Menghitung Keliling Persegi Panjang");
//                        Console.WriteLine("------------------------");
//                        Console.Write("length : ");
//                        c.length = (int.Parse(Console.ReadLine()));
//                        Console.Write("width : ");
//                        c.width = (int.Parse(Console.ReadLine()));
//                        Console.WriteLine("result. " + c);

//                        break;
//                    }

//                case 4:
//                    {
//                        decimal side = (int.Parse(Console.ReadLine()));
//                        trapezoid d = new trapezoid(side);
//                        Console.WriteLine("Menghitung Keliling Trapesium");
//                        Console.WriteLine("------------------------");
//                        Console.Write("side : ");
//                        d.side = (int.Parse(Console.ReadLine()));
//                        Console.WriteLine("result. " + d);

//                        break;
//                    }
//            }

//        }
//        /* Menghitung Keliling Segitiga */

//        public abstract class Process
//        {
//            public abstract decimal Processing();
//        }

//        public class triangle : Process
//        {
//            public decimal side;

//            public triangle(decimal a)
//            {
//                side = a;

//            }
//            public override decimal Processing()
//            {
//                return (3 * side);
//            }
//        }

//        /* Menghitung Keliling Lingkaran */

//        public class circle : Process
//        {
//            public decimal radius;

//            public circle(decimal r)
//            {
//                radius = r;

//            }
//            public override decimal Processing()
//            {
//                return (2 * (Convert.ToDecimal(3.14)) * radius);
//            }
//        }

//        /* Menghitung Keliling Persegi Panjang */
//        public class rectangle : Process
//        {
//            public decimal length;
//            public decimal width;
//            public rectangle(decimal a, decimal b)
//            {
//                length = a;
//                width = b;
//            }
//            public override decimal Processing()
//            {
//                return (2 * (width + length));
//            }
//        }
//        /* Menghitung Keliling Trapesium */

//        public class trapezoid : Process
//        {
//            public decimal side;

//            public trapezoid(decimal s)
//            {
//                side = s;

//            }
//            public override decimal Processing()
//            {
//                return (4 * side);
//            }
//        }

//    }
//}



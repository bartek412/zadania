using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,delta,x1,x2;
            Console.WriteLine("podaj a!");
            a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("a nie moze byc rowne 0");
                Console.Read();
                Environment.Exit(0);
            }
            Console.WriteLine("podaj b!");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj c!");
            c = double.Parse(Console.ReadLine());
            delta = Math.Pow(b, 2) - (4 * a * c);
            x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            x2 = (-b - Math.Sqrt(delta)) / 2 * a;
            
           if (delta<0)            {
                Console.WriteLine("rownanie nie ma roz");
                Console.Read();
                Environment.Exit(0);
            }
            else if(delta==0)
            {
                Console.WriteLine("rozwiazaniem rownania jest {0:#.##}",x1);
            }
            else
            {
                Console.WriteLine("rozwiazaniamin rownania sa {0:#.##} i {1:#.##}", x1,x2);
            }
            Console.Read();
        }
    }
}

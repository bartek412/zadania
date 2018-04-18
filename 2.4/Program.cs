using System;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x;
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
         
            x = (c - b) / a;
            Console.WriteLine("Dla a = {0:##.##} b = {1:##.##} c = {2:##.##} rownanie ax+b=c ma roz w = {3:##.##}", a,b,c,x);
            //Console.WriteLine(x);

            Console.Read();
        }
    }
}

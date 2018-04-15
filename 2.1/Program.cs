using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c;
            Console.WriteLine("podaj a!");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj b!");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj c!");
            c = double.Parse(Console.ReadLine());
            if (Math.Pow(a,2)+Math.Pow(b, 2)== Math.Pow(c, 2))
            {
                Console.WriteLine("trojkat jest pitagorejski");
            }
            else if  (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
            {
                Console.WriteLine("trojkat jest pitagorejski");
            }
            else if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
            {
                Console.WriteLine("trojkat jest pitagorejski");
            }
            else
            {
                Console.WriteLine("trojkat nie jest pitagorejski");
            }
            Console.Read();

        }
    }
}

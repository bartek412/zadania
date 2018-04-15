using System;

namespace zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            Console.WriteLine("podaj a!");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine("podaj b!");
            b= double.Parse(Console.ReadLine());
            Console.WriteLine(a*b);
            double pi;
            pi= Math.Sqrt(Math.PI);
            Console.WriteLine("pierw z pi= {0:#.#####}", pi);
             
            Console.ReadKey();
            

        }
    }
}

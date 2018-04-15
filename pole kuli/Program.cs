using System;

namespace pole_kuli
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, obj;
            Console.WriteLine("Podaj r");
            r= double.Parse( Console.ReadLine());
            obj = (4 * Math.PI* Math.Pow(r, 3))/3;
            Console.WriteLine("dla promienia {0:#.##} obwod jest rowny {1:#.##}", r,obj);
            Console.Read();

        }
    }
}

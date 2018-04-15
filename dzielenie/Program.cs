using System;

namespace dzielenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b,suma,roznica,iloczyn,iloraz;
            Console.WriteLine("Podaj a:");
            a=Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            
           b = Double.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Nie mozna dzielic przez zero");
                Console.Read();
                Environment.Exit(0);
            }
            suma = a + b;
            roznica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("suma rowna sie {0:#.##}",suma);
            Console.WriteLine("roznica rowna sie {0:#.##}", roznica);
            Console.WriteLine("iloczyn rowna sie {0:#.##}", iloczyn);
            Console.WriteLine("iloraz rowna sie {0:#.##}", iloraz);
            Console.Read();
        }
    }
}

using System;

namespace _5._01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            void czytaj() {
                Console.WriteLine("podaj wymiary prostokata");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("podaj 2 bok");
                b= double.Parse(Console.ReadLine());
                 }
            double przetworz(double x,double y)
            {
                return x * y;
            }
            void wyswietl()
            {
                Console.WriteLine("pole prostokata to: {0:##.##}",przetworz(a,b));
            }
            czytaj();
            wyswietl();
            Console.Read();
        }
    }
}

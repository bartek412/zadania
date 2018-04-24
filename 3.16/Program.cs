using System;

namespace _3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int max=0, min=100, n = 5,suma=0,liczba,x=0;
            min = random.Next(1, 99);
            max = min;
            suma = min;
            for (int i = 0; i < n-1; i++)
            {
                x++;
                liczba = random.Next(1, 99);
                suma = liczba + suma;
                if (liczba>max)
                {
                    max = liczba;
                }
                if (liczba<min)
                {
                    min = liczba;
                }
              
                
            }
            Console.WriteLine("min wynosi= "+min+" max wynosi= "+ max+ " srednia wynosi= "+suma/n);
            Console.Read();
        }
    }
}

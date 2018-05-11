using System;

namespace _6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Serializacja serializacja = new Serializacja();
            double[] table = new double[] { 10.17, 12.83, 11.78, 15.53, 11.08, 12.67 };
            serializacja.CzytajZapisz(table);
            Console.Read();
        }
    }
}

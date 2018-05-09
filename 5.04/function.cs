using System;
using System.Collections.Generic;
using System.Text;

namespace _5._04
{
    class function
    {
     public    void czyta(int[] liczby)
        {
            Console.WriteLine("liczby nieposortowane to: ");
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write(liczby[i]+"  ");
            }
            Console.WriteLine();
        }
        public void sortuj(int[] liczby)
        {
            int i, j, x;
            for (i = 0; i < liczby.Length; i++)
                for (j = 0; j < liczby.Length-1; j++)
                {
                    if (liczby[j] > liczby[j + 1])
                    {
                        x = liczby[j + 1];
                        liczby[j + 1] = liczby[j];
                        liczby[j] = x;
                    }
                }
        }
        public void wyswietl(int[] liczby )
        {
            Console.WriteLine("liczby posortowane to: ");
            for (int i = 0; i<liczby.Length; i++)
            {
                Console.Write(liczby[i] + "  ");
            }
            Console.Read();
}
    }
}

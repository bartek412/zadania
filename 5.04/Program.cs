using System;

namespace _5._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = new int[] { 4, 3,-5,20,-4,0 };

            function function = new function();
            function.czyta(liczby);
            function.sortuj(liczby);
            function.wyswietl(liczby);

        }
    }
}

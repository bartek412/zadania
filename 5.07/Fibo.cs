using System;
using System.Collections.Generic;
using System.Text;

namespace _5._07
{
    class Fibo
    {
        public int Oblicz(int n)
        {
            if (n == 1) return 0;
            else if (n == 2) return 1;
            else return Oblicz(n - 1) + Oblicz(n - 2);
        }
    }
}

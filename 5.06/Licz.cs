using System;
using System.Collections.Generic;
using System.Text;

namespace _5._06
{
    class Licz
    {
       public int Oblicz(int n)
        {
            if (n==1)
            {
                return 1;
            }
            else
            {
                return n + Oblicz(n - 1);
            }
        }
    }
}

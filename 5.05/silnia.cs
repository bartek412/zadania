using System;
using System.Collections.Generic;
using System.Text;

namespace _5._05
{
    class silnia
    {
        public long silnial(int liczba)
        {
            long zwrot = 1;
            if (liczba >=2)
            {
                zwrot = liczba * silnial(liczba - 1);
                     
            }
            return zwrot;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace _6._4
{
    class PlikSwobodny
    {
        
        FileStream f;
        public void Odczyt(char[] table )
        {
            f = new FileStream("table.dat", FileMode.Create);
            for (int i = 0; i < table.Length; i++)
            {
                f.WriteByte((byte)table[i]);
            }
            f.Close();
            f = new FileStream("table.dat", FileMode.Open);
            Console.WriteLine();
            for (int i = 0; i < table.Length; i++)
            {
                f.Seek(i, SeekOrigin.Begin);
                char ch = (char)f.ReadByte();
                if (i < table.Length - 1) Console.Write(ch+", ");
                else Console.Write(ch + ".");
            }
            f.Close();
        }
    
    }
}

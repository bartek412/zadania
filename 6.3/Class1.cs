using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _6._3
{
    class Class1
    {
        FileStream fin, fout;
        public void Czytaj(int[,] table, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 1) table[i, j] = 1;
                    else table[i, j] = 0;
                    Console.Write(table[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        public void Przetworz(int[,] table, int[,] table2, int n)
        {
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    table2[i, j] = table[j, i];
                    Console.Write(table2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Zapisz(int[,] table2, int n)
        {
            Console.WriteLine();
            fout = new FileStream("dane.txt", FileMode.Create);
            StreamWriter strw = new StreamWriter(fout);
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    strw.Write((char)table2[i, j]);
                    Console.Write(table2[i, j] + " ");
                }
                Console.WriteLine();
            }
            strw.Close();
            fout.Close();

        }
        public void Odczyt(int[,] table3,int n)
        {
            Console.WriteLine();
            Console.WriteLine();
            fin = new FileStream("dane.txt", FileMode.Open);
            StreamReader str = new StreamReader(fin);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    table3[i,j]=str.Read();
                    Console.Write(table3[i, j] + " ");
                }
                Console.WriteLine();
            }
            str.Close();
            fin.Close();
        }
    }
}

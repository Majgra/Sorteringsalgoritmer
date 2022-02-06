using System;
using System.Diagnostics;

namespace Sorteringsalgoritmer
{
    class Program
        {
        public static void Main()
        {
            int [] lista = SkapaLista(100000);

            Stopwatch klockan = Stopwatch.StartNew();
            QuickSort.Sort (lista);
            klockan.Stop();
            Console.WriteLine(klockan.ElapsedMilliseconds);
        }

        

        static int[] SkapaLista(int antal)
        {
            int [] lista = new int [antal];
            Random rand = new Random();
            for (int i = 0; i < lista.Length; i++)
            {
                lista [i] = rand.Next();
            }
            return lista;
        }     
    }
}
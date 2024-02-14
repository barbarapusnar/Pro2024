using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tabele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] a = new int[10];
            int[] a = { 80, 3, 7, 9, 1, 5, 6, 84, 15 };
            //int[] a = new int[5000000];
            //Random r = new Random();
            //for (int k = 0; k < a.Length; k++)
            //    a[k] = r.Next(100000);
            //DateTime d1 = DateTime.Now;
            //Array.Sort(a);
            //DateTime d2 = DateTime.Now;
            //double čas1 = (d2 - d1).TotalMilliseconds;
            //Console.WriteLine("Urejanje z arrays.sort "+čas1);
            //urejanje z izbiranjem
            //Console.WriteLine("Neurejena ");
            //Izpiši(a);
            //poišči najmanjšega v preostanku tabele in ga zmenjaj
            //s prvim od preostanka
            //DateTime pred = DateTime.Now;
            //for (int x = 0; x < a.Length - 1; x++)
            //{
            //    int min = a[x];
            //    int imin = x;
            //    for (int k = x + 1; k < a.Length; k++)
            //    {
            //        if (a[k] < min)
            //        {
            //            min = a[k]; imin = k;
            //        }
            //    }
            //    //zamnejava najmnajšega  s prvim elemntom
            //    int temp = a[x];
            //    a[x] = a[imin];
            //    a[imin] = temp;
            //    //Izpiši(a);
            //}
            //DateTime po = DateTime.Now;
            //double čas = (po - pred).TotalMilliseconds;
            //Console.WriteLine("Izbiranje 50000 elementov "+čas);
            ////z vstavljanjem
            //for (int k = 0; k < a.Length; k++)
            //    a[k] = r.Next(100000);
            //pred = DateTime.Now;
            //for (int k = 1; k < a.Length; k++)
            //{
            //    int j = k;int temp = a[k];
            //    //pogrezni k-ti elemnt na pravo mesto v tabeli od a[0] do a[k-1]
            //    //element sodi na mesto j
            //    while (j>0 && a[j - 1] > temp)
            //    {
            //        a[j] = a[j - 1];
            //        j--;
            //    }
            //    a[j] = temp;
            //    //Izpiši(a);
            //}
            //po = DateTime.Now;
            //čas = (po - pred).TotalMilliseconds;
            //Console.WriteLine("Vstavljanje 50000 elementov " + čas);
            //bubble sort

        }
        static void Izpiši(int[] tab)
        {
            for (int k=0;k<tab.Length;k++)
                Console.Write(tab[k]+"\t");
            Console.WriteLine();
        }
    }
}

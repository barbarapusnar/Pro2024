using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabele2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //minolovec
            Random r = new Random();
            bool[,] mine = new bool[10 + 2, 10 + 2];
            //napolnimo tabelo mine z vrednotmi true, z verjetnostjo 0.3
            for (int k = 1; k <= 10; k++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    mine[k, j] = r.NextDouble() < 0.25;
                }
            }
            for (int k = 1; k <= 10; k++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (mine[k,j])
                        Console.Write("*"+"\t");
                    else
                        Console.Write("M"+"\t");
                }
                Console.WriteLine();
            }
            int[,] rešitev = new int[10 + 2, 10 + 2];
            for (int k = 1; k <= 10; k++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    //izračunaj koliko min je v okolici pozicije (k,j)
                    for (int z = k - 1; z <= k + 1; z++)
                    {
                        for (int w = j - 1; w <= j + 1; w++)
                        {
                            if (mine[z, w])
                                rešitev[k, j]++;
                        }
                    }
                }
            }
            Console.WriteLine();
            for (int k = 1; k <= 10; k++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (mine[k, j])
                        Console.Write("*" + "\t");
                    else
                        Console.Write(rešitev[k,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

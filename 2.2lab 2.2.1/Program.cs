using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2lab_2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            const int n = 23;
            int[] p = new int[n];

            int low = -19;
            int high = 25;

            for (int i = 0; i < n; i++)
                p[i] = -19 + rnd.Next() % (25 - (-19) + 1);

            Console.Write("p[] = {");
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                if ((p[i] >= 0) || (i % 4 == 0))
                    s++;
                else
                    continue;

                Console.Write($"{s} , ");

            }
            Console.WriteLine("}");
            Console.WriteLine();

            int S = 0;
            int k = 0;

            for (int i = 0; i < n; i++)
                if (p[i] >= 0 || p[i] % 4 == 0)
                {
                    S += p[i];
                    k++;
                    p[i] = 0;
                }

            Console.WriteLine($"Number = {k}");
            Console.WriteLine($"Sum = {S}");
            Console.WriteLine();
            Console.Write("a[] = {");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{p[i]} , ");
            }
            Console.WriteLine("}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

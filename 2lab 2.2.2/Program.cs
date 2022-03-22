using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            const int n = 24;
            int[] p = new int[n];

            const int nt = 10;
            int low = 1;
            int high = 10;

            for (int i = 0; i < n; i++)
                p[i] = rnd.Next() % 25;
            Console.Write("a[] = {");

            for (int i = 0; i < nt; i++)
            {
                Console.Write($"{p[i]} , ");

            }
            Console.WriteLine("}");
            Console.WriteLine();

            int max = 100;
            int MaxN = 0;
            int min = -100;
            int MinN = 0;
            int k;


            for (int i = 0; i < nt; i++)
            {
                if (p[i] > max)
                {
                    max = p[i];
                    MaxN = i;
                }
                if (p[i] < min)
                {
                    min = p[i];
                    MinN = i;
                }
            }
            Console.WriteLine($"Min = {MaxN}");
            Console.WriteLine($"Max = {MinN}");

            k = (MaxN + MinN)/2;
            Console.WriteLine($"Average = {k}");
            Console.WriteLine();
            Console.ReadKey();
            //  int max = 0;
            // int maxindex = 0;
            //int k;
            //for (int i = 0; i < nt; i++)
            //{
            //  if (p[i] > max)
            //    maxindex = i;
            //}
            //            int minindex = 0;
            //          int min = 0;
            //        for (int i = 0; i < nt; i++)
            //      {
            //        if (p[i] < min)
            //          minindex = i;
            //}
            // k = maxindex + minindex;
            //  Console.WriteLine($"Average = {k}");
            // Console.WriteLine();
            //  Console.ReadKey();
        }
    }
}

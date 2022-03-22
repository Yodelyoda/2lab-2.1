using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lan_2._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rowCount = 4;
            int colCount = 4;

            int[,] ab = new int[rowCount, colCount];
            int Low = 4;
            int High = 45; 

            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                    ab[i, j] = Low + rnd.Next() % (High - Low + 1);

            Console.WriteLine();
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                    Console.Write($"{ab[i, j]} \t");

                Console.WriteLine();
            }
            Console.WriteLine();

            int min, max, S;
            min = 0;
            max = 0;
            for (int i = 0; i < rowCount; i++)
            {
                if (i % 2 != 0) // визначає непарні рядки
                {
                    min = ab[i, 0];
                    for (int j = 1; j < colCount; j++)
                    {
                        if (ab[i, j] < min)
                        {
                            min = ab[i, j];
                          
                        }
                    }
                    max = ab[i, 0];
                    for (int j = 1; j < colCount; j++)
                    {
                        if (ab[i, j] < max)
                        {
                            max = ab[i, j];
                            S = max; max = min; min = S;
                        }
                    }
               

                }
            }

            Console.WriteLine($"Min = {max}");
            Console.WriteLine($"Max = {min}");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}

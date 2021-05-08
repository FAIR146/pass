using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okChamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] year = new int[30];
            int min = int.MaxValue, max = int.MinValue;
            for (int i = 0; i < year.Length; i++)
            {
                year[i] = random.Next(1950, 2020 + 1);
                Console.Write($"{year[i]} ");
                if (year[i] > max)
                {
                    max = year[i];
                }
                if (min > year[i])
                {
                    min = year[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"youngest {max}, oldest {min} ");


            Console.ReadKey();
        }
    }
}

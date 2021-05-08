using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] C = new int[30];
            int minValue = 0;
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = random.Next(10, 35 + 1);
                Console.Write($"{C[i]} ");

                if (C[i] < 25)
                {
                    minValue++;
                }
            }
            Console.WriteLine($": {minValue} ");
            Console.ReadKey();
        }
    }
}

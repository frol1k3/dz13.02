using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void print(params int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Номер {i} число {numbers[i]}");
                }
            }

            print(45, 7, 9, 5, 6, 33, 67, 8);
        }
    }
}

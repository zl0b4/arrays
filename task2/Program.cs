using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int evenSum = 0;
            int oddCount = 0;

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 101);

            evenSum = Array.FindAll(arr, i => i % 2 == 0).ToArray().Sum();
            oddCount = Array.FindAll(arr, i => i % 2 != 0).ToArray().Length;

            Console.WriteLine($"Сумма чётных чисел: {evenSum}");
            Console.WriteLine($"Количество нечётных чисел: {oddCount}");
        }
    }
}

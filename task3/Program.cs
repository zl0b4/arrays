using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoubleMinMax;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            double sum;
            int count;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = RandomExtensions.NextDouble(rand, 1, 10);
                if (arr[i] < 2)
                    arr[i] = 0;
            }
            sum = Array.FindAll(arr, i => i >= 3 && i <= 6).ToArray().Sum();
            count = arr.Where(i => i >= 3 && i <= 6).ToArray().Length;

            Console.WriteLine($"Сумма элементов в диапазаоне от 3 до 6: {sum}");
            Console.WriteLine($"Количество элементов в диапазаоне от 3 до 6: {count}");



        }
    }
}

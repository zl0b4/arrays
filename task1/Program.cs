using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-100, 101);
            Console.WriteLine();
            Console.WriteLine($"Минимальное положительное число: {Array.FindAll(arr, i => i > 0).ToArray().Min()}");
            Console.WriteLine($"Максимальное отрицательное число: {Array.FindAll(arr, i => i < 0).ToArray().Max()}");
        }
    }
}

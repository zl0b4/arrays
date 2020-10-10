using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1,51);

            int min = arr[1];
            for (int i = 3; i < arr.Length; i+=2)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            int max = arr[0];
            for (int i = 2; i < arr.Length; i+=2)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine($"Минимальный элемент с нечётным индексом: {min}");
            Console.WriteLine($"Максимальный элемент с чётным индексом: {max}");
        }
    }
}

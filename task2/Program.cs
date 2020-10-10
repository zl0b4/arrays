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
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-100, 100);
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine($"Минимальное положительное число: {arr.Min(i => i > 0)}");
        }
    }
}

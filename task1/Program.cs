using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoubleMinMax;

namespace task1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random();
            int size = int.Parse(Console.ReadLine());
            double[] arr = new double[size];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = RandomExtensions.NextDouble(rand, -100, 100);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

                
            }
            Console.WriteLine($"Минимальное положительное число: {Array.FindAll(arr, i => i > 0).ToArray().Min()}");
            Console.WriteLine($"Максимальное отрицательное число: {Array.FindAll(arr, i => i < 0).ToArray().Max()}");
        }
    }
}

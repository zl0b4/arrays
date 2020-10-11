using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoubleMinMax;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = int.Parse(Console.ReadLine());

            double[] arr = new double[n];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = RandomExtensions.NextDouble(rand, -4, 8);

            arr = arr.OrderByDescending(i => Math.Abs(i) > 2).ToArray();
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}

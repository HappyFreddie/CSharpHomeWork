using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static int Min(int[] array)
        {
            int value = array[0];
            foreach(int x in array)
            {
                if (x <= value)
                    value = x;
            }
            return value;
        }

        static int Max(int[] array)
        {
            int value = array[0];
            foreach (int x in array)
            {
                if (x >= value)
                    value = x;
            }
            return value;
        }

        static double Average(int[] array)
        {
            int count = 0;
            int sum = 0;
            foreach(int x in array)
            {
                sum += x;
                count++;
            }
            return (double)sum / count;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 10, 0, -2, 58, -5 };
            Console.WriteLine("最小值: " + Min(array));
            Console.WriteLine("最大值: " + Max(array));
            Console.WriteLine("平均值: " + Average(array));
        }
    }
}

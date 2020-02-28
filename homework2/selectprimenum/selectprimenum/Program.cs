using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectprimenum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[101];
            array[2] = 0;
            int count = 0, j = 2;
            while(count < 100)
            {
                for (int i = 1; i < array.Length; i++)
                    if (i % j == 0 & i != j)
                        array[i] = 1;
                for(int i = 1; i < array.Length; i++)
                    if(i > j & array[i] == 0)
                    {
                        j = i;
                        break;
                    }
                count++;
            }
            for (int i = 1; i < array.Length; i++)
                if (array[i] == 0)
                    Console.Write(i + " ");
        }
    }
}

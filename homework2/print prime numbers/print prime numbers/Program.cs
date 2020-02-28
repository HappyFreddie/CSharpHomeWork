using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_prime_numbers
{
    class Program
    {
        static bool Primenum(int n)
        {
            bool flag = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数:");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            while (n < 1)
            {
                Console.WriteLine("请输入大于1的整数");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("其质数因子为:");
           
            while(n != 1)
            {
                if(Primenum(n)
                ){
                    Console.WriteLine(n);
                    break;
                }
                else
                {
                    for(int i = 2; i <= n; i++)
                    {
                        if(n%i==0)
                        {
                            n /= i;
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }
            }

        }
    }
}

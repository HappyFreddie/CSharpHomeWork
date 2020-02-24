using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("输入第一个操作数: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("输入第二个操作数: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("选择操作符:");
                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($"result: {num1}+{num2}=" + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine($"result: {num1}-{num2}=" + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine($"result: {num1}*{num2}=" + (num1 * num2));
                        break;
                    case "/":
                        while (num2 == 0)
                        {
                            Console.WriteLine("请输入非零数：");
                            num2 = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine($"result: {num1}/{num2}=" + (num1 / num2));
                        break;
                }
            }

            catch(FormatException)
            {
                Console.WriteLine("格式错误!");
                return;
            }
            catch(OverflowException)
            {
                Console.WriteLine("数字溢出!");
                return;
            }
        }
    }
}

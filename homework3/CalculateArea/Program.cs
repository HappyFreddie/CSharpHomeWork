using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        abstract class Shape
        {
            public abstract double Area();  // 计算面积
            public abstract void Init(); // 初始数据
        }

        class Rectangle : Shape
        {
            double width, height;
            public Rectangle()
            {
                Init();
            }

            public override double Area()
            {
                return height * width;
            }

            public override void Init()
            {
                while (true)
                {
                    Console.WriteLine("输入矩形的长: ");
                    string heights = Console.ReadLine();
                    Console.WriteLine("输入矩形的宽: ");
                    string widths = Console.ReadLine();
                    if (!double.TryParse(heights, out height) || !double.TryParse(widths, out width))
                    {
                        Console.WriteLine("请输入正确数字!");
                        continue;
                    }
                    break;
                }
            }
        }

        class Square : Shape
        {
            double side;
            private double width;

            public Square()
            {
                Init();
            }

            public override double Area()
            {
                return Math.Pow(side, 2);
            }
            public override void Init()
            {
                while (true)
                {
                    Console.WriteLine("请输入正方形的边长: ");
                    string sides = Console.ReadLine();
                    if (!double.TryParse(sides, out side))
                    {
                        Console.WriteLine("请输入正确数字!");
                        continue;
                    }
                    break;
                }
            }
        }

        class Triangle : Shape
        {
            double side1, side2, side3, p;
            public Triangle()
            {
                Init();
            }

            public override double Area()
            {
                p = (side1 + side2 + side3) / 2;
                return Math.Pow(p * (p - side1) * (p - side2) * (p - side3), 1/2);
            }
            public override void Init()
            {
                while (true)
                {
                    Console.WriteLine("请输入第一条边: ");
                    string side1s = Console.ReadLine();
                    Console.WriteLine("请输入第二条边: ");
                    string side2s = Console.ReadLine();
                    Console.WriteLine("请输入第三条边: ");
                    string side3s = Console.ReadLine();
                        if (!double.TryParse(side1s, out side1) || !double.TryParse(side2s, out side2) || !double.TryParse(side3s, out side3) || side1 + side2 <= side3 || side2 + side3 <= side1 || side1 + side3 <= side2)
                        {
                            Console.WriteLine("请输入正确数字!");
                            continue;
                        }
                    break;
                }
            }
        }

        class Factory
        {
            public static Shape CreateShpae(string name)
            {
                switch (name)
                {
                    case "1": return new Rectangle();
                    case "2": return new Square();
                    case "3": return new Triangle();
                    default: return null;
                }
            }



            static void Main(string[] args)
            {
                double[] areas = new double[10];
                double sum = 0;
                int i = 0;
                while (i < 10)
                {
                    Console.WriteLine("选择形状如下: ");
                    Console.WriteLine("1、矩形 2、正方形 3、三角形");
                    string name = Console.ReadLine();
                    Shape shape = Factory.CreateShpae(name);
                    if (shape != null)
                    {
                        areas[i] = shape.Area();
                        Console.Write("面积为:");
                        Console.WriteLine(shape.Area());
                    }
                    i++;
                }
                foreach (double x in areas)
                    sum += x;
                Console.Write("十个图形总面积为: ");
                Console.Write(sum);
            }
        }
    }
}

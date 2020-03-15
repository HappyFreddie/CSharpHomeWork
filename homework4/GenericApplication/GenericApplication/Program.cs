using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
                head = tail = n;
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void Foreach(Action<T> action)
        {
            Node<T> temp = head;
            while(temp.Next != null)
            {
                action(temp.Data);
                temp = temp.Next;
            }
            action(temp.Data);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> genericList = new GenericList<int>();
            for (int x = 0; x < 10; x++)
                genericList.Add(x);
            // 显示元素
            Console.WriteLine("元素:");
            genericList.Foreach(x => Console.Write(x));
            int max = 0, min = 0;
            Console.WriteLine("最大值:");
            genericList.Foreach(x => { if (max < x) max = x; });
            Console.WriteLine(max);
            Console.WriteLine("最小值:");
            genericList.Foreach(x => { if (min > x) min = x; });
            Console.WriteLine(min);
            int sum = 0;
            Console.WriteLine("求和:");
            genericList.Foreach(x => sum += x);
            Console.WriteLine(sum);
        }
    }
}

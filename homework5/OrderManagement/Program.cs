using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class OrderService
    {
        List<Order> orderlist = new List<Order>(); // 存放完整订单
        int id = 0;
 
        public void Add(string buyer) // 向orderlist里添加新订单
        {
            Console.WriteLine("请输入商品类型的数量:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("输入货品数量，商品名和单价并以逗号分隔:");
                this.orderlist.Add(new Order(this.id, buyer));
                string scan = Console.ReadLine();
                string[] itemdetails = scan.Split(',');
                int number = Convert.ToInt32(itemdetails[0]);
                string name = itemdetails[1];
                double price = Convert.ToDouble(itemdetails[2]);
                this.orderlist[this.id].AddItem(number, name, price);
            }
            id = id + 1;
        }

        public void Delete(int id) // 通过订单号删除
        {
            this.orderlist.RemoveAt(id);
        }

        public void Output() // 输出orderlist列表
        {
            foreach(Order order in orderlist)
            {
                Console.WriteLine(order.ToString());
            }
        }

        public void Modify(int id, int index, int number, string name, double unitprice) // 根据订单号修改
        {
            for(int i = 0; i<this.orderlist.Count; i++)
            {
                if (id == this.orderlist[i].id)
                    this.orderlist[i].ModifyItem(index, number, name, unitprice);
            }
        }

        public List<Order> Inquiry(int id) // 根据订单号查询
        {
            List<Order> orders = new List<Order>();
            var inquiry = from order in this.orderlist
                          where order.id == id
                          select order;

            foreach(Order order in inquiry)
            {
                orders.Add(order);
            }

            return orders;
        }
    }

    class Order : IComparable
    {
        public readonly int id;
        string ordertime { get; set; }
        readonly double orderprice;
        string buyer { get; set; }
        List<OrderItem> itemlist = new List<OrderItem>(); // 存放每个订单的明细

        public Order(int id, string buyer)
        {
            this.id = id;
            this.ordertime = DateTime.Now.ToString();
            this.buyer = buyer;

        }

        public override string ToString()
        {
            string infomation = null;
            double price = 0;
            foreach (OrderItem orderItem in itemlist)
            {
                infomation += orderItem.ToString();
                price += orderItem.totalprice;
            }
            return $"订单号:{this.id},订单日期:{this.ordertime},买家:{this.buyer},订单价格:{price},订单详情:{infomation}";
        }

        public void AddItem(int number, string goodsname, double unitprice)
        {
            OrderItem item = new OrderItem(number, goodsname, unitprice);
            this.itemlist.Add(item);
        }

        public void ModifyItem(int index, int number, string name, double unitprice)
        {
            this.itemlist[index].number = number;
            this.itemlist[index].goodsname = name;
            this.itemlist[index].unitprice = unitprice;
        }

        public void DeleteItem(int index)
        {
            this.itemlist.RemoveAt(index);
        }

        List<OrderItem> InquiryItem(int number,string name,double unitprice )
        {
            var inquiry = from item in this.itemlist
                          where item.number == number && item.goodsname == name && item.unitprice == unitprice
                          orderby item.totalprice
                          select item;
            return inquiry.ToList();
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Order))
            {
                throw new ArgumentException();
            }
            Order od = (Order)obj;
            return this.id.CompareTo(od.id);
        }

        class OrderItem
        {
            public int number { get; set; }
            public string goodsname { get; set; }
            public double unitprice { get; set; }
            public readonly double totalprice;

            public OrderItem(int number, string good, double unitprice)
            {
                this.number = number;
                this.goodsname = good;
                this.unitprice = unitprice;
                this.totalprice = number * unitprice;
            }

            public override string ToString()
            {
                return $"商品名:{this.goodsname},单价:{this.unitprice},购买量:{this.number},该商品总价{this.totalprice}";
            }


        }

        class Program
        {
            static void Main(string[] args)
            {
                OrderService orderService = new OrderService();
                orderService.Add("Freddie");
                orderService.Output();
            }
        }
    } }

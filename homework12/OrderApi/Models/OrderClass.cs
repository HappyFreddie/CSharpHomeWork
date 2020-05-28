using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApi
{


    [Serializable]
    public class Order : IComparable
    {
        Random random = new Random();
        [Key]
        public Int32 Order_ID { get; set; }//订单号
        public DateTime Order_date { get; set; }//下单日期
      
        
        public string Order_custormet_Name { get; set; }//顾客姓名
        public double Order_total_consumption { get; set; }//商品总价
        public List<OrderItem> Orderitem_list { get;set;}
        public int OrderServiceID { get; set; }
        [ForeignKey("OrderServiceID")]
        public OrderService orderService { get; set; }

        public Order() { Orderitem_list = new List<OrderItem>();  }
        public Order(DateTime order_date, double custormer_ID, string order_address, string order_custormet_Name)
        {
            Orderitem_list = new List<OrderItem>();
            Order_date = order_date;
            Order_ID = Generate_Order_ID();//订单编号随机生成
           
            Order_custormet_Name = order_custormet_Name;
            Order_total_consumption = 0;//初始花销为0
        }

        public Order(Int32 order_ID, DateTime order_date, double custormer_ID, string order_address, string order_custormet_Name)
        {
            Orderitem_list = new List<OrderItem>();
            Order_ID = order_ID;
            Order_date = order_date;
            
           
            Order_custormet_Name = order_custormet_Name;
            Order_total_consumption = 0;

        }
        public Order(Int32 order_ID, double custormer_ID, string order_address, string order_custormet_Name)
        {
            Orderitem_list = new List<OrderItem>();
            Order_ID = order_ID;
            Order_date = DateTime.Now;
            
            
            Order_custormet_Name = order_custormet_Name;
            Order_total_consumption = 0;

        }
        public int CompareTo(object obj2)
        {
            Order order2 = obj2 as Order;
            if (order2 == null)
                throw new System.ArgumentException();
            return this.Order_ID.CompareTo(order2.Order_ID);
        }

        public Int32 Generate_Order_ID()//随机生成十位数作为订单ID
        {
            Int32 tmp = 0;
            Random ran = new Random();
            for (int i = 0; i < 6; i++)
            {
                tmp += Convert.ToInt32(ran.Next(10) * Math.Pow(10, i));
                System.Threading.Thread.Sleep(15);
            }
            return tmp;
        }
        public override bool Equals(object obj)
        {

            return obj is Order order &&
                  Order_ID == order.Order_ID;//判断类型和订单号是否相同
        }



        public override string ToString()//输出Order信息
        {
            return "下单日期:" + Order_date + "\n" +
                "订单号:" + Order_ID + "\n" +
                "顾客姓名:" + Order_custormet_Name + "\n" +
           
            "订单总花费:" + Order_total_consumption + "元" + "\n";
        }
        public bool Add_Item(OrderItem item)
        {
            try
            {
                if (!Orderitem_list.Contains(item))
                {
                    Orderitem_list.Add(item);
                    Order_total_consumption += item.total_price;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                throw new Exception("添加商品失败", e);
            }
        }
        public bool Delete_Item(string name_of_item)
        {
            bool flag = false;
            try
            {
                for (int i = 0; i < Orderitem_list.Count; i++)
                {
                    if (Orderitem_list[i].name_of_item == name_of_item)
                    {
                        Orderitem_list.Remove(Orderitem_list[i]);
                        flag = true;
                    }
                }
                return flag;
            }
            catch (Exception e)
            {
                throw new Exception("删除商品失败", e);
            }
        }

        public override int GetHashCode()
        {
            int hashCode = 1064300928;
            hashCode = hashCode * -1521134295 + EqualityComparer<Random>.Default.GetHashCode(random);
            hashCode = hashCode * -1521134295 + Order_ID.GetHashCode();
            hashCode = hashCode * -1521134295 + Order_date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Order_custormet_Name);
            hashCode = hashCode * -1521134295 + Order_total_consumption.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(Orderitem_list);
            return hashCode;
        }
    }

        /*    -------------------                                ----------------------------------------------------------------------------------*/
        public class OrderItem
        {
             [Key]
            public string name_of_item { get; set; }
            public int num_of_item { get; set; }
            public double price_of_item { get; set; }
            public double total_price { get; set; }
            public Int32 Order_ID { get; set; }
            [ForeignKey("Order_ID")]
            public Order order { get; set; }

            public OrderItem(string name_of_item, int num_of_item, double price_of_item)
            {
                this.name_of_item = name_of_item;
                this.num_of_item = num_of_item;
                this.price_of_item = price_of_item;
                this.total_price = price_of_item * num_of_item;
            }
            public OrderItem() { }

            public override bool Equals(object obj)
            {
                return obj is OrderItem item &&
                       name_of_item == item.name_of_item &&
                       num_of_item == item.num_of_item &&
                       price_of_item == item.price_of_item &&
                       total_price == item.total_price &&
                       obj != null;
            }



            public override string ToString()
            {
                return name_of_item + "\t" + price_of_item + "\t" + num_of_item + "\t" + total_price + "元" + "\n";
            }

            public override int GetHashCode()
            {
                int hashCode = 230911192;
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name_of_item);
                hashCode = hashCode * -1521134295 + num_of_item.GetHashCode();
                hashCode = hashCode * -1521134295 + price_of_item.GetHashCode();
                hashCode = hashCode * -1521134295 + total_price.GetHashCode();
                return hashCode;
            }
        }
        /*                     ------------------------------------------------------------------------------------------------------------------------*/




    
}

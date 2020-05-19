using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderManage
{
    [Serializable]
    public class OrderService
    {
        //订单集合
        public static List<Order> orders = new List<Order>();


        //添加订单明细
        public static void AddOrderItem(Order order, OrderItem newOrderItem)
        {
                order.OrderItems.Add(newOrderItem);
        }


        //添加订单
        public static void AddOrder(Order newOrder)
        {
                orders.Add(newOrder);
        }


        //删除订单
        public static bool DeleteOrder(int oldOrderID)
        {
            foreach(Order order in orders)
            {
                if (oldOrderID == order.OrderID)
                {
                    orders.Remove(order);
                    return true;
                }
            }
            return false;
        }


        //修改订单
         public static bool ModifyOrder(int oldOrderID,string customer,string address)
        {
            for (int i = 0; i < orders.Count(); i++)
            {
                if (orders[i].OrderID == oldOrderID)
                {
                    orders[i].Customer = customer;
                    orders[i].Address = address;
                    return true;
                }
            }
            return false;
        }


        //查询订单
        public static bool EnquiryOrder(int orderID,out Order enquiriedOrder)                      //按订单号查询订单
        {
            enquiriedOrder = null;
            foreach (Order order in orders)
            {
                if (order.OrderID == orderID)
                {
                    enquiriedOrder = order;
                    return true;
                }
            }
            return false;
        }

        public static List<Order> EnquiryOrderByItem(string item, out bool isOk)                //按货物名查询
        {
            List<Order> enquiryOrders = new List<Order>();
            isOk = false;
            foreach (Order order in orders)
            {
                foreach (OrderItem orderItem in order.OrderItems)
                {
                    if (orderItem.Item == item)
                    {
                        enquiryOrders.Add(order);
                        isOk = true;
                    }
                }
            }
            return enquiryOrders;
        }

        public static List<Order> EnquiryOrderByCustomer(string customer,out bool isOk)        //按客户名查询
        {
            var selectedOrders = orders.Where(o => o.Customer == customer).OrderBy(o => o.OrderPrice);
            if (selectedOrders != null)
            {
                isOk = true;
                return selectedOrders.ToList<Order>();
            }
            else
            {
                isOk = false;
                return null;
            }
        }


        //将订单排序
        public static void SortedByOrderID()          //按订单号排序
        {
            orders.Sort((o1,o2)=>o1.OrderID-o2.OrderID);
        }


        //将订单序列化为xml文件
        public static void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs= new FileStream("orders.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
        }


        //载入订单文件（反序列化xml文件）
        public static void Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs= new FileStream("orders.xml", FileMode.Open))
            {
                orders = (List<Order>)xmlSerializer.Deserialize(fs);
            }
        }

        public static void Import(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                orders = (List<Order>)xmlSerializer.Deserialize(fs);
            }
        }
    }


    //订单服务异常
    public class OrderServiceException : ApplicationException
    {
        public OrderServiceException(string message) : base(message)
        {
        }
    }
}
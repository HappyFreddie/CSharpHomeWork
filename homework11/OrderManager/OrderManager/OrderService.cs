using OrderManager.EFDbContext;
using OrderManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    class OrderService
    {
        //添加订单明细
        public static void AddOrderItem(Order order,OrderItem newOrderItem)
        {
            using(var context=new Context())
            {
                newOrderItem.OrderID = order.OrderID;
                context.OrderItems.Add(newOrderItem);
                context.SaveChanges();
            }
        }


        //添加订单
        public static void AddOrder(Order newOrder)
        {
            using(var context=new Context())
            {
                context.Orders.Add(newOrder);
                context.SaveChanges();
            }
        }


        //删除订单
        public static bool DeleteOrder(int oldOrderID)
        {
            using(var context=new Context())
            {
                var query = context.Orders.Include("OrderItems").SingleOrDefault(o => o.OrderID == oldOrderID);
                if (query != null)
                {
                    context.Orders.Remove(query);
                    return true;
                }
                return false;
            }
        }


        //修改订单
        public static bool ModifyOrder(int oldOrderID,Order newOrder)
        {
            using(var context=new Context())
            {
                var query = context.Orders.SingleOrDefault(o => o.OrderID == oldOrderID);
                if (query != null)
                {
                    query = newOrder;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }


        //查询订单
        public static bool EnquiryOrder(int orderID, out Order enquiriedOrder)        //按订单号查询
        {
            enquiriedOrder = null;
            using (var context = new Context())
            {
                var query = context.Orders.SingleOrDefault(o => o.OrderID == orderID);
                if (query != null)
                {
                    enquiriedOrder = query;
                    return true;
                }
                return false;
            }
        }


        public static bool EnquiryOrderByItem(string item)        //按货物名查询
        {
            using(var context=new Context())
            {
                var query = context.OrderItems
                    .Where(o => o.Item == item);
                if (query != null)
                {
                    foreach(OrderItem orderItem in query)
                    {
                        Console.WriteLine(orderItem.Order.ToString());
                        foreach (OrderItem sub in orderItem.Order.OrderItems)
                        {
                            Console.WriteLine(sub.ToString());
                        }
                        return true;
                    }
                }
                return false;
            }
        }

        //按客户名查询
        public static  bool EnquriyOrderByCustomer(string customer)
        {
            using(var context=new Context())
            {
                var query = context.Orders
                    .Where(o => o.Customer == customer);
                if (query != null)
                {
                    foreach(Order order in query)
                    {
                        Console.WriteLine(order.ToString());
                        foreach (OrderItem sub in order.OrderItems)
                        {
                            Console.WriteLine(sub.ToString());
                        }
                    }
                    return true;
                }
                return false;
            }
        }


        //查询订单明细
        public static bool EnquiryOrderItem(string item)
        {
            using(var context=new Context())
            {
                var query = context.OrderItems.SingleOrDefault(o => o.Item == item);
                if (query != null)
                {
                    return true;
                }
                return false;
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
}

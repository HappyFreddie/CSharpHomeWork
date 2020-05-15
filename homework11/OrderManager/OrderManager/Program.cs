using OrderManager.EFDbContext;
using OrderManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrderManager.OrderService;

namespace OrderManager
{
    class Program
    {
        static void Main(string[] args)
        { 
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("1.添加订单        2.删除订单        3.修改订单        4.查询订单        5.退出程序");
                Console.Write("请选择：");
                string select = Console.ReadLine();

                switch (select)
                {
                    //添加订单
                    case "1":
                        //创建新订单及新订单的订单详细
                        Console.Write("请输入订单号：");                             //输入新订单信息
                        int newOrderID = int.Parse(Console.ReadLine());
                        Console.Write("请输入客户名字：");
                        string newCustomer = Console.ReadLine();
                        Console.Write("请输入送货地址：");
                        string newAddress = Console.ReadLine();
                        Order newOrder = new Order { OrderID = newOrderID, Customer = newCustomer, Address = newAddress, DateTime = DateTime.Now };        //创建新订单
                        bool isSameOrder = false;          //是否存在相同订单
                        Order enquiriedOrder;
                        isSameOrder = OrderService.EnquiryOrder(newOrderID,out enquiriedOrder);//如果订单不重复，添加新订单到订单集合
                        if (!isSameOrder)
                        {
                            OrderService.AddOrder(newOrder);
                        }
                        else                                                                   //如果订单重复，提示用户
                        {
                            Console.WriteLine("订单已存在！");
                        }

                        //为新订单添加订单明细
                        bool addOrderItemIsOver = false;               //是否结束为新订单添加订单详细                  
                        while (!addOrderItemIsOver)
                        {
                            Console.WriteLine("--------添加订单明细--------");
                            Console.Write("请输入货物名称：");
                            string newOrderItemName = Console.ReadLine();
                            Console.Write("请输入货物单价：");
                            int newUnitOrderItemPrice = int.Parse(Console.ReadLine());
                            Console.Write("请输入货物数量：");
                            int newCount = int.Parse(Console.ReadLine());
                            OrderItem newOrderItem = new OrderItem { Item=newOrderItemName,UnitOrderItemPrice=newUnitOrderItemPrice,Count=newCount};//创建新的订单详细
                            bool isHavingSameOrderItem = false;                    //同一订单是否存在相同的订单详细
                            isHavingSameOrderItem = OrderService.EnquiryOrderItem(newOrderItemName);
                            if (!isHavingSameOrderItem)        //如果订单详细不重复，添加订单详细到该订单的订单详细集合
                            {
                                OrderService.AddOrderItem(newOrder, newOrderItem);
                            }
                            else                               //如果订单详细重复，提示用户
                            {
                                Console.WriteLine("错误：订单明细已存在！");
                            }
                            Console.Write("是否结束添加订单明细？（是：Y，否：N）");    //请用户输入选择是否结束添加订单详细
                            string temp = Console.ReadLine();
                            if (temp == "Y")
                                addOrderItemIsOver = true;
                        }
                        break;


                    //删除订单
                    case "2":
                        try
                        {
                            Console.Write("请输入需要删除订单的订单号：");
                            int deleteOrderID = int.Parse(Console.ReadLine());
                            bool deleteOrderIsOk = OrderService.DeleteOrder(deleteOrderID);    //删除订单是否成功
                            if (!deleteOrderIsOk)                                              //如果不成功,抛出异常
                            {
                                throw new OrderServiceException("错误：需要删除的订单不存在！");
                            }
                        }
                        catch (OrderServiceException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;


                    //修改订单
                    case "3":
                        try
                        {
                            //提示用户输入修改后的信息
                            Console.Write("请输入需要修改订单的订单号：");
                            int modifyOrderID = int.Parse(Console.ReadLine());
                            Console.Write("请输入修改后的客户名字：");
                            string modifiedCustomer = Console.ReadLine();
                            Console.Write("请输入修改后的送货地址：");
                            string modifiedAddress = Console.ReadLine();
                            bool modifyOrderIsOk = OrderService.ModifyOrder(modifyOrderID,        //是否修改成功
                                new Order { OrderID = modifyOrderID, DateTime = DateTime.Now, Customer = modifiedCustomer, Address = modifiedAddress });
                            if (!modifyOrderIsOk)                                                 //如果不成功，抛出异常
                                throw new OrderServiceException("错误：需要修改的订单不存在！");
                        }
                        catch (OrderServiceException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;


                    //查询订单
                    case "4":
                        try
                        {
                            Console.WriteLine("--------查询订单--------");
                            Console.WriteLine("1.按订单号查询        2.按货物名查询        3.按客户名查询");
                            Console.Write("请选择：");
                            string selectEnquiry = Console.ReadLine();
                            bool enquiryIsOk;            //是否查询成功
                            switch (selectEnquiry)
                            {
                                case "1":                                              //按订单号查询
                                    Console.Write("请输入订单号：");
                                    int enquiryID = int.Parse(Console.ReadLine());
                                    Order enquiriedOrderByID;
                                    enquiryIsOk = OrderService.EnquiryOrder(enquiryID, out enquiriedOrderByID);
                                    if (enquiryIsOk)                       //如果查询成功
                                    {
                                        Console.WriteLine(enquiriedOrderByID.ToString());   //输出订单信息
                                        foreach (OrderItem orderItem in enquiriedOrderByID.OrderItems)
                                            Console.WriteLine(orderItem.ToString());        //输出该订单的订单详细信息
                                    }
                                    else
                                        throw new OrderServiceException("错误：订单不存在！");
                                    break;

                                case "2":                                              //按货物名查询
                                    Console.Write("请输入货物名：");
                                    string enquiryItemName = Console.ReadLine();
                                    enquiryIsOk = OrderService.EnquiryOrderByItem(enquiryItemName);
                                    if (!enquiryIsOk)
                                    {
                                        throw new OrderServiceException("错误：订单不存在！");
                                    }
                                    break;

                                case "3":                                              //按客户名查询
                                    Console.Write("请输入客户名:");
                                    string enquiryCustomer = Console.ReadLine();
                                    enquiryIsOk = OrderService.EnquriyOrderByCustomer(enquiryCustomer);
                                    if (!enquiryIsOk)
                                    {
                                        throw new OrderServiceException("错误：订单不存在！");
                                    }
                                    break;
                            }
                        }
                        catch (OrderServiceException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;


                    //退出程序
                    case "5":
                        isRunning = false;
                        break;


                    default:
                        Console.WriteLine("错误：输入无效，请重新输入！");
                        break;
                }
            }
        }
    }
}

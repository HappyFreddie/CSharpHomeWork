using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        public OrderService sample = new OrderService();

        [TestMethod()]
        public void AddTest()
        {
            string[] buyer = { "Freddie", "Bob", "Alan" };
            for (int i = 0; i < buyer.Length; i++)
                this.sample.Add(buyer[i]);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            this.AddTest();
            Console.WriteLine("按索引删除具体订单");
            this.sample.Delete(1);
        }

        [TestMethod()]
        public void OutputTest()
        {
            sample.Output();
        }

        [TestMethod()]
        public void ModifyTest()
        {
            this.AddTest();
            Console.WriteLine("修改订单");
            this.sample.Modify(0, 1, 10, "电视", 1500);
        }

        [TestMethod()]
        public void InquiryTest()
        {
            this.AddTest();
            Console.WriteLine("查询：");
            this.sample.Inquiry(1).ForEach(order => Console.Write(order));
            Console.WriteLine("查询结束");
        }

    }
}
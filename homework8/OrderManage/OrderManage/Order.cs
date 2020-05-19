using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    [Serializable]
    public class Order
    {
        //订单号
        private int orderID;
        public int OrderID { get => orderID; set => orderID = value; }


        //订购日期
        private DateTime dateTime;
        public DateTime DateTime { get => dateTime; set => dateTime = value; }


        //客户姓名
        private string customer;
        public string Customer { get => customer; set => customer = value; }


        //送货地址
        private string address;
        public string Address { get => address; set => address = value; }


        //订单明细
        private List<OrderItem> orderItems = new List<OrderItem>();
        public List<OrderItem> OrderItems { get => orderItems; set => orderItems = value; }


        //订单总金额
        public double OrderPrice
        { get {
                double sum = 0;
                foreach(OrderItem orderItem in OrderItems)
                {
                    sum += orderItem.OrderItemPrice;
                }
                return sum;
              }
        }


        //构造函数
        public Order() { }

        public Order(int orderID, DateTime dateTime, string customer, string address)
        {
            this.OrderID = orderID;
            this.DateTime = dateTime;
            this.Customer = customer;
            this.Address = address;
        }


        //添加订单明细
        public void AddOrderItem(OrderItem orderItem) {
            OrderItems.Add(orderItem);
        }


        //判断订单是否重复
        public override bool Equals(object obj) {
            Order order = obj as Order;
            if (order == null)
                return false;
            return this.OrderID == order.OrderID;
        }


        //显示订单信息
        public override string ToString()
        {
            string orderInfo;
            orderInfo = $"订单号：{this.OrderID.ToString()}," +
                $"订购日期：{this.DateTime.ToString()}," +
                $"客户姓名：{this.Customer}," +
                $"送货地址：{this.Address},";
            return orderInfo;
        }
    }
}
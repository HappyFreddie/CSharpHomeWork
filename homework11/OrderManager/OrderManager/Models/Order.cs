using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Models
{
    class Order
    {
        //订单号
        [Key]
        public int OrderID { get; set; }


        //订购日期
        public DateTime DateTime { get; set; }


        //客户姓名
        public string Customer { get; set; }


        //送货地址
        public string Address { get; set; }


        //订单明细
        public List<OrderItem> OrderItems { get; set; }


        //订单总金额
        public double OrderPrice
        {
            get
            {
                double sum = 0;
                foreach (OrderItem orderItem in OrderItems)
                {
                    sum += orderItem.OrderItemPrice;
                }
                return sum;
            }
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

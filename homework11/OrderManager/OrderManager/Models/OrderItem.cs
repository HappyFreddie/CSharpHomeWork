using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Models
{
    class OrderItem
    {
        //货物名称
        [Key]
        public string Item { get; set; }

        //货物单价
        public double UnitOrderItemPrice { get; set; }

        //数量
        public int Count { get; set; }

        //订单明细总金额
        public double OrderItemPrice { get { return UnitOrderItemPrice * Count; } }

        public int OrderID { get; set; }
        public Order Order { get; set; }

        //显示订单明细
        public override string ToString()
        {
            string orderItemInfo;
            orderItemInfo = $"货物名称：{this.Item}," +
                $"货物单价：{this.UnitOrderItemPrice.ToString()}," +
                $"货物数量：{this.Count.ToString()}," +
                $"货物总金额：{this.OrderItemPrice.ToString()}";
            return orderItemInfo;
        }
    }
}

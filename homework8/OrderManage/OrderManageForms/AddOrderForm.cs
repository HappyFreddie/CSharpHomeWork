using OrderManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManageForms
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        //创建订单
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = int.Parse(txtOrderID.Text);          //订单号
                DateTime dateTime = DateTime.Parse(txtDate.Text);  //订购时间
                string customer = txtCustomerName.Text;              //客户姓名  
                string address = txtAddress.Text;                  //送货地址 

                Order newOrder = new Order(orderID, dateTime, customer, address);     //创建新订单

                bool isSame = false;       //是否存在相同订单
                foreach (Order order in OrderService.orders)        //遍历订单集合
                {
                    if (newOrder == order)
                        isSame = true;
                }
                if (!isSame)               //如果订单不重复，添加新订单到订单列表
                {
                    OrderService.AddOrder(newOrder);
                    OrderService.SortedByOrderID();
                    MessageBox.Show("成功创建订单");
                }
                else                       //如果订单重复，提示用户
                {
                    MessageBox.Show("订单已存在！");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("错误：输入不正确,请重新输入！");
            }
        }

        //创建订单明细
        private void btnAddOrderItem_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = int.Parse(txtOrderItemID.Text);        //添加订单明细订单的订单号
                string orderItemName = txtItem.Text;                 //货物名
                double unitOrderPrice = double.Parse(txtUnitItemPrice.Text);      //货物单价
                int count = int.Parse(txtCount.Text);                             //货物数量

                OrderItem newOrderItem = new OrderItem(orderItemName, unitOrderPrice, count);  //创建新订单明细

                bool isHavingOrder = false;
                bool isHavingSameOrderItem = false;                  //同一订单是否存在相同的订单明细
                foreach (Order order in OrderService.orders)          //遍历订单集合，是否存在该订单号的订单
                {
                    if (orderID == order.OrderID)                    //如果存在该订单号的订单
                    {
                        isHavingOrder = true;
                        foreach (OrderItem orderItem in order.OrderItems)  //遍历该订单号订单的订单明细集合
                        {
                            if (newOrderItem.Equals(orderItem))           //是否存在相同的订单明细
                                isHavingSameOrderItem = true;
                        }
                        if (!isHavingSameOrderItem)                       //如果订单明细不重复，添加订单明细到该订单号订单的订单详细集合
                        {
                            OrderService.AddOrderItem(order, newOrderItem);
                            MessageBox.Show("成功添加订单明细");
                        }
                        else                                              //如果订单详细重复，提示用户
                            MessageBox.Show("错误：订单明细已存在！");
                    }
                }
                if (!isHavingOrder)
                    MessageBox.Show("错误：订单不存在！");
            }
            catch(FormatException fe)
            {
                MessageBox.Show("错误：输入不正确,请重新输入！");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

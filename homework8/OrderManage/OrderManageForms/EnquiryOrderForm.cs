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
    public partial class EnquiryOrderForm : Form
    {
        public EnquiryOrderForm()
        {
            InitializeComponent();
        }

        bool isOK;                        //是否查询成功

        //按订单号查询
        Order enquiriedOrder = new Order();
        private void btnEnquiryByOrderID_Click(object sender, EventArgs e)
        {
            int enquiryID = int.Parse(txtOrderID.Text);
            isOK = OrderService.EnquiryOrder(enquiryID, out enquiriedOrder);
            if (isOK)                   //如果查询成功
            {
                lblDate1.Text = enquiriedOrder.DateTime.ToString();
                lblCustomerName1.Text = enquiriedOrder.Customer;
                lblAdress1.Text = enquiriedOrder.Address;
                lblPrice1.Text = enquiriedOrder.OrderPrice.ToString();
            }
            else                       //如果查询不成功
                MessageBox.Show("错误：订单不存在！");
        }

        private void btnOrderItems1_Click(object sender, EventArgs e)
        {
            OrderItemsForm orderItemsForm = new OrderItemsForm(enquiriedOrder);
            orderItemsForm.Show();
        }


        //按货物名查询
        List<Order> enquiryOrderByItem = new List<Order>();
        private void btnEnquiryByItem_Click(object sender, EventArgs e)
        {
            string enquiryItem = txtItem.Text;
            enquiryOrderByItem = OrderService.EnquiryOrderByItem(enquiryItem, out isOK);
            if (isOK)
            {
                OrdersForm ordersForm = new OrdersForm(enquiryOrderByItem);
                ordersForm.Show();
            }
            else
                MessageBox.Show("错误：订单不存在！");
        }


        //按客户名查询
        List<Order> enquiryOrdersByCustomer = new List<Order>();
        private void btnEnquriyByCustomer_Click(object sender, EventArgs e)
        {
            string enquiryCustomer = txtCumstomerName.Text;
            enquiryOrdersByCustomer = OrderService.EnquiryOrderByCustomer(enquiryCustomer, out isOK);
            if (isOK)
            {
                OrdersForm ordersForm = new OrdersForm(enquiryOrdersByCustomer);
                ordersForm.Show();
            }
            else
            {
                MessageBox.Show("错误：订单不存在！");
            }
        }
    }
}

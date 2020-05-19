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
    public partial class DeleteOrderForm : Form
    {
        public DeleteOrderForm()
        {
            InitializeComponent();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = int.Parse(txtOrderID.Text);

                bool isExisting = OrderService.DeleteOrder(orderID);    //删除订单是否成功
                if (isExisting)                                         //如果成功
                    MessageBox.Show("成功删除订单");
                else                                                    //如果不成功
                    MessageBox.Show("需要删除的订单不存在！");
            }
            catch(FormatException fe)
            {
                MessageBox.Show("错误：输入不正确,请重新输入！");
            }
        }
    }
}

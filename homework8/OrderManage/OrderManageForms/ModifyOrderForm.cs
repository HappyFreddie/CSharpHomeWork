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
    public partial class ModifyOrderForm : Form
    {
        public ModifyOrderForm()
        {
            InitializeComponent();
        }

        private void btnModifyOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int modifyOrderID = int.Parse(txtOrderID.Text);
                string modifyCustomerName = txtModifyCustomerName.Text;
                string modifyAddress = txtModifyAddress.Text;

                bool isOK = OrderService.ModifyOrder(modifyOrderID,      //是否修改成功
                    modifyCustomerName,modifyAddress);
                if (isOK)                                                //如果成功
                    MessageBox.Show("修改订单成功");
                else                                                     //如果不成功
                    MessageBox.Show("错误：需要修改的订单不存在！");
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

namespace OrderManageForms
{
    partial class ModifyOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblModifyOrder = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblModifyCustomerName = new System.Windows.Forms.Label();
            this.txtModifyCustomerName = new System.Windows.Forms.TextBox();
            this.lblModifyAddress = new System.Windows.Forms.Label();
            this.txtModifyAddress = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnModifyOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModifyOrder
            // 
            this.lblModifyOrder.AutoSize = true;
            this.lblModifyOrder.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblModifyOrder.Location = new System.Drawing.Point(368, 9);
            this.lblModifyOrder.Name = "lblModifyOrder";
            this.lblModifyOrder.Size = new System.Drawing.Size(92, 27);
            this.lblModifyOrder.TabIndex = 20;
            this.lblModifyOrder.Text = "修改订单";
            // 
            // lblOrderID
            // 
            this.lblOrderID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrderID.Location = new System.Drawing.Point(67, 92);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(8);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(95, 23);
            this.lblOrderID.TabIndex = 21;
            this.lblOrderID.Text = "订单号";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOrderID.Location = new System.Drawing.Point(185, 92);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(159, 23);
            this.txtOrderID.TabIndex = 22;
            // 
            // lblModifyCustomerName
            // 
            this.lblModifyCustomerName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblModifyCustomerName.Location = new System.Drawing.Point(425, 92);
            this.lblModifyCustomerName.Margin = new System.Windows.Forms.Padding(8);
            this.lblModifyCustomerName.Name = "lblModifyCustomerName";
            this.lblModifyCustomerName.Size = new System.Drawing.Size(129, 23);
            this.lblModifyCustomerName.TabIndex = 23;
            this.lblModifyCustomerName.Text = "修改后的客户姓名";
            // 
            // txtModifyCustomerName
            // 
            this.txtModifyCustomerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModifyCustomerName.Location = new System.Drawing.Point(612, 92);
            this.txtModifyCustomerName.Name = "txtModifyCustomerName";
            this.txtModifyCustomerName.Size = new System.Drawing.Size(159, 23);
            this.txtModifyCustomerName.TabIndex = 24;
            // 
            // lblModifyAddress
            // 
            this.lblModifyAddress.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblModifyAddress.Location = new System.Drawing.Point(425, 185);
            this.lblModifyAddress.Margin = new System.Windows.Forms.Padding(8);
            this.lblModifyAddress.Name = "lblModifyAddress";
            this.lblModifyAddress.Size = new System.Drawing.Size(129, 23);
            this.lblModifyAddress.TabIndex = 27;
            this.lblModifyAddress.Text = "修改后的送货地址";
            // 
            // txtModifyAddress
            // 
            this.txtModifyAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModifyAddress.Location = new System.Drawing.Point(612, 185);
            this.txtModifyAddress.Name = "txtModifyAddress";
            this.txtModifyAddress.Size = new System.Drawing.Size(159, 23);
            this.txtModifyAddress.TabIndex = 28;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(733, 342);
            this.btnExit.Margin = new System.Windows.Forms.Padding(12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 28);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "完成";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnModifyOrder
            // 
            this.btnModifyOrder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModifyOrder.Location = new System.Drawing.Point(281, 250);
            this.btnModifyOrder.Margin = new System.Windows.Forms.Padding(16);
            this.btnModifyOrder.Name = "btnModifyOrder";
            this.btnModifyOrder.Size = new System.Drawing.Size(273, 27);
            this.btnModifyOrder.TabIndex = 40;
            this.btnModifyOrder.Text = "修改订单";
            this.btnModifyOrder.UseVisualStyleBackColor = true;
            this.btnModifyOrder.Click += new System.EventHandler(this.btnModifyOrder_Click);
            // 
            // ModifyOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 391);
            this.Controls.Add(this.btnModifyOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtModifyAddress);
            this.Controls.Add(this.lblModifyAddress);
            this.Controls.Add(this.txtModifyCustomerName);
            this.Controls.Add(this.lblModifyCustomerName);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblModifyOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifyOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModifyOrder;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblModifyCustomerName;
        private System.Windows.Forms.TextBox txtModifyCustomerName;
        private System.Windows.Forms.Label lblModifyAddress;
        private System.Windows.Forms.TextBox txtModifyAddress;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnModifyOrder;
    }
}
namespace OrderManageForms
{
    partial class EnquiryOrderForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOrderItems1 = new System.Windows.Forms.Button();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblAdress1 = new System.Windows.Forms.Label();
            this.lblCustomerName1 = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnquiryByOrderID = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEnquiryByItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEnquriyByCustomer = new System.Windows.Forms.Button();
            this.txtCumstomerName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(16, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 346);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnOrderItems1);
            this.tabPage1.Controls.Add(this.lblPrice1);
            this.tabPage1.Controls.Add(this.lblAdress1);
            this.tabPage1.Controls.Add(this.lblCustomerName1);
            this.tabPage1.Controls.Add(this.lblDate1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnEnquiryByOrderID);
            this.tabPage1.Controls.Add(this.txtOrderID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "按订单号查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOrderItems1
            // 
            this.btnOrderItems1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOrderItems1.Location = new System.Drawing.Point(122, 193);
            this.btnOrderItems1.Name = "btnOrderItems1";
            this.btnOrderItems1.Size = new System.Drawing.Size(159, 26);
            this.btnOrderItems1.TabIndex = 28;
            this.btnOrderItems1.Text = "查看";
            this.btnOrderItems1.UseVisualStyleBackColor = true;
            this.btnOrderItems1.Click += new System.EventHandler(this.btnOrderItems1_Click);
            // 
            // lblPrice1
            // 
            this.lblPrice1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice1.Location = new System.Drawing.Point(118, 163);
            this.lblPrice1.Margin = new System.Windows.Forms.Padding(5);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(163, 23);
            this.lblPrice1.TabIndex = 31;
            this.lblPrice1.Text = "                 . . .";
            // 
            // lblAdress1
            // 
            this.lblAdress1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdress1.Location = new System.Drawing.Point(118, 131);
            this.lblAdress1.Margin = new System.Windows.Forms.Padding(5);
            this.lblAdress1.Name = "lblAdress1";
            this.lblAdress1.Size = new System.Drawing.Size(163, 23);
            this.lblAdress1.TabIndex = 30;
            this.lblAdress1.Text = "                 . . .";
            // 
            // lblCustomerName1
            // 
            this.lblCustomerName1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustomerName1.Location = new System.Drawing.Point(118, 98);
            this.lblCustomerName1.Margin = new System.Windows.Forms.Padding(5);
            this.lblCustomerName1.Name = "lblCustomerName1";
            this.lblCustomerName1.Size = new System.Drawing.Size(163, 23);
            this.lblCustomerName1.TabIndex = 29;
            this.lblCustomerName1.Text = "                 . . .";
            // 
            // lblDate1
            // 
            this.lblDate1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDate1.Location = new System.Drawing.Point(118, 64);
            this.lblDate1.Margin = new System.Windows.Forms.Padding(5);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(163, 23);
            this.lblDate1.TabIndex = 28;
            this.lblDate1.Text = "                 . . .";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(19, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "订单明细";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(19, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "总金额";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "送货地址";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "客户姓名";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "订购日期";
            // 
            // btnEnquiryByOrderID
            // 
            this.btnEnquiryByOrderID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnquiryByOrderID.Location = new System.Drawing.Point(300, 29);
            this.btnEnquiryByOrderID.Name = "btnEnquiryByOrderID";
            this.btnEnquiryByOrderID.Size = new System.Drawing.Size(72, 26);
            this.btnEnquiryByOrderID.TabIndex = 28;
            this.btnEnquiryByOrderID.Text = "查询";
            this.btnEnquiryByOrderID.UseVisualStyleBackColor = true;
            this.btnEnquiryByOrderID.Click += new System.EventHandler(this.btnEnquiryByOrderID_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOrderID.Location = new System.Drawing.Point(122, 31);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(159, 23);
            this.txtOrderID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "订单号";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnEnquiryByItem);
            this.tabPage2.Controls.Add(this.txtItem);
            this.tabPage2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "按货物名查询";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(19, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 46;
            this.label7.Text = "货物名";
            // 
            // btnEnquiryByItem
            // 
            this.btnEnquiryByItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnquiryByItem.Location = new System.Drawing.Point(299, 29);
            this.btnEnquiryByItem.Name = "btnEnquiryByItem";
            this.btnEnquiryByItem.Size = new System.Drawing.Size(72, 26);
            this.btnEnquiryByItem.TabIndex = 41;
            this.btnEnquiryByItem.Text = "查询";
            this.btnEnquiryByItem.UseVisualStyleBackColor = true;
            this.btnEnquiryByItem.Click += new System.EventHandler(this.btnEnquiryByItem_Click);
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtItem.Location = new System.Drawing.Point(122, 31);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(159, 23);
            this.txtItem.TabIndex = 42;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnEnquriyByCustomer);
            this.tabPage3.Controls.Add(this.txtCumstomerName);
            this.tabPage3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(426, 316);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "按客户名查询";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(19, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 61;
            this.label9.Text = "客户名";
            // 
            // btnEnquriyByCustomer
            // 
            this.btnEnquriyByCustomer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnquriyByCustomer.Location = new System.Drawing.Point(298, 29);
            this.btnEnquriyByCustomer.Name = "btnEnquriyByCustomer";
            this.btnEnquriyByCustomer.Size = new System.Drawing.Size(72, 26);
            this.btnEnquriyByCustomer.TabIndex = 56;
            this.btnEnquriyByCustomer.Text = "查询";
            this.btnEnquriyByCustomer.UseVisualStyleBackColor = true;
            this.btnEnquriyByCustomer.Click += new System.EventHandler(this.btnEnquriyByCustomer_Click);
            // 
            // txtCumstomerName
            // 
            this.txtCumstomerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCumstomerName.Location = new System.Drawing.Point(122, 31);
            this.txtCumstomerName.Name = "txtCumstomerName";
            this.txtCumstomerName.Size = new System.Drawing.Size(159, 23);
            this.txtCumstomerName.TabIndex = 57;
            // 
            // EnquiryOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnquiryOrderForm";
            this.Text = "EnquiryOrder";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnOrderItems1;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblAdress1;
        private System.Windows.Forms.Label lblCustomerName1;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnquiryByOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnquiryByItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEnquriyByCustomer;
        private System.Windows.Forms.TextBox txtCumstomerName;
    }
}
namespace OrderManageForms
{
    partial class DeleteOrderForm
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
            this.lblDeleteOrder = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeleteOrder
            // 
            this.lblDeleteOrder.AutoSize = true;
            this.lblDeleteOrder.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeleteOrder.Location = new System.Drawing.Point(142, 9);
            this.lblDeleteOrder.Name = "lblDeleteOrder";
            this.lblDeleteOrder.Size = new System.Drawing.Size(92, 27);
            this.lblDeleteOrder.TabIndex = 20;
            this.lblDeleteOrder.Text = "删除订单";
            // 
            // lblOrderID
            // 
            this.lblOrderID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrderID.Location = new System.Drawing.Point(81, 78);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(8);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(95, 23);
            this.lblOrderID.TabIndex = 21;
            this.lblOrderID.Text = "订单号";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOrderID.Location = new System.Drawing.Point(187, 78);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(159, 23);
            this.txtOrderID.TabIndex = 22;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOrder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(303, 162);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(12);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(60, 28);
            this.btnDeleteOrder.TabIndex = 39;
            this.btnDeleteOrder.Text = "确定";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // DeleteOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblDeleteOrder);
            this.Controls.Add(this.txtOrderID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteOrder;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnDeleteOrder;
    }
}
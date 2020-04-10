namespace CayleyTree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Drawplat = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.l_color = new System.Windows.Forms.Label();
            this.l_y = new System.Windows.Forms.Label();
            this.l_x = new System.Windows.Forms.Label();
            this.l_lper = new System.Windows.Forms.Label();
            this.l_rper = new System.Windows.Forms.Label();
            this.l_langle = new System.Windows.Forms.Label();
            this.l_rangle = new System.Windows.Forms.Label();
            this.l_length = new System.Windows.Forms.Label();
            this.l_recursion = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.HScrollBar();
            this.y = new System.Windows.Forms.HScrollBar();
            this.x = new System.Windows.Forms.HScrollBar();
            this.lper = new System.Windows.Forms.HScrollBar();
            this.rper = new System.Windows.Forms.HScrollBar();
            this.langle = new System.Windows.Forms.HScrollBar();
            this.rangle = new System.Windows.Forms.HScrollBar();
            this.recursion = new System.Windows.Forms.HScrollBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Drawplat.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Drawplat
            // 
            this.Drawplat.Controls.Add(this.button2);
            this.Drawplat.Controls.Add(this.l_color);
            this.Drawplat.Controls.Add(this.l_y);
            this.Drawplat.Controls.Add(this.l_x);
            this.Drawplat.Controls.Add(this.l_lper);
            this.Drawplat.Controls.Add(this.l_rper);
            this.Drawplat.Controls.Add(this.l_langle);
            this.Drawplat.Controls.Add(this.l_rangle);
            this.Drawplat.Controls.Add(this.l_length);
            this.Drawplat.Controls.Add(this.l_recursion);
            this.Drawplat.Controls.Add(this.length);
            this.Drawplat.Controls.Add(this.y);
            this.Drawplat.Controls.Add(this.x);
            this.Drawplat.Controls.Add(this.lper);
            this.Drawplat.Controls.Add(this.rper);
            this.Drawplat.Controls.Add(this.langle);
            this.Drawplat.Controls.Add(this.rangle);
            this.Drawplat.Controls.Add(this.recursion);
            this.Drawplat.Controls.Add(this.button1);
            this.Drawplat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Drawplat.Location = new System.Drawing.Point(0, 0);
            this.Drawplat.Name = "Drawplat";
            this.Drawplat.Size = new System.Drawing.Size(950, 572);
            this.Drawplat.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(788, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // l_color
            // 
            this.l_color.AutoSize = true;
            this.l_color.Location = new System.Drawing.Point(782, 398);
            this.l_color.Name = "l_color";
            this.l_color.Size = new System.Drawing.Size(75, 15);
            this.l_color.TabIndex = 17;
            this.l_color.Text = "画笔颜色:";
            // 
            // l_y
            // 
            this.l_y.AutoSize = true;
            this.l_y.Location = new System.Drawing.Point(785, 348);
            this.l_y.Name = "l_y";
            this.l_y.Size = new System.Drawing.Size(52, 15);
            this.l_y.TabIndex = 16;
            this.l_y.Text = "纵坐标";
            // 
            // l_x
            // 
            this.l_x.AutoSize = true;
            this.l_x.Location = new System.Drawing.Point(785, 303);
            this.l_x.Name = "l_x";
            this.l_x.Size = new System.Drawing.Size(52, 15);
            this.l_x.TabIndex = 15;
            this.l_x.Text = "横坐标";
            // 
            // l_lper
            // 
            this.l_lper.AutoSize = true;
            this.l_lper.Location = new System.Drawing.Point(785, 258);
            this.l_lper.Name = "l_lper";
            this.l_lper.Size = new System.Drawing.Size(97, 15);
            this.l_lper.TabIndex = 14;
            this.l_lper.Text = "左分支长度比";
            // 
            // l_rper
            // 
            this.l_rper.AutoSize = true;
            this.l_rper.Location = new System.Drawing.Point(785, 211);
            this.l_rper.Name = "l_rper";
            this.l_rper.Size = new System.Drawing.Size(97, 15);
            this.l_rper.TabIndex = 13;
            this.l_rper.Text = "右分支长度比";
            // 
            // l_langle
            // 
            this.l_langle.AutoSize = true;
            this.l_langle.Location = new System.Drawing.Point(785, 166);
            this.l_langle.Name = "l_langle";
            this.l_langle.Size = new System.Drawing.Size(82, 15);
            this.l_langle.TabIndex = 12;
            this.l_langle.Text = "左分支角度";
            // 
            // l_rangle
            // 
            this.l_rangle.AutoSize = true;
            this.l_rangle.Location = new System.Drawing.Point(785, 121);
            this.l_rangle.Name = "l_rangle";
            this.l_rangle.Size = new System.Drawing.Size(82, 15);
            this.l_rangle.TabIndex = 11;
            this.l_rangle.Text = "右分支角度";
            // 
            // l_length
            // 
            this.l_length.AutoSize = true;
            this.l_length.Location = new System.Drawing.Point(785, 75);
            this.l_length.Name = "l_length";
            this.l_length.Size = new System.Drawing.Size(52, 15);
            this.l_length.TabIndex = 10;
            this.l_length.Text = "树干长";
            // 
            // l_recursion
            // 
            this.l_recursion.AutoSize = true;
            this.l_recursion.Location = new System.Drawing.Point(785, 32);
            this.l_recursion.Name = "l_recursion";
            this.l_recursion.Size = new System.Drawing.Size(67, 15);
            this.l_recursion.TabIndex = 9;
            this.l_recursion.Text = "递归深度";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(785, 90);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(115, 21);
            this.length.TabIndex = 8;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(785, 363);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(115, 21);
            this.y.TabIndex = 7;
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(785, 318);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(115, 21);
            this.x.TabIndex = 6;
            // 
            // lper
            // 
            this.lper.Location = new System.Drawing.Point(785, 273);
            this.lper.Name = "lper";
            this.lper.Size = new System.Drawing.Size(115, 21);
            this.lper.TabIndex = 5;
            // 
            // rper
            // 
            this.rper.Location = new System.Drawing.Point(785, 226);
            this.rper.Name = "rper";
            this.rper.Size = new System.Drawing.Size(115, 21);
            this.rper.TabIndex = 4;
            // 
            // langle
            // 
            this.langle.Location = new System.Drawing.Point(788, 181);
            this.langle.Name = "langle";
            this.langle.Size = new System.Drawing.Size(112, 21);
            this.langle.TabIndex = 3;
            // 
            // rangle
            // 
            this.rangle.Location = new System.Drawing.Point(785, 136);
            this.rangle.Name = "rangle";
            this.rangle.Size = new System.Drawing.Size(115, 21);
            this.rangle.TabIndex = 2;
            // 
            // recursion
            // 
            this.recursion.Location = new System.Drawing.Point(785, 47);
            this.recursion.Name = "recursion";
            this.recursion.Size = new System.Drawing.Size(115, 21);
            this.recursion.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 572);
            this.Controls.Add(this.Drawplat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Drawplat.ResumeLayout(false);
            this.Drawplat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Drawplat;
        private System.Windows.Forms.HScrollBar length;
        private System.Windows.Forms.HScrollBar y;
        private System.Windows.Forms.HScrollBar x;
        private System.Windows.Forms.HScrollBar lper;
        private System.Windows.Forms.HScrollBar rper;
        private System.Windows.Forms.HScrollBar langle;
        private System.Windows.Forms.HScrollBar rangle;
        private System.Windows.Forms.HScrollBar recursion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label l_color;
        private System.Windows.Forms.Label l_y;
        private System.Windows.Forms.Label l_x;
        private System.Windows.Forms.Label l_lper;
        private System.Windows.Forms.Label l_rper;
        private System.Windows.Forms.Label l_langle;
        private System.Windows.Forms.Label l_rangle;
        private System.Windows.Forms.Label l_length;
        private System.Windows.Forms.Label l_recursion;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}


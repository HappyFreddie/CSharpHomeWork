using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 参数包括递归深度（n）、主干长度（leng）、右分支长度比（per1）、左分支长度比（per2）
 右分支角度（th1）、左分支角度（th2）、画笔颜色（pen）
 */
namespace CayleyTree
{


    public partial class Form1 : Form
    {
        Tree tree;

        public Form1()
        {
            InitializeComponent();
            setInfo(this);
            this.tree = new Tree();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tree.graphics == null)
                tree.graphics = this.Drawplat.CreateGraphics();
            tree.n = this.recursion.Value;
            tree.leng = this.length.Value;
            tree.per1 = this.rper.Value * Math.PI /180;
            tree.per2 = this.lper.Value * Math.PI / 180;
            tree.th1 = this.rangle.Value / 10;
            tree.th2 = this.langle.Value / 10;
            this.Drawplat.Refresh();
            tree.drawCayleyTree(tree.n, this.x.Value, this.y.Value, tree.leng, -Math.PI / 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Brush brush = new SolidBrush(this.colorDialog1.Color);
                tree.pen = new Pen(brush);
            }
        }

        private void setInfo(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                control.Tag = control.Width + ";" + control.Height + ";" + control.Left + ";" + control.Top + ";" + control.Font.Size;
                if (control.Controls.Count > 0)
                    setInfo(control);
            }
        }

        private void setDetail(double x, double y, Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control.Tag != null)
                {
                    string[] tags = control.Tag.ToString().Split(new char[] { ';' });
                    control.Width = Convert.ToInt32(System.Convert.ToDouble(tags[0]) * x);
                    control.Height = Convert.ToInt32(System.Convert.ToDouble(tags[1]) * y);
                    control.Left = Convert.ToInt32(System.Convert.ToDouble(tags[2]) * x);
                    control.Top = Convert.ToInt32(System.Convert.ToDouble(tags[3]) * y);
                    double size = System.Convert.ToDouble(tags[4]) * y;
                    if (control.Controls.Count > 0)
                        setDetail(x, y, control);
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            setDetail(1, 1, this);
        }
    }

    public class Tree
    {
        public Graphics graphics;
        public double th1;
        public double th2;
        public double per1;
        public double per2;
        public double leng;
        public int n;
        public Pen pen;

        public Tree()
        {
            this.graphics = null;
            this.th1 = 30 * Math.PI / 180;
            this.th2 = 20 * Math.PI / 180;
            this.per1 = 0.6;
            this.per2 = 0.7;
            this.leng = 100;
            this.n = 10;
            this.pen = Pens.Blue;
        }

        public Tree(int n, double th1, double th2, double per1, double per2, double leng)
        {
            this.graphics = null;
            this.th1 = th1;
            this.th2 = th2;
            this.per1 = per1;
            this.per2 = per2;
            this.leng = leng;
            this.n = n;
            this.pen = Pens.Blue;
        }

        public void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        public void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(this.pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Craweler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Craweler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label.Text = "正在爬取....";
            richTextBox.Text = "";
            Craweler craweler = new Craweler(textBox.Text);

            Hashtable hashtable = craweler.startCrawl();

            foreach (string s in hashtable.Keys)
            {
                if (richTextBox.Text.Length != 0)
                {
                    richTextBox.Text += '\n';
                }
                richTextBox.Text += (s + "\n" + hashtable[s]);
            }
            label.Text = "爬取完成";
        }
    }
}

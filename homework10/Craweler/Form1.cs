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
using System.Collections;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.ComponentModel.Design;

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
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
            Craweler craweler = new Craweler(textBox.Text);
            List<string> list = craweler.getUrlsList();

            bool rw = false;


            for(int i=0;i<list.Count;i++)
            {
                string t = list[i];
                Thread thread = new Thread(() => craweler.DownLoad(t, this.richTextBox, ref rw));
                thread.Start();
            }
        }
    }
}

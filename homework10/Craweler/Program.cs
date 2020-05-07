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
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Craweler
    {
        private Hashtable urls;
        private string startUrl;
        private int count;
        public List<string> ans;

        public Craweler()
        {
            urls = new Hashtable();
            startUrl = "";
            count = 0;
            ans = new List<string>();
        }

        public Craweler(string s) : this()
        {
            startUrl = s;
        }

        public List<string> getUrlsList()
        {
            urls.Clear();
            Hashtable hashtable = new Hashtable();
            urls[startUrl] = true;
            string w = DownLoad(startUrl);
            if (w == "" || w[0] != '<')
            {
                hashtable[startUrl] = "爬取失败";
            }
            else
            {
                hashtable[startUrl] = "爬取成功";
            }

            List<string> list = Parse(w);
            list.Insert(0, startUrl);
            return list;
        }

        public Hashtable startCrawl()
        {
            Hashtable hashtable = new Hashtable();
            urls[startUrl] = true;
            string w = DownLoad(startUrl,null);
            if(w==""||w[0]!='<')
            {
                hashtable[startUrl] = "爬取失败";
            }
            else
            {
                hashtable[startUrl] = "爬取成功";
            }

            List<string> list = Parse(w);

            foreach(string url in list)
            {
                if((bool)urls[url])
                {
                    continue;
                }
                if(count>10)
                {
                    break;
                }
                else
                {
                    urls[url] = true;
                    string t = DownLoad(url,null);
                    if(t==""||t[0]!='<')
                    {
                        hashtable[url] = "爬取失败";
                    }
                    else
                    {
                        hashtable[url] = "爬取成功";
                    }
                }
            }
            return hashtable;
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count++.ToString() + ".html";
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DownLoad(string url, RichTextBox richTextBox)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                if (richTextBox != null)
                {
                    richTextBox.Text += (url + "\n爬取成功\n");
                }
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (richTextBox != null)
                {
                    richTextBox.Text += (url + "\n爬取失败\n");
                }
                return "";
            }
        }

        public string DownLoad(string url, RichTextBox richTextBox, ref bool i)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                if (richTextBox != null)
                {
                    while(i)
                    {
                        Thread.Sleep(10);
                    }
                    i = true;
                    richTextBox.Text += (url + "\n爬取成功\n");
                    i = false;
                }
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (richTextBox != null)
                {
                    while(i)
                    {
                        Thread.Sleep(10);
                    }
                    i = true;
                    richTextBox.Text += (url + "\n爬取失败\n");
                    i = false;
                }
                return "";
            }
        }

        private List<string> Parse(string html)
        {
            List<string> list = new List<string>();
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (strRef.Length == 0)
                {
                    continue;
                }
                if (urls[strRef] == null)
                {
                    urls[strRef] = false;
                    list.Add(strRef);
                }
            }
            return list;
        }
    }
}

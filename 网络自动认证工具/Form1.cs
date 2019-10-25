/*
Author: Kai Tian

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

using System.Windows.Forms;

namespace 网络自动认证工具
{
    public partial class Form1 : Form
    {
        
        private string username = "";
        private string password = "";
        public string ver_url = "http://10.108.255.249/include/auth_action.php?action=login";
        private Dictionary<string, string> data = new Dictionary<string, string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ip = Local_IP().Trim();
            data.Add("action", "login");
            data.Add("user_ip", ip);
            data.Add("ac_id", "1");
            data.Add("save_me", "0");
            data.Add("ajax", "1");
            //lb_tips.Text = Local_IP();
        }
        private string Local_IP()
        {
            string name = Dns.GetHostName();
            IPAddress[] ipadrlist = Dns.GetHostAddresses(name);
            foreach (IPAddress ipa in ipadrlist)
            {
                if (ipa.AddressFamily == AddressFamily.InterNetwork)
                    return ipa.ToString();
            }
            return "";
        }
        private void timer_autover_Tick(object sender, EventArgs e)
        {
            try
            {
                bool status = NetworkStatusChecker.CheckServeStatus();
                if (!status)
                {
                    Post(ver_url, data);
                }
                
            }
            catch(Exception exp)
            {
                lb_tips.Text = "提示：" + exp.StackTrace.ToString();
            }
        }
        /// <summary>
        /// 指定Post地址使用Get 方式获取全部字符串
        /// </summary>
        /// <param name="url">请求后台地址</param>
        /// <returns></returns>
        public static string Post(string url, Dictionary<string, string> dic)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            #region
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
            byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.username = txb_username.Text.Trim();
            this.password = txb_passwd.Text.Trim();
            
            if (""==this.username || "" == this.password)
            {
                MessageBox.Show("用户名和密码不能为空!");
                return;
            }
            timer_autover.Enabled = true;
            data.Add("username", this.username);
            data.Add("password", this.password);
            string res = Post(ver_url, data);
            res = res.Split(',')[0];
            lb_tips.Text = res;
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.网络自动认证工具.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;

            this.WindowState = FormWindowState.Normal;

            this.网络自动认证工具.Visible = false;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Visible = true;

            this.WindowState = FormWindowState.Normal;

            this.网络自动认证工具.Visible = false;
        }
    }
}

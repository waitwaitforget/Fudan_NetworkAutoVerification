using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//System.Net.ServicePointManager.Expect100Continue = false;
namespace 网络自动认证工具
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
}

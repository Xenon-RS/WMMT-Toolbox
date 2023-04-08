using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WMMT_Toolbox
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            //检查启动文件夹是否存在
            string user_name = System.Environment.UserName; //获取当前系统用户名
            string user_path_1 = @"C:\Users\"; //预先设定头段路径
            string user_path_2 = "AppData\\Local\\WMMT-Toolbox"; //预先设定后段路径
            string user_path_full = Path.Combine(user_path_1, user_name, user_path_2); //组合路径

            if (Directory.Exists(user_path_full))
            {
                Console.WriteLine("用户此前有打开过并创建了用户配置文件，检测OK");
            }
            else
            {
                Console.WriteLine("用户此前没有打开过软件，检测ERROR");
                MessageBox.Show("检测到您为第一次打开软件\n现在需要配置软件使用\n请点击确定以配置\n配置完成后将进入软件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Directory.CreateDirectory(user_path_full); //创建WMMT-Toolbox文件夹
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

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
            // 启动前检查路径
            string startup_path = Application.StartupPath; //启动路径
            string startup_folder = System.IO.Path.GetFileName(Application.StartupPath); //exe当前运行文件夹
            string startup_path_nofolder = startup_path.Replace(startup_folder, ""); //exe运行目录前一个文件夹

            string wmmt_exe_path = System.IO.Path.Combine(startup_path_nofolder, "wmn6r.exe"); //wmn6r.exe的路径
            string wmmt_maxi_path = System.IO.Path.Combine(startup_path_nofolder, "MaxiTerminal\\run.bat"); //MaxiTerminal run.bat的路径（预设）
            string wmmt_ama_path = System.IO.Path.Combine(startup_path_nofolder, "AMCUS\\AMAuthd.exe"); //AMAuthd.exe的路径（预设）
            string wmmt_tp_path = System.IO.Path.Combine(startup_path_nofolder, "TP_MutiPlayer\\TeknoParrotUi.exe"); //TP的路径（预设）

            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径

            //判断卡片文件夹是否存在
            string Card_Folder_Path = Application.StartupPath + "\\Card";
            if (Directory.Exists(Card_Folder_Path))
            {
                Console.WriteLine("卡片文件夹存在");
            }
            else
            {
                Console.WriteLine("卡片文件夹不存在，创建中");
                Directory.CreateDirectory(Card_Folder_Path);
            }

            if(!File.Exists(toolbox_ini_path))
            {
                //没找到 创建一个
                File.Create(toolbox_ini_path).Close();

                //预先设定checkbox的state

                IniFile write_state = new IniFile(toolbox_ini_path);
                write_state.WriteValue("StartUpState", "Maxi_State", "True");
                write_state.WriteValue("StartUpState", "AMA_State", "True");
                write_state.WriteValue("StartUpState", "TP_State", "True");

                DialogResult result = MessageBox.Show("检测到您为第一次启动本工具箱\n请问您是否已经按照工具箱推荐的路径存放本软件？\n若有，则可以直接按照预设配置路径\n若无，则需要进入软件后手动配置", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    //首先先用wmn6r.exe进行初步判断
                    if(File.Exists(wmmt_exe_path))
                    {
                        //判断预设路径是否存在文件

                        //写入预设路径

                        //Maxi Terminal
                        if (!File.Exists(wmmt_maxi_path))
                        {
                            MessageBox.Show("按照预设路径无法找到MaxiTerminal的run.bat文件\n请进入工具箱页面后自行配置路径");
                        }
                        else
                        {
                            //写入到ini
                            IniFile Maxi_Path_Ini = new IniFile(toolbox_ini_path);
                            Maxi_Path_Ini.WriteValue("Paths", "MaxiTerminal", wmmt_maxi_path);
                        }

                        //AMAuthd.exe
                        if (!File.Exists(wmmt_ama_path))
                        {
                            MessageBox.Show("按照预设路径无法找到AMAuthd.exe文件\n请进入工具箱页面后自行配置路径");
                        }
                        else
                        {
                            //写入到ini
                            IniFile AMA_Path_Ini = new IniFile(toolbox_ini_path);
                            AMA_Path_Ini.WriteValue("Paths", "AMAuthd", wmmt_ama_path);
                        }

                        //TP
                        if (!File.Exists(wmmt_tp_path))
                        {
                            MessageBox.Show("按照预设路径无法找到TeknoParrotUi.exe文件\n请进入工具箱页面后自行配置路径");
                        }
                        else
                        {
                            //写入到ini
                            IniFile TP_Path_Ini = new IniFile(toolbox_ini_path);
                            TP_Path_Ini.WriteValue("Paths", "TP", wmmt_tp_path);
                        }
                    }
                    else
                    {
                        MessageBox.Show("按照预设路径无法找到wmn6r.exe\n请问您是否正确按照推荐路径存放本工具箱?", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        File.Delete(toolbox_ini_path); //删除ini以防下次打不开
                        return; //关闭界面
                    }
                }
                else
                {
                    Console.WriteLine("用户选择自行配置路径");
                }
            }
            else
            {
                Console.WriteLine("在工具箱当前目录找到了ini配置文件，跳过检测");
            }
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());
        }
    }
}

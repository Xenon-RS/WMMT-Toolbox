using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Xml;
using SharpCompress.Archives;
using System.Reflection;

namespace WMMT_Toolbox
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();

            //首先获取WMMT Toolbox的路径
            string path2 = System.Environment.UserName;
            string path1, path3;
            path1 = @"C:\Users\";
            path3 = "AppData\\Local\\WMMT-Toolbox\\Path";
            string full_path = Path.Combine(path1, path2, path3);

            //合并Maxi路径
            string maxi_path1 = full_path;
            string maxi_path2 = "Maxi.set";
            string full_maxi_path = Path.Combine(maxi_path1, maxi_path2);

            //合并AMA路径
            string AMA_path1 = full_path;
            string AMA_path2 = "AMA.set";
            string full_AMA_path = Path.Combine(AMA_path1, AMA_path2);

            //合并TP路径
            string TP_path1 = full_path;
            string TP_path2 = "TP.set";
            string full_TP_path = Path.Combine(TP_path1, TP_path2);

            if(File.Exists(full_maxi_path) && File.Exists(full_AMA_path) && File.Exists(full_TP_path))
            {
                //获取Maxi的路径
                foreach (string Maxi_line in File.ReadLines(full_maxi_path))
                {
                    Path_Maxi.Text = Maxi_line;
                }

                //获取AMAuthd的路径
                foreach (string AMA_line in File.ReadLines(full_AMA_path))
                {
                    Path_AMA.Text = AMA_line;
                }

                //获取TP的路径
                foreach (string TP_line in File.ReadLines(full_TP_path))
                {
                    Path_TP.Text = TP_line;
                }

                //删除路径的exe
                string TP_Profiles_path_mid = Path_TP.Text.Replace("\\TeknoParrotUi.exe", "");

                //合并路径
                string TP_Profiles_path = TP_Profiles_path_mid + "\\UserProfiles\\WMMT6R.xml";

                // 读取文本文件
                string fileName = TP_Profiles_path;
                string[] lines = File.ReadAllLines(fileName);

                // 定义要查找的行和替换的内容
                int lineNumber = -1; // -1 表示未找到指定的文本
                string searchText = "      <FieldName>TerminalMode</FieldName>";

                // 查找指定文本的行号
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(searchText))
                    {
                        lineNumber = i;
                        break;
                    }
                }

                if (lineNumber != -1 && lineNumber + 1 < lines.Length)
                {
                    string line = lines[lineNumber + 1];
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(line);
                    XmlNode node = doc.SelectSingleNode("/FieldValue");
                    if (node != null)
                    {
                        string fieldValue = node.InnerText;
                        Console.WriteLine(fieldValue);
                        if (fieldValue == "1")
                        {
                            checkBox_Terminal.Checked = true;
                        }
                        else
                        {
                            checkBox_Terminal.Checked = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }

        //调用管理员权限部分1
        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        //调用管理员权限部分2
        public static void RunAsAdmin(string fileName)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = fileName;
            startInfo.Verb = "runas";
            Process.Start(startInfo);
        }

        string first_time_load = "false";

        private void Form_Main_Load(object sender, EventArgs e)
        {
            string user_name = System.Environment.UserName; //获取当前系统用户名
            string user_path_1 = @"C:\Users\"; //预先设定头段路径
            string user_path_2 = "AppData\\Local\\WMMT-Toolbox\\Path\\"; //预先设定后段路径-1
            string user_path_3 = "AppData\\Local\\WMMT-Toolbox\\StartInfo\\"; //预先设定后段路径-2
            string user_path_full = Path.Combine(user_path_1, user_name, user_path_2); //Path
            string user_startinfo_full = Path.Combine(user_path_1, user_name, user_path_3); //StartInfo

            //Maxi
            string Maxi_path = "Maxi.set";
            string Maxi_path_full = Path.Combine(user_path_1, user_name, user_path_2, Maxi_path); //设定Maxi.set的完整路径

            //AMA
            string AMA_path = "AMA.set";
            string AMA_path_full = Path.Combine(user_path_1, user_name, user_path_2, AMA_path); //设定AMA.set的完整路径

            //TP
            string TP_path = "TP.set";
            string TP_path_full = Path.Combine(user_path_1, user_name, user_path_2, TP_path); //设定TP.set的完整路径

            //Maxi_Start
            string Maxi_Start_path = "Maxi_Start.set";
            string Maxi_Start_path_full = Path.Combine(user_path_1, user_name, user_path_3, Maxi_Start_path); //设定Maxi_Start.set的完整路径

            //AMA_Start
            string AMA_Start_path = "AMA_Start.set";
            string AMA_Start_path_full = Path.Combine(user_path_1, user_name, user_path_3, AMA_Start_path); //设定AMA_Start.set的完整路径

            //TP_Start
            string TP_Start_path = "TP_Start.set";
            string TP_Start_path_full = Path.Combine(user_path_1, user_name, user_path_3, TP_Start_path); //设定TP_Start.set的完整路径

            //Start
            string Start_path = "Start.set";
            string Start_path_full = Path.Combine(user_path_1, user_name, user_path_3, Start_path); //设定Start.set的完整路径


            //检测用户是否第一次启动软件（必须提前检测）
            if (File.Exists(Start_path_full))
            {
                Console.WriteLine("检测到了Start.set文件，跳过该步骤");
            }
            else
            {
                Console.WriteLine("检测不到Start.set文件，需要提示用户设定游戏路径");
                DialogResult dr = MessageBox.Show("检测到您是第一次打开本工具箱，您需要根据指引设定好游戏相关路径后，才可以正常使用软件\n请点击确定以前往设定", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (dr == DialogResult.OK)
                {
                    first_time_load = "true";
                }
            }

            //检测Path路径储存文件前一个文件夹是否存在
            if(Directory.Exists(user_path_full))
            {
                //存在则输出提示
                Console.WriteLine("Path文件夹存在");
            }
            else
            {
                //不存在就创建一个
                Directory.CreateDirectory(user_path_full);
                Directory.CreateDirectory(user_startinfo_full);
            }

            //检测Path文件夹内有没有完整文件
            if(File.Exists(Maxi_path_full) && File.Exists(AMA_path_full) && File.Exists(TP_path_full) && File.Exists(Start_path_full) && File.Exists(Start_path_full) && File.Exists(Maxi_Start_path_full) && File.Exists(AMA_Start_path_full) && File.Exists(TP_Start_path_full))
            {
                Console.WriteLine("文件均存在，可以加载文件内数据");

                //开始加载游戏内数据

                //加载已设定路径
                foreach(string Maxi_Line in File.ReadLines(Maxi_path_full))
                {
                    if(Maxi_Line != "")
                    {
                        Path_Maxi.Text = Maxi_Line;
                    }
                    else
                    {
                        Path_Maxi.Text = "null";
                    }
                }

                foreach (string AMA_Line in File.ReadLines(AMA_path_full))
                {
                    if (AMA_Line != "")
                    {
                        Path_AMA.Text = AMA_Line;
                    }
                    else
                    {
                        Path_AMA.Text = "null";
                    }
                }

                foreach (string TP_Line in File.ReadLines(TP_path_full))
                {
                    if (TP_Line != "")
                    {
                        Path_TP.Text = TP_Line;
                    }
                    else
                    {
                        Path_TP.Text = "null";
                    }
                }
                //路径加载完毕

                //加载启动选项

                //Maxi_Start
                string[] Maxi_lines = File.ReadAllLines(Maxi_Start_path_full);
                string Maxi_Start_line = Maxi_lines[0];

                if (Maxi_Start_line == "Checked")
                {
                    checkBox_maxi.Checked = true;
                    Console.WriteLine(Maxi_Start_line);
                }
                else
                {
                    checkBox_maxi.Checked = false;
                    Console.WriteLine(Maxi_Start_line);
                }

                //AMA_Start
                string[] AMA_lines = File.ReadAllLines(AMA_Start_path_full);
                string AMA_Start_line = AMA_lines[0];

                if (AMA_Start_line == "Checked")
                {
                    checkBox_maxi.Checked = true;
                    Console.WriteLine(AMA_Start_line);
                }
                else
                {
                    checkBox_maxi.Checked = false;
                    Console.WriteLine(AMA_Start_line);
                }

                //TP_Start
                string[] TP_lines = File.ReadAllLines(TP_Start_path_full);
                string TP_Start_line = TP_lines[0];

                if (TP_Start_line == "Checked")
                {
                    checkBox_maxi.Checked = true;
                    Console.WriteLine(TP_Start_line);
                }
                else
                {
                    checkBox_maxi.Checked = false;
                    Console.WriteLine(TP_Start_line);
                }

                //Start
                string[] lines = File.ReadAllLines(Start_path_full);
                string Start_line = TP_lines[0];

                if (Start_line == "Checked")
                {
                    checkBox_maxi.Checked = true;
                    Console.WriteLine(Start_line);
                }
                else
                {
                    checkBox_maxi.Checked = false;
                    Console.WriteLine(Start_line);
                }

                Console.WriteLine("获取启动设定完毕");

            }
            else
            {
                Console.WriteLine("路径文件都不存在，都创建");
                File.Create(Maxi_path_full).Close();        //创建Maxi
                File.Create(AMA_path_full).Close();         //创建AMA
                File.Create(TP_path_full).Close();          //创建TP
                File.Create(Start_path_full).Close();       //创建Start
                File.Create(Maxi_Start_path_full).Close();  //创建Maxi_Start
                File.Create(AMA_Start_path_full).Close();  //创建AMA_Start
                File.Create (TP_Start_path_full).Close();  //创建TP_Start
                Console.WriteLine("创建完毕");

                //预先设定启动选项
                //获取WMMT-Toolbox的路径
                string path2 = System.Environment.UserName;
                string path1, path3;
                path1 = @"C:\Users\";
                path3 = "AppData\\Local\\WMMT-Toolbox\\StartInfo\\";
                string full_path = Path.Combine(path1, path2, path3);

                //一键启动：合并路径 Maxi
                string Maxi_Start_path1 = full_path;
                string Maxi_Start_path2 = "Maxi_Start.set";
                string Maxi_full_Start_path = Path.Combine(Maxi_Start_path1, Maxi_Start_path2);

                //一键启动：合并路径 AMA
                string AMA_Start_path1 = full_path;
                string AMA_Start_path2 = "AMA_Start.set";
                string AMA_full_Start_path = Path.Combine(AMA_Start_path1, AMA_Start_path2);

                //一键启动：合并路径 TP
                string TP_Start_path1 = full_path;
                string TP_Start_path2 = "TP_Start.set";
                string TP_full_Start_path = Path.Combine(TP_Start_path1, TP_Start_path2);

                //一键启动：合并路径 Start
                string Start_path1 = full_path;
                string Start_path2 = "Start.set";
                string full_Start_path = Path.Combine(Start_path1, Start_path2);

                //一键启动：保存状态
                string Maxi_info = "Checked";

                //Maxi写入
                StreamWriter sw_Maxi = new StreamWriter(Maxi_full_Start_path);
                sw_Maxi.WriteLine(Maxi_info);
                sw_Maxi.Close();

                //一键启动：保存状态
                string AMA_info = "Checked";

                //AMA写入
                StreamWriter sw_AMA = new StreamWriter(AMA_full_Start_path);
                sw_AMA.WriteLine(AMA_info);
                sw_AMA.Close();

                //一键启动：保存状态
                string TP_info = "Checked";

                //TP写入
                StreamWriter sw_TP = new StreamWriter(TP_full_Start_path);
                sw_TP.WriteLine(TP_info);
                sw_TP.Close();

                //一键启动：保存状态
                string Start_info = "Unchecked";

                //Start写入
                StreamWriter sw_Start = new StreamWriter(full_Start_path);
                sw_Start.WriteLine(Start_info);
                sw_Start.Close();

                Console.WriteLine(first_time_load);

                if (first_time_load == "true")
                {
                    Form_Path_Select form_Path_Select = new Form_Path_Select();
                    form_Path_Select.ShowDialog();
                }
                else
                {
                    Console.WriteLine("114514");
                }
            }

            

        }

        string check_state = "Checked";

        private void checkBox_maxi_CheckedChanged(object sender, EventArgs e)
        {
            //一键启动：首先获取WMMT-Toolbox的路径
            string path2 = System.Environment.UserName;
            string path1, path3;
            path1 = @"C:\Users\";
            path3 = "AppData\\Local\\WMMT-Toolbox\\StartInfo\\";
            string full_path = Path.Combine(path1, path2, path3);

            //一键启动：合并路径
            string Start_path1 = full_path;
            string Start_path2 = "Maxi_Start.set";
            string full_Start_path = Path.Combine(Start_path1, Start_path2);

            //一键启动：保存状态
            check_state = checkBox_maxi.CheckState.ToString();
            StreamWriter sw = new StreamWriter(full_Start_path);
            sw.WriteLine(check_state);
            sw.Close();
        }

        private void checkBox_AMA_CheckedChanged(object sender, EventArgs e)
        {
            //一键启动：首先获取WMMT-Toolbox的路径
            string path2 = System.Environment.UserName;
            string path1, path3;
            path1 = @"C:\Users\";
            path3 = "AppData\\Local\\WMMT-Toolbox\\StartInfo\\";
            string full_path = Path.Combine(path1, path2, path3);

            //一键启动：合并路径
            string Start_path1 = full_path;
            string Start_path2 = "AMA_Start.set";
            string full_Start_path = Path.Combine(Start_path1, Start_path2);

            //一键启动：保存状态
            check_state = checkBox_AMA.CheckState.ToString();
            StreamWriter sw = new StreamWriter(full_Start_path);
            sw.WriteLine(check_state);
            sw.Close();
        }

        private void checkBox_TP_CheckedChanged(object sender, EventArgs e)
        {
            //一键启动：首先获取WMMT-Toolbox的路径
            string path2 = System.Environment.UserName;
            string path1, path3;
            path1 = @"C:\Users\";
            path3 = "AppData\\Local\\WMMT-Toolbox\\StartInfo\\";
            string full_path = Path.Combine(path1, path2, path3);

            //一键启动：合并路径
            string Start_path1 = full_path;
            string Start_path2 = "TP_Start.set";
            string full_Start_path = Path.Combine(Start_path1, Start_path2);

            //一键启动：保存状态
            check_state = checkBox_TP.CheckState.ToString();
            StreamWriter sw = new StreamWriter(full_Start_path);
            sw.WriteLine(check_state);
            sw.Close();
        }

        private void checkBox_autostart_CheckedChanged(object sender, EventArgs e)
        {
            //一键启动：首先获取WMMT-Toolbox的路径
            string path2 = System.Environment.UserName;
            string path1, path3;
            path1 = @"C:\Users\";
            path3 = "AppData\\Local\\WMMT-Toolbox\\StartInfo\\";
            string full_path = Path.Combine(path1, path2, path3);

            //一键启动：合并路径
            string Start_path1 = full_path;
            string Start_path2 = "Start.set";
            string full_Start_path = Path.Combine(Start_path1, Start_path2);

            //一键启动：保存状态
            check_state = checkBox_autostart.CheckState.ToString();
            StreamWriter sw = new StreamWriter(full_Start_path);
            sw.WriteLine(check_state);
            sw.Close();
        }

        private void button_path_setting_Click(object sender, EventArgs e)
        {
            Form_Path_Select form_Path_Select = new Form_Path_Select();
            form_Path_Select.ShowDialog();
        }

        private void button_Net_Click(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                DialogResult result = MessageBox.Show("该操作需要使用管理员权限\n请接下来给予软件管理员权限\n给予后软件将会重新启动\n然后重新点击“游戏网络快速修复”按钮即可进入界面", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // 如果当前用户不是管理员，则申请管理员权限
                    RunAsAdmin(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    this.Close();
                    return;
                }
            }
            else
            {
                Form_Net form_Net_Fix = new Form_Net();
                form_Net_Fix.ShowDialog();
                Console.WriteLine("已获得管理员权限");
            }
        }

        string TP_path_mid;

        private void checkBox_Terminal_CheckedChanged(object sender, EventArgs e)
        {
            //首先获取WMMTLauncher的路径
            string path2 = System.Environment.UserName;
            string path1, path3;
            path1 = @"C:\Users\";
            path3 = "AppData\\Local\\WMMT-Toolbox\\Path";
            string tp_full_path = Path.Combine(path1, path2, path3);

            //合并TP路径
            string TP_path1 = tp_full_path;
            string TP_path2 = "TP.set";
            string full_TP_path = Path.Combine(TP_path1, TP_path2);

            //获取TP的路径

            foreach (string TP_line in File.ReadLines(full_TP_path))
            {
                TP_path_mid = TP_line;
            }

            //删除路径的exe
            string TP_Profiles_path_mid = TP_path_mid.Replace("\\TeknoParrotUi.exe", "");

            //合并路径
            string TP_Profiles_path = TP_Profiles_path_mid + "\\UserProfiles\\WMMT6R.xml";

            // 读取文本文件
            string fileName = TP_Profiles_path;
            string[] lines = File.ReadAllLines(fileName);

            // 定义要查找的行和替换的内容
            int lineNumber = -1; // -1 表示未找到指定的文本
            string searchText = "      <FieldName>TerminalMode</FieldName>";
            string replaceText;

            if(checkBox_Terminal.Checked == true)
            {
                replaceText = "1";
            }
            else
            {
                replaceText = "0";
            }

            // 查找指定文本的行号
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(searchText))
                {
                    lineNumber = i;
                    break;
                }
            }

            // 如果找到了指定文本，则在其下一行进行替换操作
            if (lineNumber != -1 && lineNumber + 1 < lines.Length)
            {
                string line = lines[lineNumber + 1];
                string pattern = @"<FieldValue>\d</FieldValue>";
                string newValue = $"<FieldValue>{replaceText}</FieldValue>";
                string newLine = Regex.Replace(line, pattern, newValue);
                lines[lineNumber + 1] = newLine;
                File.WriteAllLines(fileName, lines);
            }
            else
            {
                Console.WriteLine("修改终端机选项时修改失败");
            }

        }

        private void developer_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_About about = new Form_About();
            about.ShowDialog();
        }

        private void button_game_start_Click(object sender, EventArgs e)
        {
            //启动Maxi
            if (checkBox_maxi.Checked == true && Path_Maxi.Text != null)
            {
                string Maxi_line_1 = Path_Maxi.Text;
                Process pro = new Process();
                FileInfo file = new FileInfo(Maxi_line_1);
                pro.StartInfo.WorkingDirectory = file.DirectoryName;
                pro.StartInfo.FileName = Maxi_line_1;
                pro.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
                pro.StartInfo.CreateNoWindow = false;
                pro.Start();
            }
            else
            {
                Console.WriteLine("用户选择不启动maxi");
            }

            //启动AMA
            if (checkBox_AMA.Checked == true && Path_AMA.Text != null)
            {
                string AMA_line_1 = Path_AMA.Text;
                Process pro = new Process();
                FileInfo file = new FileInfo(AMA_line_1);
                pro.StartInfo.WorkingDirectory = file.DirectoryName;
                pro.StartInfo.FileName = AMA_line_1;
                pro.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
                pro.StartInfo.CreateNoWindow = false;
                pro.Start();
            }
            else
            {
                Console.WriteLine("用户选择不启动AMA");
            }

            //启动TP
            if (checkBox_TP.Checked == true && Path_TP.Text != null)
            {
                string TP_line_1 = Path_TP.Text;
                Process pro = new Process();
                FileInfo file = new FileInfo(TP_line_1);
                pro.StartInfo.WorkingDirectory = file.DirectoryName;
                pro.StartInfo.FileName = TP_line_1;
                pro.StartInfo.CreateNoWindow = false;
                pro.Start();
            }
            else
            {
                Console.WriteLine("用户选择不启动TP");
            }

            //如果全都是false
            if (checkBox_maxi.Checked == false && checkBox_AMA.Checked == false && checkBox_TP.Checked == false)
            {
                MessageBox.Show("您没有勾选任何启动选项，因此什么都不会启动");
            }
        }

        private void button_bug_fixer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还在开发捏~");
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Net_fix_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                DialogResult result = MessageBox.Show("该操作需要使用管理员权限\n请接下来给予软件管理员权限\n给予后软件将会重新启动\n然后重新点击“游戏网络快速修复”按钮即可进入界面", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // 如果当前用户不是管理员，则申请管理员权限
                    RunAsAdmin(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    this.Close();
                    return;
                }
            }
            else
            {
                Form_Net form_Net_Fix = new Form_Net();
                form_Net_Fix.ShowDialog();
                Console.WriteLine("已获得管理员权限");
            }
        }

        private void Fixer_Normal_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Normal_Fixer form_Normal_Fixer = new Form_Normal_Fixer();
            form_Normal_Fixer.ShowDialog();
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            //解压：首先获取WMMTLauncher的路径
            string path2 = System.Environment.UserName;
            string path1, path3;
            path1 = @"C:\Users\";
            path3 = "AppData\\Local\\WMMT-Toolbox\\RES";
            string full_path = Path.Combine(path1, path2, path3);

            //解压：用Readme做判断
            string UNZIP_path1 = full_path;
            string UNZIP_path2 = "Readme.txt";
            string full_UNZIP_path = Path.Combine(UNZIP_path1, UNZIP_path2);

            //解压：RES
            string RES_path1 = full_path;
            string RES_path2 = "RES.7z";
            string full_RES_path = Path.Combine(RES_path1, RES_path2);

            //判断文件夹是否存在，没有就创建
            DirectoryInfo directoryInfo = new DirectoryInfo(full_path);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            //解压分辨率文件
            if (System.IO.File.Exists(full_UNZIP_path))
            {
                Console.WriteLine("找到了分辨率文件");
            }
            else
            {
                Console.WriteLine("没找到分辨率文件");

                //从启动器中抽取RES文件
                BufferedStream inStream = null;
                FileStream outStream = null;
                try
                {
                    Assembly asm = Assembly.GetExecutingAssembly();
                    inStream = new BufferedStream(asm.GetManifestResourceStream("WMMT_Toolbox.Files.RES.7z"));
                    outStream = new FileStream(full_RES_path, FileMode.Create, FileAccess.Write);

                    byte[] buffer = new byte[1024];
                    int length;

                    while ((length = inStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        outStream.Write(buffer, 0, length);
                    }
                    outStream.Flush();
                }
                finally
                {
                    if (outStream != null)
                    {
                        outStream.Close();
                    }
                    if (inStream != null)
                    {
                        inStream.Close();
                    }
                }
                //抽取END

                //解压
                MessageBox.Show("由于您是第一次使用分辨率修改，请等待启动器部署完毕\n部署完毕后将自动弹出分辨率修改窗口");
                SharpCompress.Readers.ReaderOptions options = new SharpCompress.Readers.ReaderOptions();
                options.ArchiveEncoding.Default = Encoding.GetEncoding("UTF-8");
                IArchive Archive = ArchiveFactory.Open(full_RES_path, options);
                foreach (IArchiveEntry ArchiveEntry in Archive.Entries)
                {
                    if (!ArchiveEntry.IsDirectory)
                    {
                        ArchiveEntry.WriteToDirectory(full_path, new SharpCompress.Common.ExtractionOptions { ExtractFullPath = true, Overwrite = true });
                    }
                }

            }

            //打开窗口
            Forms.Form_RES res = new Forms.Form_RES();
            res.ShowDialog();
        }

        private void res_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //解压：首先获取WMMTLauncher的路径
            string path2 = System.Environment.UserName;
            string path1, path3;
            path1 = @"C:\Users\";
            path3 = "AppData\\Local\\WMMT-Toolbox\\RES";
            string full_path = Path.Combine(path1, path2, path3);

            //解压：用Readme做判断
            string UNZIP_path1 = full_path;
            string UNZIP_path2 = "Readme.txt";
            string full_UNZIP_path = Path.Combine(UNZIP_path1, UNZIP_path2);

            //解压：RES
            string RES_path1 = full_path;
            string RES_path2 = "RES.7z";
            string full_RES_path = Path.Combine(RES_path1, RES_path2);

            //判断文件夹是否存在，没有就创建
            DirectoryInfo directoryInfo = new DirectoryInfo(full_path);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            //解压分辨率文件
            if (System.IO.File.Exists(full_UNZIP_path))
            {
                Console.WriteLine("找到了分辨率文件");
            }
            else
            {
                Console.WriteLine("没找到分辨率文件");

                //从启动器中抽取RES文件
                BufferedStream inStream = null;
                FileStream outStream = null;
                try
                {
                    Assembly asm = Assembly.GetExecutingAssembly();
                    inStream = new BufferedStream(asm.GetManifestResourceStream("WMMT_Toolbox.Files.RES.7z"));
                    outStream = new FileStream(full_RES_path, FileMode.Create, FileAccess.Write);

                    byte[] buffer = new byte[1024];
                    int length;

                    while ((length = inStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        outStream.Write(buffer, 0, length);
                    }
                    outStream.Flush();
                }
                finally
                {
                    if (outStream != null)
                    {
                        outStream.Close();
                    }
                    if (inStream != null)
                    {
                        inStream.Close();
                    }
                }
                //抽取END

                //解压
                MessageBox.Show("由于您是第一次使用分辨率修改，请等待启动器部署完毕\n部署完毕后将自动弹出分辨率修改窗口");
                SharpCompress.Readers.ReaderOptions options = new SharpCompress.Readers.ReaderOptions();
                options.ArchiveEncoding.Default = Encoding.GetEncoding("UTF-8");
                IArchive Archive = ArchiveFactory.Open(full_RES_path, options);
                foreach (IArchiveEntry ArchiveEntry in Archive.Entries)
                {
                    if (!ArchiveEntry.IsDirectory)
                    {
                        ArchiveEntry.WriteToDirectory(full_path, new SharpCompress.Common.ExtractionOptions { ExtractFullPath = true, Overwrite = true });
                    }
                }

            }

            //打开窗口
            Forms.Form_RES res = new Forms.Form_RES();
            res.ShowDialog();
        }

        private void card_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还在开发捏~");
        }

        private void maxiTerminal_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还在开发捏~");
        }

        private void teknoParrot_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还在开发捏~");
        }

        private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void About_Software_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Form_About_Software form_About_Software = new Forms.Form_About_Software();
            form_About_Software.ShowDialog();
        }
    }
}

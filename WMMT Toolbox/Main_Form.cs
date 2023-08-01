using IWshRuntimeLibrary;
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;
using WMMT_Toolbox.Forms;
using XmlHelper;

namespace WMMT_Toolbox
{
    public partial class Main_Form : Form
    {

        string Card_Folder_Path = Application.StartupPath + "\\Card";

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            //加载卡片
            LoadCardsIntoComboBox();

            //读取路径
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径

            IniFile read_ini = new IniFile(toolbox_ini_path);
            string MaxiTerminal_Paths = read_ini.ReadValue("Paths", "MaxiTerminal");
            string AMA_Paths = read_ini.ReadValue("Paths", "AMAuthd");
            string TP_Paths = read_ini.ReadValue("Paths", "TP");

            //投放到Textbox
            textBox_Maxi.Text = MaxiTerminal_Paths;
            textBox_AMA.Text = AMA_Paths;
            textBox_TP.Text = TP_Paths;

            //读取checkbox的状态并投放到checkbox
            IniFile read_state = new IniFile(toolbox_ini_path);
            string Maxi_Start_state = read_state.ReadValue("StartUpState", "Maxi_State");
            string AMA_Start_state = read_state.ReadValue("StartUpState", "AMA_State");
            string TP_Start_state = read_state.ReadValue("StartUpState", "TP_State");

            //转bool为string后投放
            checkBox_Maxi_Start.Checked = Convert.ToBoolean(Maxi_Start_state);
            checkBox_AMA_Start.Checked = Convert.ToBoolean(AMA_Start_state);
            checkBox_TP_Start.Checked = Convert.ToBoolean(TP_Start_state);

            //读取TP的UserProfiles
            string TP_User_XML_Path = TP_Paths.Replace("TeknoParrotUi.exe", "UserProfiles\\WMMT6R.xml");
            if(System.IO.File.Exists(TP_User_XML_Path))
            {
                checkBox_Terminal_Mode.Enabled = true;
                //读取终端机中选项
                XmlManager xmlManager = new XmlManager(TP_User_XML_Path);
                string terminalMode = xmlManager.ReadXmlFieldValue("TerminalMode");
                Console.WriteLine(terminalMode);
                if(terminalMode == "1")
                {
                    checkBox_Terminal_Mode.Checked = true;
                }
                else
                {
                    checkBox_Terminal_Mode.Checked = false;
                }
            }
            else
            {
                checkBox_Terminal_Mode.Enabled = false;
            }
        }

        private void LoadCardsIntoComboBox()
        {
            comboBox_Cards.Items.Clear();

            // 加载卡片到 ComboBox
            string[] cardFiles = Directory.GetFiles(Card_Folder_Path, "*.ini");

            foreach (string filePath in cardFiles)
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                comboBox_Cards.Items.Add(fileName);
            }
        }

        private void button_Maxi_Select_Click(object sender, EventArgs e)
        {
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径

            OpenFileDialog open_file_Maxi = new OpenFileDialog();
            open_file_Maxi.Title = "请选择MaxiTerminal的run.bat文件";
            open_file_Maxi.InitialDirectory = Application.StartupPath;
            open_file_Maxi.Multiselect = false;
            open_file_Maxi.Filter = "bat文件(*.bat)|*.bat";

            if(open_file_Maxi.ShowDialog() == DialogResult.OK)
            {
                IniFile write_Maxi = new IniFile(toolbox_ini_path);
                write_Maxi.WriteValue("Paths", "MaxiTerminal", open_file_Maxi.FileName);
                textBox_Maxi.Text = open_file_Maxi.FileName;
            }
            else
            {
                MessageBox.Show("请选择至少一个正确的文件！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_AMA_Select_Click(object sender, EventArgs e)
        {
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径

            OpenFileDialog open_file_AMA = new OpenFileDialog();
            open_file_AMA.Title = "请选择游戏本体内，AMCUS文件夹中的AMAuthd.exe文件";
            open_file_AMA.InitialDirectory = Application.StartupPath;
            open_file_AMA.Multiselect = false;
            open_file_AMA.Filter = "exe文件(*.exe)|*.exe";

            if (open_file_AMA.ShowDialog() == DialogResult.OK)
            {
                IniFile write_AMA = new IniFile(toolbox_ini_path);
                write_AMA.WriteValue("Paths", "AMAuthd", open_file_AMA.FileName);
                textBox_AMA.Text = open_file_AMA.FileName;
            }
            else
            {
                MessageBox.Show("请选择至少一个正确的文件！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_TP_Select_Click(object sender, EventArgs e)
        {
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径

            OpenFileDialog open_file_TP = new OpenFileDialog();
            open_file_TP.Title = "请选择鹦鹉模拟器 —— TeknoParrotUi.exe文件";
            open_file_TP.InitialDirectory = Application.StartupPath;
            open_file_TP.Multiselect = false;
            open_file_TP.Filter = "exe文件(*.exe)|*.exe";

            if (open_file_TP.ShowDialog() == DialogResult.OK)
            {
                IniFile write_TP = new IniFile(toolbox_ini_path);
                write_TP.WriteValue("Paths", "TP", open_file_TP.FileName);
                textBox_TP.Text = open_file_TP.FileName;
            }
            else
            {
                MessageBox.Show("请选择至少一个正确的文件！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Create_Ink_Click(object sender, EventArgs e)
        {
            // 创建快捷方式
            string shortcutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "WMMT-Toolbox.lnk");
            IWshShortcut shortcut = (IWshShortcut)new WshShell().CreateShortcut(shortcutPath);
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            shortcut.IconLocation = Application.ExecutablePath;
            shortcut.Save();

            if(System.IO.File.Exists(shortcutPath))
            {
                MessageBox.Show("创建快捷方式成功，请到桌面查看");
            }
            else
            {
                MessageBox.Show("创建失败，请您手动创建");
            }
        }

        private void button_Start_Game_Click(object sender, EventArgs e)
        {
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径

            //以下为处理卡文件事件
            if (comboBox_Cards.Text == "留空则使用当前卡片")
            {
                Console.WriteLine("用户不需要更换卡片");
            }
            else
            {
                Console.WriteLine("用户需要更换卡片");

                //获取选择卡片的名字与存放卡片的文件夹中的文件路径
                string Card_Select = comboBox_Cards.Text;
                string Card_Name = Card_Select + ".ini";
                string Card_Folder_Include_Name = Card_Folder_Path + "\\" + Card_Name; //源文件路径

                //设置目标文件路径
                IniFile Read_AMA = new IniFile(toolbox_ini_path);
                string AMA = Read_AMA.ReadValue("Paths", "AMAuthd");
                string Card_INI = AMA.Replace("\\AMCUS\\AMAuthd.exe", "\\card.ini");
                string Card_In_Game_Folder_Name = Card_INI; //目标文件路径
                Console.WriteLine(Card_In_Game_Folder_Name);
                System.IO.File.Copy(Card_Folder_Include_Name, Card_In_Game_Folder_Name, true); //复制过去并覆盖
            }

            //以下为处理游戏启动事件

            IniFile Read_Paths = new IniFile(toolbox_ini_path);
            string Maxi_Path = Read_Paths.ReadValue("Paths", "MaxiTerminal");
            string AMA_Path = Read_Paths.ReadValue("Paths", "AMAuthd");
            string TP_Path = Read_Paths.ReadValue("Paths", "TP");

            if(Maxi_Path == "" && AMA_Path == "" && TP_Path == "")
            {
                MessageBox.Show("您并没有配置完成游戏启动路径，请检查路径是否配置完成！");
                return;
            }
            else
            {
                if (checkBox_Maxi_Start.Checked == true)
                {
                    // 检测是否已启动
                    string processName = "Maxi Terminal";
                    bool isMaxiTerminalRunning = false;

                    Process[] processes = Process.GetProcesses();
                    foreach (Process process in processes)
                    {
                        if (process.MainWindowTitle.Contains(processName))
                        {
                            isMaxiTerminalRunning = true;
                            break;
                        }
                    }

                    if (isMaxiTerminalRunning)
                    {
                        Console.WriteLine($"{processName} 正在运行，不启动");
                    }
                    else
                    {
                        Console.WriteLine($"{processName} 不在运行，启动...");

                        // 启动Maxi Terminal
                        string Maxi_Path_Start = Maxi_Path;
                        Process pro = new Process();
                        FileInfo file = new FileInfo(Maxi_Path_Start);

                        pro.StartInfo.WorkingDirectory = file.DirectoryName;
                        pro.StartInfo.FileName = "run.bat"; // 使用cmd.exe作为要运行批处理文件的进程
                        pro.StartInfo.Arguments = $"/k title Maxi Terminal"; // 使用/k保持cmd窗口打开，并设置自定义标题

                        pro.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
                        pro.StartInfo.CreateNoWindow = false;

                        pro.Start();
                    }
                }
                else
                {
                    Console.WriteLine("用户选择不启动MaxiTerminal");
                }


                if (checkBox_AMA_Start.Checked == true)
                {
                    // 检测是否已启动
                    string processName = AMA_Path;
                    bool isAMARunning = false;

                    Process[] processes = Process.GetProcesses();
                    foreach (Process process in processes)
                    {
                        if (process.MainWindowTitle.Contains(processName))
                        {
                            isAMARunning = true;
                            break;
                        }
                    }

                    if(isAMARunning)
                    {
                        Console.WriteLine($"{processName} 正在运行，不启动");
                    }
                    else
                    {
                        Console.WriteLine($"{processName} 不在运行，启动...");

                        //启动AMAuthd.exe
                        string AMA_exeFilePath = AMA_Path; // 设置 AMAuthd.exe 文件的完整路径
                        Process AMA_process = new Process();
                        AMA_process.StartInfo.FileName = AMA_exeFilePath; // 将完整路径传递给 FileName 属性
                        AMA_process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                        AMA_process.Start();
                    }
                }
                else
                {
                    Console.WriteLine("用户选择不启动AMAuthd.exe");
                }
                
                if(checkBox_TP_Start.Checked == true)
                {
                    if(checkBox_Maxi_Start.Checked == false || checkBox_AMA_Start.Checked == false)
                    {
                        DialogResult warning = MessageBox.Show("Maxi Terminal 与 AMAuthd.exe 是游戏联网的关键程序\n您确定不启动他们？\n缺少一个都将导致游戏无法联网", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(warning == DialogResult.Yes)
                        {
                            //启动TP模拟器（直接启动）
                            string TP_exeFilePath = TP_Path; // 设置 TeknoParrotUi.exe 文件的完整路径
                            string arguments = ""; // 设置启动参数（默认空的）

                            //根据用户选择状态是否调用参数启动
                            if (checkBox_direct_start.Checked)
                            {
                                arguments = "--profile=WMMT6R.xml";
                            }
                            else
                            {
                                arguments = "";
                            }

                            Process TP_process = new Process();
                            TP_process.StartInfo.FileName = TP_exeFilePath;
                            TP_process.StartInfo.Arguments = arguments;
                            TP_process.StartInfo.WindowStyle = ProcessWindowStyle.Normal; // 设置为正常启动
                            TP_process.Start();
                            TP_process.WaitForExit();

                            // 等待TeknoParrotUi.exe进程退出
                            TP_process.WaitForExit();

                            // 关闭标题名为"Maxi Terminal"的进程
                            if (!CloseProcessByTitle("Maxi Terminal"))
                            {
                                MessageBox.Show("无法自动关闭\"Maxi Terminal\"\n请检查您的\"Maxi Terminal\"窗口标题是否为\"Maxi Terminal\"\n您可以编辑\"Maxi Terminal\"文件夹中的\"run.bat\"文件\n并在\"node index.js\"这一行代码的上面一行写入\"title Maxi Terminal\"以使\"Maxi Terminal\"的标题正确", "未找到Maxi Terminal的进程", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            // 关闭标题名为"AMAuthd.exe"的进程
                            if (!CloseProcessByTitle("AMAuthd.exe"))
                            {
                                MessageBox.Show("无法自动关闭\"AMAuthd.exe\"\n", "未找到AMAuthd.exe的进程", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        //启动TP模拟器（直接启动）
                        string TP_exeFilePath = TP_Path; // 设置 TeknoParrotUi.exe 文件的完整路径
                        string arguments = ""; // 设置启动参数（默认空的）

                        //根据用户选择状态是否调用参数启动
                        if (checkBox_direct_start.Checked)
                        {
                            arguments = "--profile=WMMT6R.xml";
                        }
                        else
                        {
                            arguments = "";
                        }

                        Process TP_process = new Process();
                        TP_process.StartInfo.FileName = TP_exeFilePath;
                        TP_process.StartInfo.Arguments = arguments;
                        TP_process.StartInfo.WindowStyle = ProcessWindowStyle.Normal; // 设置为正常启动
                        TP_process.Start();
                        TP_process.WaitForExit();

                        // 等待TeknoParrotUi.exe进程退出
                        TP_process.WaitForExit();

                        // 关闭标题名为"Maxi Terminal"的进程
                        if (!CloseProcessByTitle("Maxi Terminal"))
                        {
                            MessageBox.Show("无法自动关闭\"Maxi Terminal\"\n请检查您的\"Maxi Terminal\"窗口标题是否为\"Maxi Terminal\"\n您可以编辑\"Maxi Terminal\"文件夹中的\"run.bat\"文件\n并在\"node index.js\"这一行代码的上面一行写入\"title Maxi Terminal\"以使\"Maxi Terminal\"的标题正确", "未找到Maxi Terminal的进程", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // 关闭标题名为"AMAuthd.exe"的进程
                        if (!CloseProcessByTitle("AMAuthd.exe"))
                        {
                            MessageBox.Show("无法自动关闭\"AMAuthd.exe\"\n", "未找到AMAuthd.exe的进程", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("您必须勾选此选项：启动鹦鹉模拟器，才可以启动游戏！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 根据窗口标题关闭进程
        private bool CloseProcessByTitle(string processTitle)
        {
            bool processFound = false;

            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.MainWindowTitle.Contains(processTitle))
                {
                    try
                    {
                        process.CloseMainWindow();
                        process.WaitForExit(5000); // 等待进程最多5秒钟退出
                        if (!process.HasExited)
                        {
                            process.Kill(); // 如果进程未能在5秒内正常退出，直接终止进程
                        }

                        processFound = true;
                    }
                    catch (Exception)
                    {
                        // 处理关闭进程的异常
                    }
                }
            }

            return processFound;
        }

        private void checkBox_Maxi_Start_CheckedChanged(object sender, EventArgs e)
        {          
             checkBox_Change_Write_ToIni("StartUpState", "Maxi_State", checkBox_Maxi_Start.Checked);
        }

        private void checkBox_Change_Write_ToIni(string type, string value, bool state)
        {
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径
            IniFile write_state = new IniFile(toolbox_ini_path);
            write_state.WriteValue(type, value, state.ToString()); //bool必须要转string才可以写入
        }

        private void checkBox_AMA_Start_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Change_Write_ToIni("StartUpState", "AMA_State", checkBox_AMA_Start.Checked);
        }

        private void checkBox_TP_Start_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Change_Write_ToIni("StartUpState", "TP_State", checkBox_TP_Start.Checked);
        }

        private void About_ME_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_About form_About = new Form_About();
            form_About.ShowDialog();
        }

        private void Server_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Server form_Server = new Form_Server();
            form_Server.ShowDialog();
        }

        private void checkBox_Terminal_Mode_CheckedChanged(object sender, EventArgs e)
        {
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径
            IniFile read_ini = new IniFile(toolbox_ini_path);
            string TP_Paths = read_ini.ReadValue("Paths", "TP");
            string TP_User_XML_Path = TP_Paths.Replace("TeknoParrotUi.exe", "UserProfiles\\WMMT6R.xml");

            XmlHelper.XmlManager xmlManager = new XmlHelper.XmlManager(TP_User_XML_Path);
            if(checkBox_Terminal_Mode.Checked == true)
            {
                xmlManager.WriteXmlFieldValue("TerminalMode", "1");
            }
            else
            {
                xmlManager.WriteXmlFieldValue("TerminalMode", "0");
            }         
        }

        private void About_Box_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_About_Toolbox form_About_Toolbox = new Form_About_Toolbox();
            form_About_Toolbox.ShowDialog();
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            //进入前检查是否已经配置了AMAuthd.exe路径（使用其路径进行配置）
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径
            IniFile Read_Path = new IniFile(toolbox_ini_path);
            string AMA_Path = Read_Path.ReadValue("Paths", "AMAuthd");
            string Game_Path = AMA_Path.Replace("\\AMCUS\\AMAuthd.exe", "\\wmn6r.exe");
            if(Game_Path == "")
            {
                MessageBox.Show("该功能需要先配置完成游戏启动路径\n请先去配置路径后再使用", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form_RES form_res = new Form_RES();
                form_res.ShowDialog();
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

        private void button_Net_Fix_Click(object sender, EventArgs e)
        {
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径
            IniFile Read = new IniFile(toolbox_ini_path);
            string TP_Path = Read.ReadValue("Paths", "TP");

            if(System.IO.File.Exists(TP_Path))
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
                    Form_Net_Fix form_Net_Fix = new Form_Net_Fix();
                    form_Net_Fix.ShowDialog();
                    Console.WriteLine("已获得管理员权限");
                }
            }
            else
            {
                MessageBox.Show("检测到您的游戏启动路径配置有误，请配置完成后再进行操作", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_card_Click(object sender, EventArgs e)
        {
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径
            IniFile Read = new IniFile(toolbox_ini_path);
            string AMA_Path = Read.ReadValue("Paths", "AMAuthd");
            
            //判断是否为空，为空则取消打开
            if(AMA_Path != null)
            {
                Form_Card form_Card = new Form_Card();
                form_Card.ShowDialog();
            }
            else
            {
                MessageBox.Show("检测到您的游戏启动路径配置有误，请配置完成后再进行操作", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_CardManager_Click(object sender, EventArgs e)
        {
            Form_CardManager form_CardManager = new Form_CardManager();
            // 注册 CardManagerForm 的 FormClosed 事件处理程序
            form_CardManager.FormClosed += CardManagerForm_FormClosed;
            form_CardManager.ShowDialog();
        }

        private void CardManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 在 CardManagerForm 关闭后重新加载卡片到 ComboBox
            LoadCardsIntoComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径
            IniFile Read = new IniFile(toolbox_ini_path);
            string TP_Path = Read.ReadValue("Paths", "TP");

            if (System.IO.File.Exists(TP_Path))
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
                    Form_Server_Change form_Server_Change = new Form_Server_Change();
                    form_Server_Change.ShowDialog();
                    Console.WriteLine("已获得管理员权限");
                }
            }
            else
            {
                MessageBox.Show("检测到您的游戏启动路径配置有误，请配置完成后再进行操作", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

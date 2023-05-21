using IWshRuntimeLibrary;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WMMT_Toolbox.Forms;
using XmlHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WMMT_Toolbox
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
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
                //启动Maxi Terminal
                string Maxi_Path_Start = Maxi_Path;
                Process pro = new Process();
                FileInfo file = new FileInfo(Maxi_Path_Start);
                pro.StartInfo.WorkingDirectory = file.DirectoryName;
                pro.StartInfo.FileName = Maxi_Path_Start;
                pro.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
                pro.StartInfo.CreateNoWindow = false;
                pro.Start();

                //启动AMAuthd.exe
                string AMA_exeFilePath = AMA_Path; // 设置 AMAuthd.exe 文件的完整路径
                Process AMA_process = new Process();
                AMA_process.StartInfo.FileName = AMA_exeFilePath; // 将完整路径传递给 FileName 属性
                AMA_process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                AMA_process.Start();

                //启动TP模拟器（直接启动）
                string TP_exeFilePath = TP_Path; // 设置 TeknoParrotUi.exe 文件的完整路径
                string arguments = ""; // 设置启动参数（默认空的）

                //根据用户选择状态是否调用参数启动
                if(checkBox_direct_start.Checked)
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
            }
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
    }
}

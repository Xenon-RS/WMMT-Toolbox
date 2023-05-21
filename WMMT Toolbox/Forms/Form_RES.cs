using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WMMT_Toolbox.Forms
{
    public partial class Form_RES : Form
    {
        public Form_RES()
        {
            InitializeComponent();
        }

        private void button_RES_edit_Click(object sender, EventArgs e)
        {
            string Toolbox_path = Application.StartupPath;
            string RES_path = Toolbox_path + "\\Resources\\RES";
            string RES_RM_Path = Toolbox_path + "\\Resources\\RES\\Readme.txt";

            //获取游戏exe路径
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径
            IniFile Read = new IniFile(toolbox_ini_path);
            string AMA_Path = Read.ReadValue("Paths", "AMAuthd");
            string Game_Path = AMA_Path.Replace("\\AMCUS\\AMAuthd.exe", "\\wmn6r.exe");

            //判断Readme是否存在
            if (File.Exists(RES_RM_Path))
            {
                //存在，获取当前选项
                string Type = ""; //Type将储存文件夹名字后续方便调用
                switch (comboBox_RES.Text)
                {
                    case "1366 x 768（原版分辨率）": Type = "1366x768";
                        break;
                    case "1600 x 900（900P）": Type = "1600x900";
                        break;
                    case "1920 x 1080（1080P）": Type = "1920x1080";
                        break;
                    case "2448 x 1373（2K窗体非全屏）": Type = "2448x1373";
                        break;
                    case "2560 x 1080（1080P宽屏）": Type = "2560x1080";
                        break;
                    case "2560 x 1440（2K全屏）": Type = "2560x1440";
                        break;
                    case "3440 x 1440（2K宽屏）": Type = "3440x1440";
                        break;
                    default:
                        Type = ""; //继续为空
                        break;
                }
                RES_Choose_Edit(Type, Game_Path); //处理
            }
            else
            {
                //不存在则退出
                MessageBox.Show("检测到工具箱资源缺失，请您重新检查工具箱本体是否完整！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); //关闭窗体
            }
        }

        public void RES_Choose_Edit(string type, string game_path)
        {
            if(type == "")
            {
                MessageBox.Show("请先选择一个分辨率！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //检查游戏是否正在运行
                Process[] processes = Process.GetProcessesByName("wmn6r");
                if (processes.Length == 0)
                {
                    Console.WriteLine("游戏并没有在运行");

                    //没有运行则可以直接覆盖
                    string RES_Game_Path = Application.StartupPath + "\\Resources\\RES\\" + type + "\\wmn6r.exe"; //拼接路径
                    File.Copy(RES_Game_Path, game_path, true); //覆盖
                    DialogResult dr = MessageBox.Show($"分辨率已修改为 {type} ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    //正在运行则不执行
                    Console.WriteLine("游戏正在运行");
                    MessageBox.Show("检测到游戏在后台中运行，请您确保游戏已经关闭\n可前往任务管理器寻找wmn6r.exe的选项并关闭后重试", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMMT_Toolbox.Forms
{
    public partial class Form_RES : Form
    {
        public Form_RES()
        {
            InitializeComponent();
        }

        string WMMT_PATH;

        private void button_res_change_Click(object sender, EventArgs e)
        {
            //首先获取WMMT-Toolbox/RES的路径
            string path2 = System.Environment.UserName;
            string path1, path3;
            path1 = @"C:\Users\";
            path3 = "AppData\\Local\\WMMT-Toolbox\\RES";
            string full_path = Path.Combine(path1, path2, path3); // C:\Users\AppData\Local\WMMT-Toolbox\RES

            //获取AMAuthd.exe的路径，然后推断出WMMT的文件夹
            string path_ama = "AppData\\Local\\WMMT-Toolbox\\Path\\AMA.set";
            string AMA_full_path = Path.Combine(path1, path2, path_ama);

            foreach (string ama in File.ReadAllLines(AMA_full_path))
            {
                WMMT_PATH = ama; //WMMT_PATH储存最终AMA的路径
            }

            string wmmt = WMMT_PATH.Replace("AMCUS\\AMAuthd.exe", ""); //去除AMCUS\AMAuthd.exe

            string wmn6r = wmmt + "wmn6r.exe";

            Console.WriteLine(wmn6r); //wmn6r为最终的exe路径

            Process[] processes = Process.GetProcessesByName("wmn6r");
            if (processes.Length == 0)
            {
                Console.WriteLine("Not running");
            }
            else
            {
                Console.WriteLine("Running");
            }

            //判断文件是否存在（也就是路径是否正确）,并且检查wmn6r是否在运行
            if(!File.Exists(wmn6r))
            {
                MessageBox.Show("设置失败，您确定您使用该功能前正确地设置过路径？");
            }
            else
            {
                if(processes.Length == 0) //如果检测不到wmn6r
                {
                    Console.WriteLine("wmn6r Not running"); //不运行才可以

                    //判断选中的分辨率
                    if (comboBox_ress.Text == "1366 x 768")
                    {
                        Console.WriteLine("用户选择1366 x 768");

                        //开始修改
                        string exewmmt = "\\768P(1366x768)\\wmn6r.exe";
                        string full_RES_path = full_path + exewmmt;

                        FileInfo file = new FileInfo(full_RES_path);
                        file.CopyTo(wmn6r, true);

                        DialogResult result = MessageBox.Show("已设置为1366 x 768分辨率，是否关闭分辨率修改窗口？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    else if (comboBox_ress.Text == "1600 x 960")
                    {
                        Console.WriteLine("用户选择1600 x 960");

                        //开始修改
                        string exewmmt = "\\900P(1600x900)\\wmn6r.exe";
                        string full_RES_path = full_path + exewmmt;

                        FileInfo file = new FileInfo(full_RES_path);
                        file.CopyTo(wmn6r, true);

                        DialogResult result = MessageBox.Show("已设置为1600 x 900分辨率，是否关闭分辨率修改窗口？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    else if (comboBox_ress.Text == "1920 x 1080")
                    {
                        Console.WriteLine("用户选择1920 x 1080");

                        //开始修改
                        string exewmmt = "\\1080P(1920×1080)\\wmn6r.exe";
                        string full_RES_path = full_path + exewmmt;

                        FileInfo file = new FileInfo(full_RES_path);
                        file.CopyTo(wmn6r, true);

                        DialogResult result = MessageBox.Show("已设置为1920 x 1080分辨率，是否关闭分辨率修改窗口？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    else if (comboBox_ress.Text == "2560 x 1440")
                    {
                        Console.WriteLine("用户选择2560 x 1440");

                        //开始修改
                        string exewmmt = "\\QHD_2K_1440P(2560x1440)\\wmn6r.exe";
                        string full_RES_path = full_path + exewmmt;

                        FileInfo file = new FileInfo(full_RES_path);
                        file.CopyTo(wmn6r, true);

                        DialogResult result = MessageBox.Show("已设置为2560 x 1440分辨率，是否关闭分辨率修改窗口？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    else if (comboBox_ress.Text == "2448 x 1373")
                    {
                        Console.WriteLine("用户选择2448 x 1373");

                        //开始修改
                        string exewmmt = "\\QHD 2K_Windowed(2448x1373)\\wmn6r.exe";
                        string full_RES_path = full_path + exewmmt;

                        FileInfo file = new FileInfo(full_RES_path);
                        file.CopyTo(wmn6r, true);

                        DialogResult result = MessageBox.Show("已设置为2448 x 1373分辨率，是否关闭分辨率修改窗口？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    else if (comboBox_ress.Text == "3840 x 2160")
                    {
                        Console.WriteLine("用户选择3840 x 2160");

                        //开始修改
                        string exewmmt = "\\UHD_4K_2160P(3840 × 2160)\\wmn6r.exe";
                        string full_RES_path = full_path + exewmmt;

                        FileInfo file = new FileInfo(full_RES_path);
                        file.CopyTo(wmn6r, true);

                        DialogResult result = MessageBox.Show("已设置为3840 x 2160分辨率，是否关闭分辨率修改窗口？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("请先选择一个分辨率！");
                    }
                }
                else
                {
                    Console.WriteLine("Running");
                    MessageBox.Show("检测到游戏仍在运行当中，请关闭游戏后再更换分辨率\n请检查后台是否正在运行wmn6r.exe", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

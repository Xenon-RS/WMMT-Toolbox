using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMMT_Toolbox
{
    public partial class Form_Path_Select : Form
    {
        public Form_Path_Select()
        {
            InitializeComponent();
        }

        private void button_into_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Maxi_select_Click(object sender, EventArgs e)
        {
            //自定义一个新的文件打开窗口 openFile_Maxi
            OpenFileDialog openFile_Maxi = new OpenFileDialog();
            //初始打开目录
            openFile_Maxi.InitialDirectory = @"C:\";
            //窗口标题
            openFile_Maxi.Title = "Maxi Terminal（湾岸终端机）的run.bat文件地址";
            //过滤文件
            openFile_Maxi.Filter = "bat文件 (*.bat)|*.bat";
            openFile_Maxi.FilterIndex = 0;
            //多重选择
            openFile_Maxi.Multiselect = false;

            if (openFile_Maxi.ShowDialog() == DialogResult.OK)
            {
                //将获取到的路径放到textbox里
                textBox_Maxi.Text = openFile_Maxi.FileName;

                //首先获取WMMTLauncher的路径
                string path2 = System.Environment.UserName;
                string path1, path3;
                path1 = @"C:\Users\";
                path3 = "AppData\\Local\\WMMT-Toolbox\\Path\\";
                string full_path = Path.Combine(path1, path2, path3);

                //合并路径
                string maxi_path1 = full_path;
                string maxi_path2 = "Maxi.set";
                string full_maxi_path = Path.Combine(maxi_path1, maxi_path2);

                StreamWriter sw = new StreamWriter(full_maxi_path);
                sw.WriteLine(openFile_Maxi.FileName);
                sw.Close();
            }
            else
            {
                string maxi_error = "请选择正确的文件";
                MessageBox.Show(maxi_error);
            }
        }

        private void button_AMA_select_Click(object sender, EventArgs e)
        {
            //自定义一个新的文件打开窗口 openFile_AMA
            OpenFileDialog openFile_AMA = new OpenFileDialog();
            //初始打开目录
            openFile_AMA.InitialDirectory = @"C:\";
            //窗口标题
            openFile_AMA.Title = "游戏本体内 WMMT6R\\AMCUS文件夹内的AMAuthd.exe文件";
            //过滤文件
            openFile_AMA.Filter = "exe文件 (*.exe)|*.exe";
            openFile_AMA.FilterIndex = 0;
            //多重选择
            openFile_AMA.Multiselect = false;

            if (openFile_AMA.ShowDialog() == DialogResult.OK)
            {
                //将获取到的路径放到textbox里
                textBox_AMA.Text = openFile_AMA.FileName;

                //首先获取WMMTLauncher的路径
                string path2 = System.Environment.UserName;
                string path1, path3;
                path1 = @"C:\Users\";
                path3 = "AppData\\Local\\WMMT-Toolbox\\Path\\";
                string full_path = Path.Combine(path1, path2, path3);

                //合并路径
                string AMA_path1 = full_path;
                string AMA_path2 = "AMA.set";
                string full_AMA_path = Path.Combine(AMA_path1, AMA_path2);

                StreamWriter sw = new StreamWriter(full_AMA_path);
                sw.WriteLine(openFile_AMA.FileName);
                sw.Close();
            }
            else
            {
                string AMA_error = "请选择正确的文件";
                MessageBox.Show(AMA_error);
            }
        }

        private void button_TP_select_Click(object sender, EventArgs e)
        {
            //自定义一个新的文件打开窗口 openFile_TP
            OpenFileDialog openFile_TP = new OpenFileDialog();
            //初始打开目录
            openFile_TP.InitialDirectory = @"C:\";
            //窗口标题
            openFile_TP.Title = "TeknoParrot鹦鹉模拟器的TeknoParrotUi.exe文件地址";
            //过滤文件
            openFile_TP.Filter = "exe文件 (*.exe)|*.exe";
            openFile_TP.FilterIndex = 0;
            //多重选择
            openFile_TP.Multiselect = false;

            if (openFile_TP.ShowDialog() == DialogResult.OK)
            {
                //将获取到的路径放到textbox里
                textBox_TP.Text = openFile_TP.FileName;

                //首先获取WMMTLauncher的路径
                string path2 = System.Environment.UserName;
                string path1, path3;
                path1 = @"C:\Users\";
                path3 = "AppData\\Local\\WMMT-Toolbox\\Path\\";
                string full_path = Path.Combine(path1, path2, path3);

                //合并路径
                string TP_path1 = full_path;
                string TP_path2 = "TP.set";
                string full_TP_path = Path.Combine(TP_path1, TP_path2);

                StreamWriter sw = new StreamWriter(full_TP_path);
                sw.WriteLine(openFile_TP.FileName);
                sw.Close();
            }
            else
            {
                string TP_error = "请选择正确的文件";
                MessageBox.Show(TP_error);
            }
        }

        private void Form_Path_Select_Load(object sender, EventArgs e)
        {
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

            //获取Maxi的路径
            foreach (string Maxi_line in File.ReadLines(full_maxi_path))
            {
                textBox_Maxi.Text = Maxi_line;
            }

            //获取AMAuthd的路径
            foreach (string AMA_line in File.ReadLines(full_AMA_path))
            {
                textBox_AMA.Text = AMA_line;
            }

            //获取TP的路径
            foreach (string TP_line in File.ReadLines(full_TP_path))
            {
                textBox_TP.Text = TP_line;
            }
        }
    }
}

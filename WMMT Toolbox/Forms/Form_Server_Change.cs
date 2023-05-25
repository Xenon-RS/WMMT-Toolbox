using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WMMT_Toolbox.Forms
{
    public partial class Form_Server_Change : Form
    {
        public Form_Server_Change()
        {
            InitializeComponent();
        }

        private void button_Server_Change_Click(object sender, EventArgs e)
        {
            //定义文件地址
            string filePath = @"C:\Windows\System32\drivers\etc\hosts";

            // 读取hosts文件内容
            string fileContent = File.ReadAllText(filePath);

            //服务器IP切换
            string searchPattern = @"^.*naominet\.jp.*$";
            string serverip = textBox_ServerIP.Text;
            string customText = serverip + " " + "naominet.jp"; // 自定义内容

            // 删除包含naominet.jp的整行
            Regex regex = new Regex(searchPattern, RegexOptions.Multiline);
            fileContent = regex.Replace(fileContent, "");

            // 在文件末尾添加自定义内容和空白内容
            fileContent += customText + "\n\n\n";

            // 保存修改后的hosts文件内容
            File.WriteAllText(filePath, fileContent);

            MessageBox.Show("服务器IP切换完毕");
        }

        private void Form_Server_Change_Load(object sender, EventArgs e)
        {
            //从原hosts读取服务器IP
            string[] lines = System.IO.File.ReadAllLines(@"C:\Windows\System32\drivers\etc\hosts");
            string targetLine = "naominet.jp";

            foreach (string line in lines)
            {
                if (line.Contains(targetLine))
                {
                    Match match = Regex.Match(line, @"\b(?:[0-9]{1,3}\.){3}[0-9]{1,3}\b");
                    string ipAddress = match.Value;
                    Console.WriteLine("IP address: " + ipAddress);
                    textBox_ServerIP.Text = ipAddress;
                    break;
                }
                else
                {
                    textBox_ServerIP.Text = "请输入服务器IP";
                }
            }
        }
    }
}

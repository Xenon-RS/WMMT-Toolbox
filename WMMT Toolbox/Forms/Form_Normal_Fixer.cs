using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WMMT_Toolbox
{
    public partial class Form_Normal_Fixer : Form
    {
        public Form_Normal_Fixer()
        {
            InitializeComponent();
        }

        string TP_path_mid;

        string Now_Value;

        private void button_White_Fix_Click(object sender, EventArgs e)
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

            int lineNumber = -1; // -1 表示未找到指定的文本
            string searchText = "      <FieldName>WhiteScreenFix</FieldName>";
            string replaceText;

            // 查找指定文本的行号
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(searchText))
                {
                    lineNumber = i;
                    break;
                }
            }

            //先读取当前状态
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
                        Now_Value = "1";
                    }
                    else
                    {
                        Now_Value = "0";
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

            //设定值
            if (Now_Value == "0")
            {
                replaceText = "1";
            }
            else
            {
                replaceText = "1";
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
                Console.WriteLine("修改白屏修复选项的时候失败");
            }

            //检查修改了xml后有没有bug（一般是第一行少了字符）
            string filePath = TP_Profiles_path;
            string expectedFirstLine = "<?xml version=\"1.0\" encoding=\"utf-8\"?>"; //第一行的

            // Read the first line of the file
            string actualFirstLine = File.ReadLines(filePath).First();

            if (actualFirstLine == expectedFirstLine)
            {
                Console.WriteLine("一样，没有bug");
            }
            else
            {
                // Replace the first line with the expected string
                string[] BUG_lines = File.ReadAllLines(filePath);
                BUG_lines[0] = expectedFirstLine;
                File.WriteAllLines(filePath, BUG_lines);
            }
        }

        private void button_2401_Click(object sender, EventArgs e)
        {
            // 读取 JSON 文件
            string file_path = @"F:\\WMMT6R\\MaxiTerminal\\config.json";
            string json = File.ReadAllText(file_path);
            JObject obj = Newtonsoft.Json.Linq.JObject.Parse(json);

            string revision = obj["修订版本号"].ToString();

            if (revision == "20000")
            {
                obj["修订版本号"] = "20008";
                MessageBox.Show("已修复，请进入游戏查看是否仍然报错2401");
            }
            else if (revision == "20008")
            {
                obj["修订版本号"] = "20000";
                MessageBox.Show("已修复，请进入游戏查看是否仍然报错2401");
            }
            else
            {
                obj["修订版本号"] = "20008";
                MessageBox.Show("已修复，请进入游戏查看是否仍然报错2401");
            }

            string output = obj.ToString(Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(file_path, output);
        }
    }
}

using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Linq;
using System.Windows.Forms;
using System.Management;

namespace WMMT_Toolbox
{
    public partial class Form_Net : Form
    {
        public Form_Net()
        {
            InitializeComponent();
        }

        private void Form_Net_Load(object sender, EventArgs e)
        {
            //获取IPV4地址
            IPAddress ipv4Address = null;
            var currentInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(n => n.OperationalStatus == OperationalStatus.Up && n.NetworkInterfaceType != NetworkInterfaceType.Loopback);
            if (currentInterface != null)
            {
                var ipProperties = currentInterface.GetIPProperties();
                foreach (var ipAddress in ipProperties.UnicastAddresses)
                {
                    if (ipAddress.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        ipv4Address = ipAddress.Address;

                        //赋值到textbox
                        textBox_ipv4.Text = ipv4Address.ToString();
                        break;
                    }
                }
            }

            //获取默认网关
            string mac = null, ip = null, ipsubnet = null, ipgateway = null;
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection nics = mc.GetInstances();
            foreach (ManagementObject nic in nics)
            {
                if ((nic["DefaultIPGateway"] as String[]) != null && Convert.ToBoolean(nic["ipEnabled"]) == true)
                {
                    mac = nic["MacAddress"].ToString();//Mac地址
                    ip = (nic["IPAddress"] as String[])[0];//IP地址
                    ipsubnet = (nic["IPSubnet"] as String[])[0];//子网掩码
                    ipgateway = (nic["DefaultIPGateway"] as String[])[0];//默认网关
                }
            }
            Console.WriteLine(ip); //ipv4地址
            Console.WriteLine(ipsubnet); //子网掩码
            Console.WriteLine(ipgateway); //默认网关

            //赋值到textbox
            textBox_gateway.Text = ipgateway.ToString();

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
                    textBox_server.Text = ipAddress;
                    break;
                }
                else
                {
                    textBox_server.Text = "请输入服务器IP";
                }
            }
        }

        string TP_path_mid;

        private void button_fix_net_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_server.Text.Trim(), @"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$"))
            {
                Console.WriteLine("用户设置的不是正常的IP");
                MessageBox.Show("请检查服务器IP是否输入正确！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Console.WriteLine("用户设置的是正常IP");
                //执行修复
                //hosts网络修复

                //定义文件地址
                string filePath = @"C:\Windows\System32\drivers\etc\hosts";

                // 读取hosts文件内容
                string fileContent = File.ReadAllText(filePath);



                //修复hosts网络内容 tenporouter.loc
                string searchPattern_ten = @"^.*tenporouter\.loc.*$";

                //获取默认网关地址
                string gateway = textBox_gateway.Text;

                //定义ten地址
                string ten = "tenporouter.loc";
                string k = " ";

                //合并行
                string full_path = gateway + k + ten;
                string customText_ten = full_path; // 自定义内容

                // 读取hosts文件内容
                string fileContent_ten = File.ReadAllText(filePath);

                // 删除包含naominet.jp的整行
                Regex regex_ten = new Regex(searchPattern_ten, RegexOptions.Multiline);
                fileContent = regex_ten.Replace(fileContent, string.Empty);

                // 在文件末尾添加自定义内容和空白内容
                fileContent += customText_ten + "\n";

                // 删除空行
                fileContent = Regex.Replace(fileContent, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline);

                // 保存修改后的hosts文件内容
                File.WriteAllText(filePath, fileContent);

                // 设置一个完成后的变量
                string yesorno_ten = "1";



                //修复hosts网络内容 bbrouter.loc
                string searchPattern_bbr = @"^.*bbrouter\.loc.*$";

                //定义ten地址
                string bbr = "bbrouter.loc";
                string k1 = " ";

                //合并行
                string full_path_bbr = gateway + k1 + bbr;
                string customText_bbr = full_path_bbr; // 自定义内容

                // 读取hosts文件内容
                string fileContent_bbr = File.ReadAllText(filePath);

                // 删除包含naominet.jp的整行
                Regex regex_bbr = new Regex(searchPattern_bbr, RegexOptions.Multiline);
                fileContent = regex_bbr.Replace(fileContent, "");

                // 在文件末尾添加自定义内容和空白内容
                fileContent += customText_ten + "\n";

                // 保存修改后的hosts文件内容
                File.WriteAllText(filePath, fileContent);

                // 设置一个完成后的变量
                string yesorno_bbr = "1";





                //修复hosts网络内容 服务器ip
                string searchPattern = @"^.*naominet\.jp.*$";
                string serverip = textBox_server.Text;
                string customText = serverip + " " + "naominet.jp"; // 自定义内容

                // 删除包含naominet.jp的整行
                Regex regex = new Regex(searchPattern, RegexOptions.Multiline);
                fileContent = regex.Replace(fileContent, "");

                // 在文件末尾添加自定义内容和空白内容
                fileContent += customText + "\n\n\n";

                // 保存修改后的hosts文件内容
                File.WriteAllText(filePath, fileContent);

                // 设置一个完成后的变量
                string yesorno_ip = "1";


                if (yesorno_ten == "1" && yesorno_bbr == "1" && yesorno_ip == "1")
                {
                    MessageBox.Show("网络修复完毕");
                }
                else
                {
                    Console.WriteLine("nmsl没修改成功");
                }
            }
        }

        private void button_net_fix_tp_Click(object sender, EventArgs e)
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

            if (File.Exists(full_TP_path))
            {
                if(File.Exists(TP_Profiles_path))
                {

                    //修复网络：NetworkAdapterIP

                    // 定义要查找的行和替换的内容
                    int NetworkAdapter_lineNumber = -1; // -1 表示未找到指定的文本
                    string NetworkAdapter_searchText = "      <FieldName>NetworkAdapterIP</FieldName>";
                    string NetworkAdapter_replaceText = textBox_ipv4.Text;

                    // 查找指定文本的行号
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Contains(NetworkAdapter_searchText))
                        {
                            NetworkAdapter_lineNumber = i;
                            break;
                        }
                    }

                    // 如果找到了指定文本，则在其下一行进行替换操作
                    if (NetworkAdapter_lineNumber != -1 && NetworkAdapter_lineNumber + 1 < lines.Length)
                    {
                        string line = lines[NetworkAdapter_lineNumber + 1];
                        string pattern = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}";
                        string newLine = Regex.Replace(line, pattern, NetworkAdapter_replaceText);
                        lines[NetworkAdapter_lineNumber + 1] = newLine;
                        File.WriteAllLines(fileName, lines);
                    }
                    else
                    {
                        Console.WriteLine("修改NetworkAdapterIP时修改失败");
                    }

                    //设定修改完毕
                    string networkadapter_net_fix = "true";


                    //修复网络：TerminalIP

                    // 定义要查找的行和替换的内容
                    int Terminal_lineNumber = -1; // -1 表示未找到指定的文本
                    string Terminal_searchText = "      <FieldName>TerminalIP</FieldName>";
                    string Terminal_replaceText = textBox_ipv4.Text;

                    // 查找指定文本的行号
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Contains(Terminal_searchText))
                        {
                            Terminal_lineNumber = i;
                            break;
                        }
                    }

                    // 如果找到了指定文本，则在其下一行进行替换操作
                    if (Terminal_lineNumber != -1 && Terminal_lineNumber + 1 < lines.Length)
                    {
                        string line = lines[Terminal_lineNumber + 1];
                        string pattern = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}";
                        string newLine = Regex.Replace(line, pattern, Terminal_replaceText);
                        lines[Terminal_lineNumber + 1] = newLine;
                        File.WriteAllLines(fileName, lines);
                    }
                    else
                    {
                        Console.WriteLine("修改TerminalIP时未找到指定的文本");
                    }

                    //设定修改完毕
                    string terminal_net_fix = "true";


                    //修复网络：RouterIP

                    // 定义要查找的行和替换的内容
                    int Router_lineNumber = -1; // -1 表示未找到指定的文本
                    string Router_searchText = "      <FieldName>RouterIP</FieldName>";
                    string Router_replaceText = textBox_gateway.Text;

                    // 查找指定文本的行号
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Contains(Router_searchText))
                        {
                            Router_lineNumber = i;
                            break;
                        }
                    }

                    // 如果找到了指定文本，则在其下一行进行替换操作
                    if (Router_lineNumber != -1 && Router_lineNumber + 1 < lines.Length)
                    {
                        string line = lines[Router_lineNumber + 1];
                        string pattern = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}";
                        string newLine = Regex.Replace(line, pattern, Router_replaceText);
                        lines[Router_lineNumber + 1] = newLine;
                        File.WriteAllLines(fileName, lines);
                    }
                    else
                    {
                        Console.WriteLine("修改RouterIP时未找到指定的文本");
                    }

                    //设定修改完毕
                    string router_net_fix = "true";

                    if(networkadapter_net_fix == "true" && terminal_net_fix == "true" && router_net_fix == "true")
                    {
                        DialogResult fix =  MessageBox.Show("TeknoParrot网络修复完毕", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (fix == DialogResult.Yes)
                        {
                            this.Close();
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    else
                    {
                        Console.WriteLine("未知原因报错");
                    }

                }
                else
                {
                    MessageBox.Show("没有找到TeknoParrotUi的用户配置文件\n您确定您有手动安装并游玩过一次WMMT吗？", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请先在路径设置中配置好TeknoParrotUi.exe路径再进行网络修复操作", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

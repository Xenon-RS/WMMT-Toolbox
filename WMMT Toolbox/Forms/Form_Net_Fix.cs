using System;
using System.Management;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using XmlHelper;

namespace WMMT_Toolbox.Forms
{
    public partial class Form_Net_Fix : Form
    {
        public Form_Net_Fix()
        {
            InitializeComponent();
        }

        private void Form_Net_Fix_Load(object sender, EventArgs e)
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
                    textBox_Server.Text = ipAddress;
                    break;
                }
                else
                {
                    textBox_Server.Text = "请输入服务器IP";
                }
            }
        }

        string TP_path_mid;

        private void button_Net_Fix_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_Server.Text.Trim(), @"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$"))
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
                fileContent += customText_bbr + "\n";

                // 保存修改后的hosts文件内容
                File.WriteAllText(filePath, fileContent);

                // 设置一个完成后的变量
                string yesorno_bbr = "1";





                //修复hosts网络内容 服务器ip
                string searchPattern = @"^.*naominet\.jp.*$";
                string serverip = textBox_Server.Text;
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

        private void button_TP_Fix_Click(object sender, EventArgs e)
        {
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径
            IniFile Read = new IniFile(toolbox_ini_path);
            string TP_Path = Read.ReadValue("Paths", "TP");
            string UserProfiles = TP_Path.Replace("\\TeknoParrotUi.exe", "\\UserProfiles\\WMMT6R.xml");

            if(File.Exists(UserProfiles))
            {
                XmlManager Write_Profiles = new XmlManager(UserProfiles);

                //写入TerminalIP
                string WriteType_Terminal = "TerminalIP"; //字段
                string TerminalIP = textBox_ipv4.Text; //值
                Write_Profiles.WriteXmlFieldValue(WriteType_Terminal, TerminalIP);

                //写入RouterIP
                string WriteType_Router = "RouterIP";
                string RouterIP = textBox_gateway.Text;
                Write_Profiles.WriteXmlFieldValue(WriteType_Router, RouterIP);

                //写入NetWorkAdapterIP(老的TP有，所以需要加条件判断)
                XmlManager Read_Profiles = new XmlManager(UserProfiles);

                string fieldName = "NetworkAdapterIP"; // 将字段名称替换为实际的字段名
                string fieldValue = Read_Profiles.ReadXmlFieldValue(fieldName);
                if (fieldValue != null)
                {
                    // 对字段值进行处理
                    Console.WriteLine($"字段 {fieldName} 的值为：{fieldValue}, 执行修改");

                    string WriteType_NetworkAdapterIP = "NetworkAdapterIP";
                    string NetworkAdapterIP = textBox_ipv4.Text;
                    Write_Profiles.WriteXmlFieldValue(WriteType_NetworkAdapterIP, NetworkAdapterIP);
                }
                else
                {
                    Console.WriteLine($"未找到字段 {fieldName}, 不执行修改");
                }

                MessageBox.Show("网络已修复，请您进入游戏查看是否修复成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("无法找到鹦鹉模拟器的设置文件，请问您此前有手动配置成功并启动过游戏吗？", "错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace WMMT_Toolbox.Forms
{
    public partial class Form_Card : Form
    {
        public Form_Card()
        {
            InitializeComponent();
        }

        private void Form_Card_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Card_Edit_Click(object sender, EventArgs e)
        {
            string toolbox_ini_path = Path.Combine(Application.StartupPath, "Toolbox_Settings.ini"); //ini路径
            IniFile Read = new IniFile(toolbox_ini_path);
            string AMA_Path = Read.ReadValue("Paths", "AMAuthd");
            string Bngrw_Game_Path = AMA_Path.Replace("\\AMCUS\\AMAuthd.exe", "\\bngrw.dll");

            string Type = "";
            switch(comboBox_card_type.Text)
            {
                case "Backspace（退格删除键）": Type = "Backspace";
                    break;
                case "Ctrl": Type = "Ctrl";
                    break;
                case "Delete": Type = "Delete";
                    break;
                case "Enter（回车）": Type = "Enter";
                    break;
                case "Home": Type = "Home";
                    break;
                case "小键盘 0键": Type = "KeyPad_0";
                    break;
                case "鼠标 左键": Type = "Mouse_Left";
                    break;
                case "鼠标 中键": Type = "Mouse_Mid";
                    break;
                case "鼠标 右键": Type = "Mouse_Right";
                    break;
                case "Shift": Type = "Shift";
                    break;
                case "SpaceBar（空格键）": Type = "Spacebar";
                    break;
                default:
                    Type = "";
                    break;
            }
            Bngrw_Edit(Type, Bngrw_Game_Path);
        }

        private void Bngrw_Edit(string Type, string Bngrw_Game_Path)
        {
            string Resource = Application.StartupPath + "\\Resources\\Bngrw\\" + Type + "\\bngrw.dll";
            if(File.Exists(Resource))
            {
                if(File.Exists(Bngrw_Game_Path))
                {
                    File.Copy(Resource, Bngrw_Game_Path, true);
                    DialogResult dr = MessageBox.Show($"已修改为 {Type} 按键", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(dr == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("检测不到游戏原刷卡文件bngrw.dll\n请您重新检查游戏本体是否完整！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            else
            {
                MessageBox.Show("检测到工具箱资源缺失，请您重新检查工具箱本体是否完整！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

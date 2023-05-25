using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;

namespace WMMT_Toolbox.Forms
{
    public partial class Form_CardManager : Form
    {
        string Card_Folder_Path = Application.StartupPath + "\\Card";

        public Form_CardManager()
        {
            InitializeComponent();
        }

        private void button_Add_Card_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_Add_Card = new OpenFileDialog();
            ofd_Add_Card.Title = "请选择一个卡文件(*.ini)";
            ofd_Add_Card.Filter = "ini文件(*.ini)|*.ini";
            ofd_Add_Card.Multiselect = false;
            ofd_Add_Card.InitialDirectory = Application.StartupPath;

            if(ofd_Add_Card.ShowDialog() == DialogResult.OK )
            {
                string Source_Card = ofd_Add_Card.FileName;
                string destinationFileName = GetUniqueCardFileName(Path.GetFileNameWithoutExtension(Source_Card));
                string destinationFilePath = Path.Combine(Card_Folder_Path, destinationFileName);
                File.Copy(Source_Card, destinationFilePath);
                string final_destinationFileName = destinationFileName.Replace(".ini", "");
                listBox_Cards.Items.Add(final_destinationFileName);
            }
            else
            {
                MessageBox.Show("请选择一个ini文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private string GetUniqueCardFileName(string fileName)
        {
            string uniqueFileName = fileName;
            int suffix = 1;

            while (listBox_Cards.Items.Contains(uniqueFileName))
            {
                uniqueFileName = $"{fileName} ({suffix})";
                suffix++;
            }

            return uniqueFileName + ".ini";
        }

        private void LoadCards()
        {
            if (!Directory.Exists(Card_Folder_Path))
            {
                Directory.CreateDirectory(Card_Folder_Path);
            }

            string[] cardFiles = Directory.GetFiles(Card_Folder_Path, "*.ini");

            foreach (string filePath in cardFiles)
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                listBox_Cards.Items.Add(fileName);
            }
        }

        private void Form_CardManager_Load(object sender, EventArgs e)
        {
            LoadCards();
        }

        private void button_Delete_Card_Click(object sender, EventArgs e)
        {
            if (listBox_Cards.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("您是否希望删除该卡片？\n此操作不可恢复", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.OK)
                {
                    string selectedCard = listBox_Cards.SelectedItem.ToString();
                    string cardFilePath = Path.Combine(Card_Folder_Path, selectedCard);
                    string final_cardFilePath = cardFilePath + ".ini";
                    File.Delete(final_cardFilePath);
                    listBox_Cards.Items.Remove(selectedCard);
                    MessageBox.Show("已删除所选卡片文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Console.WriteLine("用户取消了删除操作");
                }
            }
            else
            {
                MessageBox.Show("请选择一个卡片进行删除操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Card_CustomName_Click(object sender, EventArgs e)
        {
            if (listBox_Cards.SelectedItem != null)
            {
                string selectedCard = listBox_Cards.SelectedItem.ToString();
                string cardFilePath = Path.Combine(Card_Folder_Path, selectedCard);

                string NoteName = Interaction.InputBox("请输入备注名称:", "备注卡片");
                if (!string.IsNullOrWhiteSpace(NoteName))
                {
                    string fileExtension = ".ini";
                    string newCardFileName = NoteName + fileExtension;
                    string newCardFilePath = Path.Combine(Card_Folder_Path, newCardFileName);

                    string cardFilePath_ex = cardFilePath + fileExtension;
                    File.Move(cardFilePath_ex, newCardFilePath);
                    listBox_Cards.Items[listBox_Cards.SelectedIndex] = NoteName;
                }
            }
            else
            {
                MessageBox.Show("请选择一个卡片进行备注操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

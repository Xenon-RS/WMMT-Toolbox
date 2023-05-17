using System.Windows.Forms;
using System.Diagnostics;

namespace WMMT_Toolbox.Forms
{
    public partial class Form_Server : Form
    {
        public Form_Server()
        {
            InitializeComponent();
        }

        private void linkLabel_OLG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://qm.qq.com/cgi-bin/qm/qr?k=UtnA3Zc8TZzgHpXCj-LtvnU5FSve3K4E&jump_from=webapi&authKey=GiR6wFTw0KDe8MMAGchvxZxDGtmP+OyD1ZhFvgZOoDOMnTix+moY3jSjXK+w7/st");
        }
    }
}

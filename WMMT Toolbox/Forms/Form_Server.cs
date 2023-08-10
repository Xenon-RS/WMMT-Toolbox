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
            Process.Start("https://qm.qq.com/cgi-bin/qm/qr?k=Mg3LqBvw9y14ZLfw1ywKchtFmvw58Hh8&jump_from=webapi&authKey=4VV+PAebouBlA2zsdT1+EA8GlNPNFqzfafb3iZuMBZqGJ19ptKm1IHshPETVI+08");
        }
    }
}

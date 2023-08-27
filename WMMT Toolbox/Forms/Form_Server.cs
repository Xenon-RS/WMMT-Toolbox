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
            Process.Start("https://qm.qq.com/cgi-bin/qm/qr?k=3qZzUasP1bvOvlCQ81wxYhKk4hwqH1tG&jump_from=webapi&authKey=eMm8d9bGFMEPjwHrSo041x+MfIRloV/kzH5UwA7qsmk4HIf/98Mq7ocpABnl5m7N");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMMT_Toolbox
{
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
        }

        private void linkLabel_OLG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://jq.qq.com/?_wv=1027&k=x1SbXC9x");
        }

        private void linkLabel_GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Zj031210");
        }

        private void linkLabel_Bilibili_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://space.bilibili.com/126108468");
        }
    }
}

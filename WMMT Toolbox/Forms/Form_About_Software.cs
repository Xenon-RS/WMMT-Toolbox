using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMMT_Toolbox.Forms
{
    public partial class Form_About_Software : Form
    {
        public Form_About_Software()
        {
            InitializeComponent();
        }

        private void linkLabel_git_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/OLG-WMMT-Team/WMMT-Toolbox");
        }
    }
}

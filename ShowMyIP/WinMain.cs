using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ShowMyIP
{
    public partial class WinMain : Form
    {
        public WinMain()
        {
            InitializeComponent();
            version.Text = string.Format( "專案：{0} / 版本:{1}", Application.ProductName , Application.ProductVersion);
            btnReload_Click(null, null);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txbResult.Text = "";
            List<string> ips = Project_Help.GetHostIPAddress();
            foreach (string ip in ips)
            {
                txbResult.Text += ip + "\n";
            }
        }
    }
}

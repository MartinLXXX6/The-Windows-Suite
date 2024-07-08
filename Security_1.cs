using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Win_Tweaker
{
    public partial class Security_1 : UserControl
    {
        public Security_1()
        {
            InitializeComponent();
        }

        private void SignInSett_BTN_Click(object sender, EventArgs e)
        {
            Process.Start("netplwiz.exe");
        }

        private void Next_BTN_Click(object sender, EventArgs e)
        {
            Main_Form.instance.OpenPage2();
        }
    }
}

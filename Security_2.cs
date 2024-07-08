using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Tweaker
{
    public partial class Security_2 : UserControl
    {
        public Security_2()
        {
            InitializeComponent();
        }

        private static void ChangeService(string name, string statusType, Pipeline pipeline)
        {
            pipeline.Commands.AddScript($@"Set-Service -name '{name}' -startupType '{statusType}'");
        }

        private void RDSett_BTN_Click(object sender, EventArgs e)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();

            pipeline.Commands.AddScript("start ms-settings:remotedesktop");

            pipeline.Invoke();
            runspace.Close();
        }

        private void RRRDServices_BTN_Click(object sender, EventArgs e)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();

            ChangeService("SessionEnv", "Disable", pipeline);
            ChangeService("TermService", "Disable", pipeline); 
            ChangeService("UmRdpService", "Disable", pipeline);

            ChangeService("RemoteRegistry", "Disable", pipeline);

            pipeline.Invoke();
            runspace.Close();

            MessageBox.Show("SECURITY2 tweaks successfuly applied");
        }

        private void Next_BTN_Click(object sender, EventArgs e)
        {
            Main_Form.instance.OpenPage3();
        }

        private void Previous_BTN_Click(object sender, EventArgs e)
        {
            Main_Form.instance.OpenPage1();
        }
    }
}

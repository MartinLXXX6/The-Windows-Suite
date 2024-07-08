using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Diagnostics;
using System.Security.Policy;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Win_Tweaker
{
    public partial class Optimization : UserControl
    {
        public Optimization()
        {
            InitializeComponent();
        }

        private void Apply_BTN_Click(object sender, EventArgs e)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();

            #region PowerThrottling
            if (PThrottling_CB.Checked == true)
            {
                ChangeRegKey("HKLM:\\SYSTEM\\CurrentControlSet\\Control\\Power\\PowerThrottling", "PowerThrottlingOff", true, pipeline, "DWord", "0");
            }
            else if (PThrottling_CB.Checked == false)
            {
                ChangeRegKey("HKLM:\\SYSTEM\\CurrentControlSet\\Control\\Power\\PowerThrottling", "PowerThrottlingOff", true, pipeline, "DWord", "1");
            }
            #endregion

            #region NetworkThrottling
            if (NThrottling_CB.Checked == true)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "NetworkThrottlingIndex", true, pipeline, "DWord", "0x00000000");
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", false, pipeline, "DWord", "0x00000014");
            }
            else if (NThrottling_CB.Checked == false)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "NetworkThrottlingIndex", true, pipeline, "DWord", "0xffffffff");
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", false, pipeline, "DWord", "0");
            }
            #endregion

            #region GPUPriorityForGames
            if (GPUPriority_DD.SelectedItem == "Normal (Default)")
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", true, pipeline, "DWord", "0x00000016");
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", false, pipeline, "DWord", "0x00000006");
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", false, pipeline, "String", "High");
            }
            else if (GPUPriority_DD.SelectedItem == "High")
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", true, pipeline, "DWord", "0x00000008");
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", false, pipeline, "DWord", "0x00000006");
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", false, pipeline, "String", "High");
            }
            #endregion

            #region EnhancedMousePrecision
            if (EnhancedPrecision_CB.Checked == false)
            {
                ChangeRegKey("HKCU:\\Control Panel\\Mouse", "MouseSpeed", true, pipeline, "String", "0");
                ChangeRegKey("HKCU:\\Control Panel\\Mouse", "MouseThreshold1", false, pipeline, "String", "0");
                ChangeRegKey("HKCU:\\Control Panel\\Mouse", "MouseThreshold2", false, pipeline, "String", "0");
            }
            else if (EnhancedPrecision_CB.Checked == true)
            {
                ChangeRegKey("HKCU:\\Control Panel\\Mouse", "MouseSpeed", true, pipeline, "String", "1");
                ChangeRegKey("HKCU:\\Control Panel\\Mouse", "MouseThreshold1", false, pipeline, "String", "6");
                ChangeRegKey("HKCU:\\Control Panel\\Mouse", "MouseThreshold2", false, pipeline, "String", "10");
            }
            #endregion

            #region ReduceHoverTime
            if (ReduceHoverTime_CB.Checked == false)
            {
                ChangeRegKey("HKCU:\\Control Panel\\Mouse", "MouseHoverTime", true, pipeline, "string", "500");
                ChangeRegKey("HKCU:\\Control Panel\\Desktop", "MenuShowDelay", true, pipeline, "string", "1");
            }
            else if (ReduceHoverTime_CB.Checked == true)
            {
                ChangeRegKey("HKCU:\\Control Panel\\Mouse", "MouseHoverTime", true, pipeline, "string", "100");
                ChangeRegKey("HKCU:\\Control Panel\\Desktop", "MenuShowDelay", true, pipeline, "string", "100");
            }
            #endregion

            pipeline.Invoke();
            runspace.Close();

            RestartExplorer();

            MessageBox.Show("GAMING tweaks successfuly applied");
        }

        private static void ChangeRegKey(string path, string valueName, bool forcePath, Pipeline pipeline, string valueType, string value)
        {
            if (forcePath)
            {
                pipeline.Commands.AddScript($@"if (-not (Test-Path '{path}')) {{New-Item -Path '{path}' -Force}}");
            }

            if (valueType.ToLower() == "string")
            {
                pipeline.Commands.AddScript($"Set-ItemProperty -Path '{path}' -Name '{valueName}' -Value '{value}'");
            }
            else
            {
                pipeline.Commands.AddScript($"Set-ItemProperty -Path '{path}' -Name '{valueName}' -Value '{value}' -Type {valueType}");
            }
        }
        private static void ChangeScheduledTask(string path, string name, bool enabled)
        {
            Process.Start("schtasks.exe", $"/Change /TN \"{path}\\{name}\" /{enabled}");
        }

        private void ResetToDefault(object sender, EventArgs e)
        {
            NThrottling_CB.Checked = true;
            PThrottling_CB.Checked = true;
            GPUPriority_DD.SelectedItem = "Normal (Default)";
            EnhancedPrecision_CB.Checked = true;
            ReduceHoverTime_CB.Checked = false;
        }
        private void RestartExplorer()
        {
            try
            {
                foreach (Process process in Process.GetProcessesByName("explorer"))
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error restarting Windows Explorer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Plans_BTN_Click(object sender, EventArgs e)
        {
            Main_Form.instance.PPResultsShow();
        }
    }
}
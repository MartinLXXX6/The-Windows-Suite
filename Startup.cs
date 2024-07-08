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

namespace Win_Tweaker
{
    public partial class Startup : UserControl
    {
        public Startup()
        {
            InitializeComponent();
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
        private static void ChangeScheduledTask(string path, string name, string value)
        {
            Process.Start("schtasks.exe", $"/Change /TN \"{path}\\{name}\" /{value}");
        }
        private static void ChangeService(string name, string statusType, Pipeline pipeline)
        {
            pipeline.Commands.AddScript($@"Set-Service -name '{name}' -startupType '{statusType}'");
        }

        private void ResetToDefault(object sender, EventArgs e)
        {
            MicrosoftEdgeStartup_CB.Checked = true;
            SilentInstalls_CB.Checked = true;
        }
        private void Check_BTN_Click(object sender, EventArgs e)
        {

        }
        private void Apply_BTN_Click(object sender, EventArgs e)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();

            #region MicrosoftEdge
            if (MicrosoftEdgeStartup_CB.Checked == true)
            {
                ChangeScheduledTask("", "MicrosoftEdgeUpdateTaskMachineCore", "Enable");
                ChangeScheduledTask("", "MicrosoftEdgeUpdateTaskMachineUA", "Enable");

                ChangeService("MicrosoftEdgeElevationService", "Automatic", pipeline);
                ChangeService("edgeupdate", "Automatic", pipeline);
                ChangeService("edgeupdatem", "Automatic", pipeline);

                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-310093Enabled", true, pipeline, "DWord", "1");

                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\UserARSO\\S-1-5-21-3768265798-2199576006-1648738190-1001", "OptOut", true, pipeline, "DWord", "0");

            }
            else if (MicrosoftEdgeStartup_CB.Checked == false)
            {
                ChangeScheduledTask("", "MicrosoftEdgeUpdateTaskMachineCore", "Disable");
                ChangeScheduledTask("", "MicrosoftEdgeUpdateTaskMachineUA", "Disable");

                ChangeService("MicrosoftEdgeElevationService", "Disable", pipeline);
                ChangeService("edgeupdate", "Disable", pipeline);
                ChangeService("edgeupdatem", "Disable", pipeline);

                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-310093Enabled", true, pipeline, "DWord", "0");

                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\UserARSO\\S-1-5-21-3768265798-2199576006-1648738190-1001", "OptOut", true, pipeline, "DWord", "1");
            }
            #endregion

            #region SilentInstalls
            if (SilentInstalls_CB.Checked == true)
            {
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "ContentDeliveryAllowed", true, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "OemPreInstalledAppsEnabled", false, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "PreInstalledAppsEnabled", false, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "PreInstalledAppsEverEnabled", false, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SilentInstalledAppsEnabled", false, pipeline, "DWord", "1");

                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "StoreAppsOnTaskbar", true, pipeline, "DWord", "1");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Feeds", "ShellFeedsTaskbarViewMode", true, pipeline, "DWord", "1");
            }
            else if (SilentInstalls_CB.Checked == false)
            {
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "ContentDeliveryAllowed", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "OemPreInstalledAppsEnabled", false, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "PreInstalledAppsEnabled", false, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "PreInstalledAppsEverEnabled", false, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SilentInstalledAppsEnabled", false, pipeline, "DWord", "0");

                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "StoreAppsOnTaskbar", true, pipeline, "DWord", "0");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Feeds", "ShellFeedsTaskbarViewMode", true, pipeline, "DWord", "2");
            }
            #endregion

            //Collection<PSObject> results = pipeline.Invoke();
            pipeline.Invoke();
            runspace.Close();

            MessageBox.Show("STARTUP tweaks successfuly applied");
        }
    }
}

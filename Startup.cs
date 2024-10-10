using System.Diagnostics;
using System.Management.Automation.Runspaces;

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
            //using (Runspace runspace = RunspaceFactory.CreateRunspace())
            //{
            //    runspace.Open();
            //    using (Pipeline pipeline = runspace.CreatePipeline())
            //    {
            //        string command = @"
            //    Get-Item -Path HKCU:\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\StartupApproved\Run |
            //    Get-ItemProperty |
            //    ForEach-Object {
            //        $_.PSObject.Properties |
            //        Where-Object {
            //            $_.Name -ne 'PSPath' -and
            //            $_.Name -ne 'PSParentPath' -and
            //            $_.Name -ne 'PSChildName' -and
            //            $_.Name -ne 'PSDrive' -and
            //            $_.Name -ne 'PSProvider'
            //        } |
            //        ForEach-Object {
            //            [PSCustomObject]@{
            //                PSChildName = $_.Name
            //                Value = $_.Value
            //            }
            //        }
            //    }";

            //        pipeline.Commands.AddScript(command);

            //        var results = pipeline.Invoke();

            //        foreach (PSObject result in results)
            //        {
            //            string psChildName = result.Properties["PSChildName"]?.Value?.ToString();

            //            byte[] byteArray = result.Properties["Value"]?.Value as byte[];
            //            string value;
            //            if (byteArray != null)
            //            {
            //                value = System.Text.Encoding.Unicode.GetString(byteArray);
            //            }
            //            else
            //            {
            //                value = result.Properties["Value"]?.Value?.ToString();
            //            }

            //            // Output or process the values
            //            MessageBox.Show($"PSChildName: {psChildName}, Value: {value}");
            //        }

            //        runspace.Close();

            MessageBox.Show("Coming Soon!");
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

                ChangeService("MicrosoftEdgeElevationService", "Manual", pipeline);
                ChangeService("edgeupdate", "Manual", pipeline);
                ChangeService("edgeupdatem", "Manual", pipeline);

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
            }
            else if (SilentInstalls_CB.Checked == false)
            {
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "ContentDeliveryAllowed", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "OemPreInstalledAppsEnabled", false, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "PreInstalledAppsEnabled", false, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "PreInstalledAppsEverEnabled", false, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SilentInstalledAppsEnabled", false, pipeline, "DWord", "0");
            }
            #endregion

            pipeline.Invoke();
            runspace.Close();

            MessageBox.Show("STARTUP tweaks successfuly applied");
        }
    }
}
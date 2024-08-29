using System.Management.Automation.Runspaces;
using System.Diagnostics;

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

            pipeline.Invoke();
            runspace.Close();

            RestartExplorer();

            MessageBox.Show("GAMING tweaks successfuly applied");
        }

        private void Plans_BTN_Click(object sender, EventArgs e)
        {
            Main_Form.instance.PPResultsShow();
        }
        private void Services_BTN_Click(object sender, EventArgs e)
        {
            string[] services = new string[]
            {
                "diagnosticshub.standardcollector.service",
                "DPS",
                "lfsvc",
                "MapsBroker",
                "NetTcpPortSharing",
                "RemoteAccess",
                "SharedAccess",
                "TrkWks",
                "WMPNetworkSvc",
                "XblAuthManager",
                "XblGameSave",
                "XboxNetApiSvc",
                "XboxGipSvc",
                "ndu",
                "WerSvc",
                "Fax",
                "fhsvc",
                "gupdate",
                "gupdatem",
                "stisvc",
                "AJRouter",
                "MSDTC",
                "WpcMonSvc",
                "PhoneSvc",
                "PrintNotify",
                "PcaSvc",
                "WPDBusEnum",
                "seclogon",
                "SysMain",
                "lmhosts",
                "wisvc",
                "FontCache",
                "RetailDemo",
                "ALG",
                "SCardSvr",
                "EntAppSvc",
                "Browser",
                "BthAvctpSvc",
                "SEMgrSvc",
                "PerfHost",
                "BcastDVRUserService_48486de",
                "CaptureService_48486de",
                "cbdhsvc_48486de",
                "RtkBtManServ",
                "HPAppHelperCap",
                "HPDiagsCap",
                "HPNetworkCap",
                "HPSysInfoCap",
                "HpTouchpointAnalyticsService",
                "HvHost",
                "vmickvpexchange",
                "vmicguestinterface",
                "vmicshutdown",
                "vmicheartbeat",
                "vmicvmsession",
                "vmicrdv",
                "vmictimesync"
            };

            List<string> notFoundServices = new List<string>();

            using (Runspace runspace = RunspaceFactory.CreateRunspace())
            {
                runspace.Open();

                foreach (string service in services)
                {
                    using (Pipeline pipeline = runspace.CreatePipeline())
                    {
                        string commandText = $@"
                        $service = Get-Service -Name '{service}' -ErrorAction SilentlyContinue
                        if ($service) {{
                            Set-Service -Name '{service}' -StartupType Manual
                            Write-Output 'Service {service} set to Manual'
                        }} else {{
                            Write-Output 'Service {service} not found'
                        }}";

                        pipeline.Commands.AddScript(commandText);

                        try
                        {
                            var results = pipeline.Invoke();
                            foreach (var result in results)
                            {
                                string resultString = result.ToString();
                                if (resultString.Contains("not found"))
                                {
                                    notFoundServices.Add(resultString);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                }

                runspace.Close();
            }

            if (notFoundServices.Count > 0)
            {
                string errorMessage = "The following services were not found, dont worry some services are for some programs specifically:\n-" + string.Join("\n-", notFoundServices);
                MessageBox.Show(errorMessage);
            }
            else
            {
                MessageBox.Show("All services were set to Manual.");
            };
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
        private static void ChangeService(string name, string statusType, Pipeline pipeline)
        {
            pipeline.Commands.AddScript($@"Set-Service -name '{name}' -startupType '{statusType}'");
        }

        private void ResetToDefault(object sender, EventArgs e)
        {
            NThrottling_CB.Checked = true;
            PThrottling_CB.Checked = true;
            GPUPriority_DD.SelectedItem = "Normal (Default)";
            EnhancedPrecision_CB.Checked = true;
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
    }
}
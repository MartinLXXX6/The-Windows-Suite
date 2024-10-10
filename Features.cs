using System.Diagnostics;
using System.Management.Automation.Runspaces;

namespace Win_Tweaker
{
    public partial class Features : UserControl
    {
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

        public Features()
        {
            InitializeComponent();
        }

        private void Apply_BTN_Click(object sender, EventArgs e)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();

            #region Context_Menu
            if (CM_DDM.SelectedItem == "Enable")
            {
                ChangeRegKey("HKCU:\\SOFTWARE\\CLASSES\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\\InprocServer32", "(Default)", true, pipeline, "string", "");
            }
            else if (CM_DDM.SelectedItem == "Disable")
            {
                pipeline.Commands.AddScript(@"
                if (Test-Path 'HKCU:\SOFTWARE\CLASSES\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32')
                {
                    Remove-Item -Path 'HKCU:\SOFTWARE\CLASSES\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32' -Force
                    Remove-Item -Path 'HKCU:\SOFTWARE\CLASSES\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}' -Force
                }
                elseif (Test-Path 'HKCU:\SOFTWARE\CLASSES\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}')
                {
                    Remove-Item -Path 'HKCU:\SOFTWARE\CLASSES\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}' -Force
                }");
            }
            #endregion

            #region OldExplorerRibbon
            string script;
            string location = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Old File Explorer.lnk";
            string targetPath = "C:\\Windows\\explorer.exe";
            string arguments = "shell:::{26EE0668-A00A-44D7-9371-BEB064C98683}\\5\\::{679f85cb-0220-4080-b29b-5540cc05aab6}";

            if (ExplorerRibbon_DDM.SelectedItem == "Add (Normal Window)")
            {
                script = $@"
                    $com = New-Object -ComObject WScript.Shell
                    $shortcut = $com.CreateShortcut('{location}')
                    $shortcut.TargetPath = '{targetPath}'
                    $shortcut.Arguments = '{arguments}'
                    $shortcut.Description = 'Open QuickAccess/Home with old File Explorer ribbon'
                    $shortcut.WindowStyle = 1
                    $shortcut.Save()
                ";

                pipeline.Commands.AddScript(script);
            }
            else if (ExplorerRibbon_DDM.SelectedItem == "Add (Maximized Window)")
            {
                script = $@"
                    $com = New-Object -ComObject WScript.Shell
                    $shortcut = $com.CreateShortcut('{location}')
                    $shortcut.TargetPath = '{targetPath}'
                    $shortcut.Arguments = '{arguments}'
                    $shortcut.Description = 'Open QuickAccess/Home with old File Explorer ribbon'
                    $shortcut.WindowStyle = 3
                    $shortcut.Save()
                ";

                pipeline.Commands.AddScript(script);
            }
            #endregion

            #region Photo_Viewer
            if (PV_DDM.SelectedItem == "Enable")
            {
                //    pipeline.Commands.AddScript("if (-not (Test-Path 'HKCR:\\Applications\\photoviewer.dll')) {New-Item -Path 'HKCR:\\Applications\\photoviewer.dll' -Force}");
                //    pipeline.Commands.AddScript("if (-not (Test-Path 'HKCR:\\Applications\\photoviewer.dll\\shell')) {New-Item -Path 'HKCR:\\Applications\\photoviewer.dll\\shell' -Force}");

                //    ChangeRegKey("HKCR:\\Applications\\photoviewer.dll\\shell\\open", "MuiVerb", true, pipeline, "string", "@photoviewer.dll,-3043");

                //    ChangeRegKey("HKCR:\\Applications\\photoviewer.dll\\shell\\open\\command", "(Default)", true, pipeline, "ExpandString", "%SystemRoot%\\System32\\rundll32.exe \"%ProgramFiles%\\Windows Photo Viewer\\PhotoViewer.dll\", ImageView_Fullscreen %1");
                //    ChangeRegKey("HKCR:\\Applications\\photoviewer.dll\\shell\\open\\DropTarget", "Clsid", true, pipeline, "string", "{FFE2A43C-56B9-4bf5-9A79-CC6D4285608A}");

                //    ChangeRegKey("HKCR:\\Applications\\photoviewer.dll\\shell\\print", "NeverDefault", true, pipeline, "string", "");

                //    ChangeRegKey("HKCR:\\Applications\\photoviewer.dll\\shell\\print\\command", "(Default)", true, pipeline, "ExpandString", "%SystemRoot%\\System32\\rundll32.exe \"%ProgramFiles%\\Windows Photo Viewer\\PhotoViewer.dll\", ImageView_Fullscreen %1");
                //    ChangeRegKey("HKCR:\\Applications\\photoviewer.dll\\shell\\print\\DropTarget", "Clsid", true, pipeline, "string", "{60fd46de-f830-4894-a628-6fa81bc0190d}");
            }
            else if (PV_DDM.SelectedItem == "Disable")
            {
                //    try
                //    {
                //        pipeline.Commands.AddScript("if (Test-Path 'HKCR:\\Applications\\photoviewer.dll\\shell\\print\\DropTarget') {Remove-Item 'HKCR:\\Applications\\photoviewer.dll\\shell\\print\\DropTarget' -Force}");
                //        pipeline.Commands.AddScript("if (Test-Path 'HKCR:\\Applications\\photoviewer.dll\\shell\\print\\command') {Remove-Item 'HKCR:\\Applications\\photoviewer.dll\\shell\\print\\command' -Force}");
                //        pipeline.Commands.AddScript("if (Test-Path 'HKCR:\\Applications\\photoviewer.dll\\shell\\print') {Remove-Item 'HKCR:\\Applications\\photoviewer.dll\\shell\\print' -Force}");

                //        pipeline.Commands.AddScript("if (Test-Path 'HKCR:\\Applications\\photoviewer.dll\\shell\\open\\DropTarget') {Remove-Item 'HKCR:\\Applications\\photoviewer.dll\\shell\\open\\DropTarget' -Force}");
                //        pipeline.Commands.AddScript("if (Test-Path 'HKCR:\\Applications\\photoviewer.dll\\shell\\open\\command') {Remove-Item 'HKCR:\\Applications\\photoviewer.dll\\shell\\open\\command' -Force}");
                //        pipeline.Commands.AddScript("if (Test-Path 'HKCR:\\Applications\\photoviewer.dll\\shell\\open') {Remove-Item 'HKCR:\\Applications\\photoviewer.dll\\shell\\open' -Force}");

                //        pipeline.Commands.AddScript("if (Test-Path 'HKCR:\\Applications\\photoviewer.dll\\shell') {Remove-Item 'HKCR:\\Applications\\photoviewer.dll\\shell' -Force}");

                //        pipeline.Commands.AddScript("if (Test-Path 'HKCR:\\Applications\\photoviewer.dll') {Remove-Item 'HKCR:\\Applications\\photoviewer.dll' -Force}");
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Error at photi viewer: " + ex);
                //    }
            }
            #endregion

            #region Volume_Layout
            if (VL_DDM.SelectedItem == "Enable")
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\MTCUVC", "EnableMtcUvc", true, pipeline, "DWord", "0");
            }
            else if (VL_DDM.SelectedItem == "Disable")
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\MTCUVC", "EnableMtcUvc", true, pipeline, "DWord", "1");
            }
            #endregion

            #region UninstallApp
            if (UninstallApp_DD.SelectedItem == "Your Phone/Phone Link")
            {
                //pipeline.Commands.AddScript("Import-Module Appx $package = Get-AppxPackage -Name Microsoft.YourPhone -ErrorAction SilentlyContinue\r\n\r\nif ($package) {Remove-AppxPackage $package}");

            }
            else if (UninstallApp_DD.SelectedItem == "OneDrive")
            {
            //    string script2 = @"
            //    $module = Get-Module -ListAvailable Appx | Select-Object -First 1 -ExpandProperty Path;
            //    if ($module) {
            //        try {
            //            Import-Module $module -ErrorAction Stop;
            //            $package = Get-AppxPackage -Name Microsoft.OneDriveSync -ErrorAction SilentlyContinue;
            //            if ($package) {
            //                Remove-AppxPackage -Package $package
            //            } else {
            //                Write-Output 'Package not found or already removed.';
            //            }
            //        } catch {
            //            Write-Output 'Failed to import module or execute command: ' + $_.Exception.Message;
            //        }
            //    } else {
            //        Write-Output 'Appx module not found.';
            //    }
            //";

                //pipeline.Commands.AddScript(script2);
            }
            else if (UninstallApp_DD.SelectedItem == "Get Started & Tips")
            {
                //pipeline.Commands.AddScript("Import-Module Appx $package = Get-AppxPackage -Name Microsoft.Getstarted -ErrorAction SilentlyContinue\r\n\r\nif ($package) {Remove-AppxPackage $package}");
            }
            else if (UninstallApp_DD.SelectedItem == "Get Help")
            {
                //pipeline.Commands.AddScript("Import-Module Appx $package = Get-AppxPackage -Name Microsoft.GetHelp -ErrorAction SilentlyContinue\r\n\r\nif ($package) {Remove-AppxPackage $package}");

            }
            else if (UninstallApp_DD.SelectedItem == "People")
            {
                //pipeline.Commands.AddScript("Import-Module Appx $package = Get-AppxPackage -Name Microsoft.People -ErrorAction SilentlyContinue\r\n\r\nif ($package) {Remove-AppxPackage $package}");

            }
            #endregion

            if (pipeline.Commands.Count == 0)
            {
                runspace.Close();
                MessageBox.Show("No tweaks were selected, make sure that:\n+You havent selected a WIP feature\n+You have selected a feature or more that one");
                return;
            }

            pipeline.Invoke();
            runspace.Close();

            RestartExplorer();

            MessageBox.Show("FEATURE tweaks successfuly applied");
        }

        private void ResetToDefault(object sender, EventArgs e)
        {
            VL_DDM.SelectedItem = "Disable";
            CM_DDM.SelectedItem = "Disable";
            PV_DDM.SelectedItem = "Disable";
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

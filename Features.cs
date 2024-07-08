using Microsoft.Win32;
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
            if(CM_DDM.SelectedItem == "Enable")
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

            }
            else if (VL_DDM.SelectedItem == "Disable")
            {

            }
            #endregion

            //Collection<PSObject> results = pipeline.Invoke();
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

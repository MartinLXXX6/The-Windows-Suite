﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Diagnostics;
using System.Security.Policy;

namespace Win_Tweaker
{
    public partial class Personalization : UserControl
    {
        public Personalization()
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

        private void Apply_BTN_Click(object sender, EventArgs e)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();

            #region TaskbarSize
            if (TaskbarSize_DD.SelectedItem == "Huge")
            {
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "TabletPostureTaskbar", true, pipeline, "DWord", "1");
            }
            else if (TaskbarSize_DD.SelectedItem == "Medium (Default)")
            {
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "TabletPostureTaskbar", true, pipeline, "DWord", "0");
            }
            #endregion

            #region DisableSearchBoxHighlights
            if (DynamicSearchBox_CB.Checked == false)
            {
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SearchSettings", "IsDynamicSearchBoxEnabled", true, pipeline, "DWord", "0");
            }
            else if (DynamicSearchBox_CB.Checked == true)
            {
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SearchSettings", "IsDynamicSearchBoxEnabled", true, pipeline, "DWord", "1");
            }
            #endregion

            #region WebBrowsingOnSearchBox
            if (WebBrowsingOnSearchBox_CB.Checked == false)
            {
                ChangeRegKey("HKCU:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", "DisableSearchBoxSuggestions", true, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search", "BingSearchEnabled", true, pipeline, "DWord", "0");
            }
            else if (WebBrowsingOnSearchBox_CB.Checked == true)
            {
                ChangeRegKey("HKCU:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", "DisableSearchBoxSuggestions", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search", "BingSearchEnabled", true, pipeline, "DWord", "1");
            }
            #endregion

            #region LockScreen
            if (LockScreen_CB.Checked == false)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Personalization", "NoLockScreen", true, pipeline, "DWord", "1");
            }
            else if (LockScreen_CB.Checked == true)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Personalization", "NoLockScreen", true, pipeline, "DWord", "0");
            }
            #endregion

            #region SnapAssist
            if (SnapAssist_CB.Checked == true)
            {
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "EnableSnapAssistFlyout", true, pipeline, "DWord", "1");
            }
            else if (SnapAssist_CB.Checked == false)
            {
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "EnableSnapAssistFlyout", true, pipeline, "DWord", "0");
            }
            #endregion

            #region VeroboseStatus
            if (VeroboseStatus_CB.Checked == false)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "VerboseStatus", true, pipeline, "DWord", "0");
            }
            else if (VeroboseStatus_CB.Checked == true)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "VerboseStatus", true, pipeline, "DWord", "1");
            }
            #endregion

            pipeline.Invoke();
            runspace.Close();

            RestartExplorer();

            MessageBox.Show("PERSONALIZATION tweaks successfuly applied");
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
        private void ResetToDefault(object sender, EventArgs e)
        {
            TaskbarSize_DD.SelectedItem = "Medium (Default)";
            DynamicSearchBox_CB.Checked = true;
            WebBrowsingOnSearchBox_CB.Checked = true;
            LockScreen_CB.Checked = true;
            SnapAssist_CB.Checked = true;
            VeroboseStatus_CB.Checked = false;
        }
    }
}
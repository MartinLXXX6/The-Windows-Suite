﻿using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;
using System.Management.Automation;

namespace Win_Tweaker
{
    public partial class PP_Results : UserControl
    {
        public PP_Results()
        {
            InitializeComponent();
        }

        private void Close_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private String txt = "";
        private bool PPChanged = false;

        private void Check_BTN_Click(object sender, EventArgs e)
        {
            CheckPP();
        }

        private void Apply_BTN_Click(object sender, EventArgs e)
        {
            CheckPP();
            CheckUserInput();

            if (PPChanged == true)
            {
                Runspace runspace = RunspaceFactory.CreateRunspace();
                runspace.Open();
                Pipeline pipeline = runspace.CreatePipeline();

                pipeline.Commands.AddScript($"powercfg /S '{InputPlan_TB.Text.ToString()}'");

                pipeline.Invoke();
                runspace.Close();

                MessageBox.Show("Done, check to make sure the correct plan has been applied. In case the same plan is active make sure to:\n+ Copy the GUID exacly and with no spaces\n+ Check frequently");
                PPChanged = false;
            }
            else
            {
                MessageBox.Show("Not Found, make sure to:\n+ Copy the GUID exacly and with no spaces\n+ Check frequently");
            }
        }
        private void Delete_BTN_Click(object sender, EventArgs e)
        {
            CheckPP();
            CheckUserInput();

            if (PPChanged == true)
            {
                Runspace runspace = RunspaceFactory.CreateRunspace();
                runspace.Open();
                Pipeline pipeline = runspace.CreatePipeline();

                pipeline.Commands.AddScript($"powercfg -delete '{InputPlan_TB.Text.ToString()}'");

                pipeline.Invoke();
                runspace.Close();

                MessageBox.Show("Done, check to make sure the correct plan has been removed.");
                PPChanged = false;
            }
            else
            {
                MessageBox.Show("Not Found, make sure to:\n+ Copy the GUID exacly and with no spaces\n+ Check frequently");
            }
        }

        private void CheckPP()
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();

            pipeline.Commands.AddScript("powercfg -list");

            Collection<PSObject> results = pipeline.Invoke();

            txt = results[1].ToString() + " | (Select and press 'Ctrl + C' to copy a GUID):\n";

            for (int i = 3; i < results.Count; i++)
            {
                txt += "\n-" + results[i].ToString();
            }

            PPResults_RTB.Text = txt;

            runspace.Close();
        }
        private bool FindSubstring(string text, string substring)
        {
            // Split the text into words
            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Iterate through the words and check if any matches the substring exactly
            foreach (string word in words)
            {
                if (word.Equals(substring, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
        private void CheckUserInput()
        {
            for (int i = 1; i < txt.ToString().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length; i++)
            {
                if (FindSubstring(txt.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)[i], InputPlan_TB.Text))
                {
                    PPChanged = true;
                    break;
                }
                else
                {
                    PPChanged = false;
                }
            }
        }

        private void PSaving_BTN_Click(object sender, EventArgs e)
        {
            //Runspace runspace = RunspaceFactory.CreateRunspace();
            //runspace.Open();
            //Pipeline pipeline = runspace.CreatePipeline();



            //pipeline.Invoke();
            //runspace.Close();
        }

        private void Balanced_BTN_Click(object sender, EventArgs e)
        {
            //Runspace runspace = RunspaceFactory.CreateRunspace();
            //runspace.Open();
            //Pipeline pipeline = runspace.CreatePipeline();



            //pipeline.Invoke();
            //runspace.Close();
        }

        private void HPerformance_BTN_Click(object sender, EventArgs e)
        {
            //Runspace runspace = RunspaceFactory.CreateRunspace();
            //runspace.Open();
            //Pipeline pipeline = runspace.CreatePipeline();

            //string script = @"
            //    $planName = 'High Performance'
            //    $newPlanGUID = powercfg -duplicatescheme 381b4222-f694-41f0-9685-ff5bb260df2e
            //    $newPlanGUID = $newPlanGUID -replace '[{}]', ''

            //    powercfg -change standby-timeout-ac 0
            //    powercfg -change standby-timeout-dc 0
            //    powercfg /change monitor - timeout - ac 0
            //    powercfg /change monitor - timeout - dc 0
            //    powercfg -change processor-throttle-dc 85
            //    powercfg -change processor-throttle-ac 85
            //    powercfg -change disk-timeout-dc 0
            //    powercfg -change disk-timeout-ac 0
            //    powercfg -change hibernate-timeout-dc 0
            //    powercfg -change hibernate-timeout-ac 0

            //    powercfg -changename $newPlanGUID $planName

            //    powercfg -setactive $planGUID
            //    Read-Host """;

            //pipeline.Commands.AddScript(script);

            //pipeline.Invoke();
            //runspace.Close();
        }

        private void UltraHighPerformance_BTN_Click(object sender, EventArgs e)
        {
            //Runspace runspace = RunspaceFactory.CreateRunspace();
            //runspace.Open();
            //Pipeline pipeline = runspace.CreatePipeline();

            //string script = @"
            //try {
            //    powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61

            //    $ultimatePlanLine = powercfg -list | Select-String -Pattern 'Ultimate Performance'

            //    if ($ultimatePlanLine) {
            //        $ultimatePlanGUID = $ultimatePlanLine.Line.Split()[3]
            //        powercfg -setactive $ultimatePlanGUID
            //    } else {
            //        throw 'Ultimate Performance power plan not found.'
            //    }
            //}
            //catch {
            //    Write-Output $_.Exception.Message
            //}";


            //pipeline.Commands.AddScript(script);

            //try
            //{
            //    Collection<PSObject> results = pipeline.Invoke();
            //    foreach (PSObject obj in results)
            //    {
            //        MessageBox.Show(obj.ToString());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}");
            //}
            //finally
            //{
            //    runspace.Close();
            //}
        }
    }
}
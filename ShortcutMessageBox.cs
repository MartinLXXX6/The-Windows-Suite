using System.Management.Automation.Runspaces;
using The_Windows_Suite.Properties;

namespace Win_Tweaker
{
    public partial class ShortcutMessageBox : Form
    {
        public ShortcutMessageBox()
        {
            InitializeComponent();
        }

        private void OK_BTN_Click(object sender, EventArgs e)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();

            string executablePath = Application.ExecutablePath;

            #region DesktopShort
            if (DesktopShort_CB.Checked == true)
            {
                string script = "$com = New-Object -ComObject WScript.Shell; " +
                        "$shortcut = $com.CreateShortcut(\"$Env:USERPROFILE\\Desktop\\The Windows Suite.lnk\"); " +
                        $"$shortcut.TargetPath = \"{executablePath}\"; " +
                        "$shortcut.Save();";

                pipeline.Commands.AddScript(script);
            }
            #endregion

            #region AppShort
            if (appShort_CB.Checked == true)
            {
                string script = "$com = New-Object -ComObject WScript.Shell; " +
                        "$shortcut = $com.CreateShortcut(\"$Env:USERPROFILE\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\The Windows Suite.lnk\"); " +
                        $"$shortcut.TargetPath = \"{executablePath}\"; " +
                        "$shortcut.Save();";

                pipeline.Commands.AddScript(script);
            }
            #endregion

            #region DontShowAgain
            if (DontSA_CB.Checked == true)
            {
                Settings.Default["ShortcutMessage"] = "False";
            }
            else
            {
                Settings.Default["ShortcutMessage"] = "True";
            }
            Settings.Default.Save();
            #endregion

            if(pipeline.Commands.Count != 0)
            {
                pipeline.Invoke();
            }
            runspace.Close();

            this.Close();
        }
    }
}
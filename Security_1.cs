using System.Diagnostics;

namespace Win_Tweaker
{
    public partial class Security_1 : UserControl
    {
        public Security_1()
        {
            InitializeComponent();
        }

        private void SignInSett_BTN_Click(object sender, EventArgs e)
        {
            Process.Start("netplwiz.exe");
        }

        private void Next_BTN_Click(object sender, EventArgs e)
        {
            Main_Form.instance.OpenPage2();
        }
    }
}

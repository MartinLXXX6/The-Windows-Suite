using The_Windows_Suite.Properties;

namespace Win_Tweaker
{
    public partial class Main_Form : Form
    {
        public static Main_Form instance;
        private static ShortcutMessageBox shortcutMessageBox;

        public Main_Form()
        {
            InitializeComponent();

            instance = this;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            if (Settings.Default["ShortcutMessage"].ToString() == "True")
            {
                shortcutMessageBox = new ShortcutMessageBox();
                shortcutMessageBox.ShowDialog();
            }

            home1.Show();
            pP_Results1.Hide();
            privacy1.Hide();
            personalization1.Hide();
            optimization1.Hide();
            startup1.Hide();
            features1.Hide();
            security_11.Hide();
            security_21.Hide();
        }

        private void Home_BTN_Click(object sender, EventArgs e)
        {
            privacy1.Hide();
            personalization1.Hide();
            home1.Show();
            optimization1.Hide();
            startup1.Hide();
            features1.Hide();
            security_11.Hide();
            security_21.Hide();
        }

        private void Personalization_BTN_Click(object sender, EventArgs e)
        {
            privacy1.Hide();
            personalization1.Show();
            home1.Hide();
            optimization1.Hide();
            startup1.Hide();
            features1.Hide();
            security_11.Hide();
            security_21.Hide();
        }

        private void Privacy_BTN_Click(object sender, EventArgs e)
        {
            privacy1.Show();
            personalization1.Hide();
            home1.Hide();
            optimization1.Hide();
            startup1.Hide();
            features1.Hide();
            security_11.Hide();
            security_21.Hide();
        }

        private void Optimization_BTN_Click(object sender, EventArgs e)
        {
            optimization1.Show();
            personalization1.Hide();
            home1.Hide();
            privacy1.Hide();
            startup1.Hide();
            features1.Hide();
            security_11.Hide();
            security_21.Hide();
        }

        private void Startup_BTN_Click(object sender, EventArgs e)
        {
            startup1.Show();
            optimization1.Hide();
            personalization1.Hide();
            home1.Hide();
            privacy1.Hide();
            features1.Hide();
            security_11.Hide();
            security_21.Hide();
        }

        private void Features_BTN_Click(object sender, EventArgs e)
        {
            features1.Show();
            startup1.Hide();
            optimization1.Hide();
            personalization1.Hide();
            home1.Hide();
            privacy1.Hide();
            security_11.Hide();
            security_21.Hide();
        }

        private void Security_BTN_Click(object sender, EventArgs e)
        {
            security_11.Show();
            features1.Hide();
            startup1.Hide();
            optimization1.Hide();
            personalization1.Hide();
            home1.Hide();
            privacy1.Hide();
            security_21.Hide();
        }

        public void PPResultsShow()
        {
            pP_Results1.Show();
        }

        public void OpenPage1()
        {
            security_11.Show();
            security_21.Hide();
            //security_31.Hide();
        }

        public void OpenPage2()
        {
            security_11.Hide();
            security_21.Show();
            //security_31.Hide();
        }

        public void OpenPage3()
        {
            //security_11.Hide();
            //security_21.Hide();
            //security_31.Show();
        }
    }
}

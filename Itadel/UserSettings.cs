using System;
using System.Windows.Forms;

namespace Itadel
{
    public partial class UserSettings : Form
    {
        public UserSettings()
        {
            InitializeComponent();
        }

        // Event triggered when form is loaded that gets which boxes should be checked and retrives the Username and Domain
        private void UserSettings_Load(object sender, EventArgs e)
        {
            UserAccess.Checked = Properties.Settings.Default.UserAccess;
            LocalAccess.Checked = Properties.Settings.Default.LocalAccess;
            DomainAccess.Checked = Properties.Settings.Default.DomainAccess;
            AutoAccess.Checked = Properties.Settings.Default.AutostartBtn;
            LblCName.Text = Environment.UserName;
            LblCDomain.Text = Environment.UserDomainName;
            LblCName.Size = LblCDomain.Size;
        }

        // Event triggered when the settings is closing
        private void UserSettings_Close(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.UserAccess = UserAccess.Checked;
            Properties.Settings.Default.LocalAccess = LocalAccess.Checked;
            Properties.Settings.Default.DomainAccess = DomainAccess.Checked;
            Properties.Settings.Default.AutostartBtn = AutoAccess.Checked;
            Properties.Settings.Default.Autostart = LocalAccess.Checked || UserAccess.Checked ? AutoAccess.Checked : false;
            Properties.Settings.Default.AllowSettings = Settings.Checked;
            Properties.Settings.Default.Save();
        }

        // Event triggered when the close button is clicked that closes the application
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event triggered when the start button is clicked that saves the settings and opens the Lockscreen
        private void StartBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserAccess = UserAccess.Checked;
            Properties.Settings.Default.LocalAccess = LocalAccess.Checked;
            Properties.Settings.Default.DomainAccess = DomainAccess.Checked;
            Properties.Settings.Default.AutostartBtn = AutoAccess.Checked;
            Properties.Settings.Default.Autostart = LocalAccess.Checked || UserAccess.Checked ? AutoAccess.Checked : false;
            Properties.Settings.Default.AllowSettings = Settings.Checked;
            Properties.Settings.Default.Save();
            Hide();
            Login Login = new Login();
            Login.Show();
        }

        /* Event triggered when UserAccess is clicked 
         * Makes the buttons behave is as they were radio buttons while still possible to uncheck */
        private void UserAccessBtn_Click(object sender, EventArgs e)
        {
            if (UserAccess.Checked)
            {
                LocalAccess.Checked = false;
                AutoAccess.Visible = true;
            }
            if (!LocalAccess.Checked && !UserAccess.Checked)
                AutoAccess.Visible = false;
        }

        /* Event triggered when LocalAccess is clicked 
         * Makes the buttons behave is as they were radio buttons while still possible to uncheck */
        private void LocalAccessBtn_Click(object sender, EventArgs e)
        {
            if (LocalAccess.Checked)
            {
                UserAccess.Checked = false;
                AutoAccess.Visible = true;
            }
            if (!LocalAccess.Checked && !UserAccess.Checked)
                AutoAccess.Visible = false;
        }
    }
}

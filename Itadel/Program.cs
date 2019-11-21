using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Itadel
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Retrives argument that app opens with
            string[] Args = Environment.GetCommandLineArgs();

            bool UL = false;

            bool Again = true;
            // Helper to determine which form opens
            bool Auto = false;

            bool OpenOnSettings = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Starts the other Startup.exe that watches exitcodes and handles start on boot
            Process[] startup = Process.GetProcessesByName("Startup");
            if (startup.Length == 0) // Check if the Startup.exe is running
            {
                try
                {
                    Process.Start("Startup.exe"); // If not, then run
                }
                catch
                {

                }
            }

            // Uses arguments to decide with Screen to open on
            foreach (string Arg in Args)
            {
                if (Again)
                {
                    switch (Arg)
                    {
                        case "-Q": // If opened by Startup
                            Auto = true;
                            break;
                        case "-D":
                            Properties.Settings.Default.DomainAccess = true;
                            break;
                        case "-S":
                            Properties.Settings.Default.Autostart = true;
                            Properties.Settings.Default.AutostartBtn = true;
                            break;
                        case "-U":
                            if (!UL)
                            {
                                UL = true;
                                Properties.Settings.Default.UserAccess = true;
                                Properties.Settings.Default.LocalAccess = false;
                            }
                            break;
                        case "-L":
                            if (!UL)
                            {
                                UL = true;
                                Properties.Settings.Default.LocalAccess = true;
                                Properties.Settings.Default.UserAccess = false;
                            }
                            break;
                        case "-A":
                            Properties.Settings.Default.AllowSettings = true;
                            break;
                        case "-O":
                            OpenOnSettings = true;
                            break;
                        case "-RESET":
                            Again = false;
                            Properties.Settings.Default.DomainAccess = false;
                            Properties.Settings.Default.Autostart = false;
                            Properties.Settings.Default.AutostartBtn = false;
                            Properties.Settings.Default.LocalAccess = false;
                            Properties.Settings.Default.UserAccess = false;
                            Properties.Settings.Default.AllowSettings = false;
                            OpenOnSettings = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            Properties.Settings.Default.Save();

            // 
            if (Auto)
            {
                if (Properties.Settings.Default.Autostart)
                    Application.Run(new Login());
                else
                    Application.Exit();
            }
            else
            {
                if (OpenOnSettings)
                    Application.Run(new UserSettings());
                else
                    Application.Run(new Login());
            }
        }
    }
}

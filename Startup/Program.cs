using System;
using IWshRuntimeLibrary;
using System.Reflection;
using System.Diagnostics;
using System.Threading;

namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            var Folder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            var wsh = new IWshShell_Class();

            // Creates a copy of the application handling the startup procedure
            string Startup = Folder + @"\\Itadel-Lock-Shortcut.lnk";

            if (!System.IO.File.Exists(Startup))
            {
                IWshShortcut Shortcut = wsh.CreateShortcut(Startup) as IWshShortcut;
                Shortcut.TargetPath = Assembly.GetExecutingAssembly().Location;
                Shortcut.Save();
            }

            Process[] Itadel = Process.GetProcessesByName("Itadel");
            if (Itadel.Length == 0)
            {
                /* Wait 30000 milliseconds (30seconds) then open the lockscreen 
                 * This is used to secure that bootup is able to finish before the screen is locked */
                Thread.Sleep(millisecondsTimeout: 30000);
                // The application settings to open the Lockscreen in case of autostart selected
                ProcessStartInfo itadel = new ProcessStartInfo
                {
                    CreateNoWindow = false,
                    UseShellExecute = false,
                    FileName = "Itadel.exe",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = System.IO.Directory.GetCurrentDirectory() + " " + "-Q",
                };

                try
                {
                    Process.Start(itadel);
                    Thread.Sleep(millisecondsTimeout: 5000);
                    Environment.Exit(1);
                }
                catch
                {
                    Environment.Exit(1);
                }
            }
            else  // If itadel is already open, dont open anything but watch the proccess for exit
            {
                foreach (Process Proc in Itadel)
                {
                    if (Proc.ProcessName == "Itadel")
                    {
                        Proc.WaitForExit();
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}

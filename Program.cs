using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Microsoft.Win32;

namespace SSConfig
{
    static class Program
    {
        public const string Version = "1 Beta";
        public static RegistryKey MainRegistry;
        public static bool DebugShowIcons = true;
        public static bool DebugWriteRegistry = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            RegistryKey Software = Registry.CurrentUser.OpenSubKey("Software");

            if (Software.OpenSubKey("LSC") == null)
            {
                MessageBox.Show("Second System is not installed. The application will now quit.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DebugWriteRegistry == false)
            {
                MessageBox.Show("SSConfig has been compiled with registry writes disabled. You can reenable registry writes in the Debug menu tab.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MainRegistry = Software.OpenSubKey("LSC").OpenSubKey("SecondSystem", true);
            MainSettings defaultset = new MainSettings(MainRegistry);
            Profile.InitializeProfileList(MainRegistry);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainWindow Window = new MainWindow(defaultset);

            Application.Run(Window);

        }
    }
}

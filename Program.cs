using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Microsoft.Win32;

namespace SSConfig
{
    static class Program
    {
        public const string Version = "1 Preliminary";
        public const string TargetSSVer = "3.1";
        public const int DataVersion = 1;
        public static RegistryKey MainRegistry;
        public static bool DebugShowIcons = true;
        public static bool DebugWriteRegistry = true;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            RegistryKey Software = Registry.CurrentUser.OpenSubKey("Software");

            if (Software.OpenSubKey("LSC") == null)
            {
                RegistryKey RegContext = Software.OpenSubKey("Classes").OpenSubKey("exefile").OpenSubKey("shell", true);
                RegistryKey SSNewMenu = RegContext.OpenSubKey("Run with Second System", true);
                if (SSNewMenu != null)
                {
                    SSNewMenu.Dispose();
                    RegContext.DeleteSubKeyTree("Run with Second System");
                    MessageBox.Show("Second System was uninstalled with drop-down context menu left enabled. The drop-down menu has been removed for your convenience.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                RegContext.Dispose();
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

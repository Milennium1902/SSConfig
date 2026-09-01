using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using Microsoft.Win32;

namespace SSConfig
{
    public class MainSettings
    {

        //STATIC STUFF

        public static List<string> GetRegisteredApps()
        {
            List<string> apps = new List<string>();
            foreach (string key in Program.MainRegistry.GetValueNames())
            {
                if (key.EndsWith(".exe"))
                {
                    apps.Add(key);
                }
            }
            return apps;
        }

        //NORMAL STUFF

        public MainSettings(RegistryKey MainRegistry)
        {
            DefaultProfile = MainRegistry.GetValue("DefaultProfile", "DefaultConfig").ToString();
            NewContextMenu = MainRegistry.GetValue("NewContextMenu", 0).ToString() == "1";
            SecondSystemPath = MainRegistry.GetValue("SecondSystemPath").ToString();
            SecondSystemExec = MainRegistry.GetValue("SecondSystemExec").ToString();
        }

        public string DefaultProfile
        {
            get;
            set;
        }
        public bool NewContextMenu
        {
            get;
            set;
        }
        public string SecondSystemPath
        {
            get;
            set;
        }
        public string SecondSystemExec
        {
            get;
            set;
        }

        public void SaveToRegistry()
        {
            if (Program.DebugWriteRegistry == false)
            {
                return;
            }
            Program.MainRegistry.SetValue("DefaultProfile", DefaultProfile);

            RegistryKey RegContext = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Classes").OpenSubKey("exefile").OpenSubKey("shell", true);
            RegistryKey SSNewMenu = RegContext.OpenSubKey("Run with Second System", true);

            if (NewContextMenu == true)
            {
                Program.MainRegistry.SetValue("NewContextMenu", 1, RegistryValueKind.DWord);
                if (SSNewMenu == null)
                {
                    SSNewMenu = RegContext.CreateSubKey("Run with Second System");
                }
                else
                {
                    SSNewMenu.DeleteSubKeyTree("shell");
                }

                SSNewMenu.SetValue("SubCommands", "", RegistryValueKind.String);
                RegistryKey Shell = SSNewMenu.CreateSubKey("shell");

                foreach (Profile p in Profile.ProfileList)
                {
                    RegistryKey NewEntry = Shell.CreateSubKey(p.Name);
                    NewEntry.SetValue("", p.FriendlyName);
                    RegistryKey Command = NewEntry.CreateSubKey("Command");
                    Command.SetValue("", '"' + this.SecondSystemExec + "\" " + p.Name + " \"%1\" %*");

                    NewEntry.Dispose();
                    Command.Dispose();
                }

                RegistryKey DisableEntry = Shell.CreateSubKey("ZZZZZ_Passive"); //context menu entries are sorted alphabetically so this should force ts to the bottom. also this looks like ass /shrug
                DisableEntry.SetValue("", "Run without Second System");
                RegistryKey DisableCmd = DisableEntry.CreateSubKey("Command");
                DisableCmd.SetValue("", '"' + this.SecondSystemExec + "\" " + "Passive" + " \"%1\" %*");

                DisableEntry.Dispose();
                DisableCmd.Dispose();

                SSNewMenu.Dispose();
            }
            else
            {
                Program.MainRegistry.SetValue("NewContextMenu", 0, RegistryValueKind.DWord);

                if (SSNewMenu != null)
                {
                    SSNewMenu.Dispose();
                    RegContext.DeleteSubKeyTree("Run with Second System");
                }
            }

            RegContext.Dispose();
            
        }

    }
}

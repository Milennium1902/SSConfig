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

            if (NewContextMenu == true)
            {
                Program.MainRegistry.SetValue("NewContextMenu", 1, RegistryValueKind.DWord);
            }
            else
            {
                Program.MainRegistry.SetValue("NewContextMenu", 0, RegistryValueKind.DWord);
            }
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Win32;

using System.Xml.Serialization;
using System.IO;

namespace SSConfig
{
    public class Profile
    {
        //STATIC STUFF

        public static List<Profile> ProfileList
        {
            get;
            set;
        }
        public static void InitializeProfileList(RegistryKey MainRegistry)
        {
            ProfileList = new List<Profile>();
            foreach (string rawname in MainRegistry.GetSubKeyNames())
            {
                if (!rawname.EndsWith("_Config"))
                {
                    continue;
                }

                int nameLength = rawname.IndexOf("_Config");
                string name = rawname.Remove(nameLength);

                if (name.Equals("Shell"))
                {
                    continue;
                }

                RegistryKey x64modules = MainRegistry.OpenSubKey(name + "_Modulex64", true);
                RegistryKey x86modules = MainRegistry.OpenSubKey(name + "_Modulex86", true);
                RegistryKey config = MainRegistry.OpenSubKey(name + "_Config", true);
                ProfileList.Add(new Profile(name, x64modules, x86modules, config));
            }
        }

        public static List<string> GetValidProfileNames()
        {
            List<string> names = new List<string>();
            names.Add("Passive");
            foreach (Profile profile in ProfileList)
            {
                names.Add(profile.Name);
            }
            names.Add("Shell");
            return names;
        }

        public static Profile GetProfileWithName(string Name)
        {
            foreach (Profile prof in ProfileList)
            {
                if (prof.Name == Name)
                {
                    return prof;
                }
            }

            return null;
        }

        //NORMAL STUFF

        public Profile(string Name, RegistryKey x64modules, RegistryKey x86modules, RegistryKey config)
        {
            this.Name = Name;

            BuildNumber = (int)config.GetValue("BuildNumber", 0);
            MajorVersion = (int)config.GetValue("MajorVersion", 0);
            MinorVersion = (int)config.GetValue("MinorVersion", 0);
            PlatformID = (int)config.GetValue("PlatformID", 2);

            int csd = (int)config.GetValue("CSDVersionInt", 0);
            if (csd % 256 == 0)
            {
                CSDVersion = csd / 256;
            }

            DataVersion = Program.DataVersion;

            this.RegConfig = config;
            this.Regx86modules = x86modules;
            this.Regx64modules = x64modules;

            FriendlyName = (string)config.GetValue("FriendlyName");
            if (FriendlyName == null)
            {
                switch (Name)
                {
                    case "DefaultConfig":
                        FriendlyName = "Windows 10 mode";
                        break;

                    case "Win10NoDWrite":
                        FriendlyName = "Windows 10 mode (no DirectWrite)";
                        break;

                    case "D3D11Game":
                        FriendlyName = "Direct3D11 Enhanced mode";
                        break;

                    case "Shell":
                        FriendlyName = "Internal - do not edit this profile.";
                        break;

                    case "Win11Config":
                        FriendlyName = "Windows 11 mode";
                        break;

                    case "Win7Config":
                        FriendlyName = "Windows 7 mode";
                        break;

                    case "Win81Config":
                        FriendlyName = "Windows 8.1 mode";
                        break;

                    default:
                        FriendlyName = Name;
                        break;
                }
            }

            Modules64 = new Dictionary<string, string>();
            Modules86 = new Dictionary<string, string>();
            foreach (string DllName in x64modules.GetValueNames())
            {
                Modules64.Add(DllName, x64modules.GetValue(DllName).ToString());
            }
            foreach (string DllName in x86modules.GetValueNames())
            {
                Modules86.Add(DllName, x86modules.GetValue(DllName).ToString());
            }


        }

        public Profile(Profile OgProfile, string Name)
        {
            this.Name = Name;
            BuildNumber = OgProfile.BuildNumber;
            MajorVersion = OgProfile.MajorVersion;
            MinorVersion = OgProfile.MinorVersion;
            FriendlyName = OgProfile.FriendlyName;
            PlatformID = OgProfile.PlatformID;
            CSDVersion = OgProfile.CSDVersion;

            DataVersion = Program.DataVersion;

            Modules64 = new Dictionary<string, string>();
            Modules86 = new Dictionary<string, string>();

            foreach(string OgDll in OgProfile.Modules64.Keys)
            {
                Modules64.Add(OgDll, OgProfile.Modules64[OgDll]);
            }
            foreach (string OgDll in OgProfile.Modules86.Keys)
            {
                Modules86.Add(OgDll, OgProfile.Modules86[OgDll]);
            }
            CreateNewRegistry();
        }

        public Profile(string Name)
        {
            this.Name = Name;
            FriendlyName = "New profile";
            BuildNumber = 0;
            MajorVersion = 0;
            MinorVersion = 0;
            PlatformID = 2;
            CSDVersion = 0;
            DataVersion = Program.DataVersion;
            Modules64 = new Dictionary<string, string>();
            Modules86 = new Dictionary<string, string>();
            CreateNewRegistry();
        }

        public Profile()
        {
           
        }

        private RegistryKey RegConfig;
        private RegistryKey Regx86modules;
        private RegistryKey Regx64modules;

        [Browsable(false)]
        public string Name
        {
            get;
            set;
        }
        public int BuildNumber
        {
            get;
            set;
        }
        public int MajorVersion
        {
            get;
            set;
        }
        public int MinorVersion
        {
            get;
            set;
        }
        public string FriendlyName
        {
            get;
            set;
        }
        public int PlatformID
        {
            get;
            set;
        }
        public int CSDVersion
        {
            get;
            set;
        }

        [Browsable(false)]
        [XmlIgnore]
        public Dictionary<string, string> Modules64
        {
            get;
            set;
        }
        [Browsable(false)]
        [XmlIgnore]
        public Dictionary<string, string> Modules86
        {
            get;
            set;
        }

        [Browsable(false)]
        public List<DictEntry> XML_Modules64 { get; set; }
        [Browsable(false)]
        public List<DictEntry> XML_Modules86 { get; set; }
        [Browsable(false)]
        public int DataVersion { get; set; }

        private void CreateNewRegistry()
        {
            if (Program.DebugWriteRegistry == false)
            {
                return;
            }

            RegConfig = Program.MainRegistry.CreateSubKey(this.Name + "_Config");
            Regx64modules = Program.MainRegistry.CreateSubKey(this.Name + "_Modulex64");
            Regx86modules = Program.MainRegistry.CreateSubKey(this.Name + "_Modulex86");

            SaveToRegistry();
            foreach (string dll in Modules64.Keys)
            {
                Regx64modules.SetValue(dll, Modules64[dll]);
            }
            foreach (string dll in Modules86.Keys)
            {
                Regx86modules.SetValue(dll, Modules86[dll]);
            }
        }

        public void SaveToRegistry()
        {
            if (Program.DebugWriteRegistry == false)
            {
                return;
            }

            RegConfig.SetValue("BuildNumber", this.BuildNumber);
            RegConfig.SetValue("MajorVersion", this.MajorVersion);
            RegConfig.SetValue("MinorVersion", this.MinorVersion);
            RegConfig.SetValue("FriendlyName", this.FriendlyName, RegistryValueKind.String);
            RegConfig.SetValue("PlatformID", this.PlatformID);
            RegConfig.SetValue("CSDVersionInt", this.CSDVersion * 256);
        }

        public void UpdateModule(string ModuleType, string ImportName, string WrapperName)
        {
            Dictionary<string, string> selectedList;
            RegistryKey selectedKey;
            if (ModuleType == "64")
            {
                selectedList = Modules64;
                selectedKey = Regx64modules;
            }
            else
            {
                selectedList = Modules86;
                selectedKey = Regx86modules;
            } //kill me


            if (selectedList.ContainsKey(ImportName) == false)
            {
                selectedList.Add(ImportName, WrapperName);
            }
            else
            {
                selectedList[ImportName] = WrapperName;
            }

            if (Program.DebugWriteRegistry == true)
            {
                selectedKey.SetValue(ImportName, WrapperName);
            }
        }

        public void RemoveModule(string ModuleType, string ImportName)
        {
            Dictionary<string, string> selectedList;
            RegistryKey selectedKey;
            if (ModuleType == "64")
            {
                selectedList = Modules64;
                selectedKey = Regx64modules;
            }
            else
            {
                selectedList = Modules86;
                selectedKey = Regx86modules;
            } //kill me

            selectedList.Remove(ImportName);
            if (Program.DebugWriteRegistry == true)
            {
                selectedKey.DeleteValue(ImportName);
            }
        }

        public void RenameModule(string ModuleType, string OgName, string NewName, string WrapperName)
        {
            Dictionary<string, string> selectedList;
            RegistryKey selectedKey;
            if (ModuleType == "64")
            {
                selectedList = Modules64;
                selectedKey = Regx64modules;
            }
            else
            {
                selectedList = Modules86;
                selectedKey = Regx86modules;
            } //kill me

            if (OgName != null)
            {
                selectedList.Remove(OgName);
            }
            selectedList.Add(NewName, WrapperName);

            if (Program.DebugWriteRegistry == true)
            {
                if (OgName != null)
                {
                    selectedKey.DeleteValue(OgName);
                }
                selectedKey.SetValue(NewName, WrapperName);
            }
            return;
        }

        public bool IsModuleDefined(string ModuleType, string ImportName)
        {
            Dictionary<string, string> selectedList;
            RegistryKey selectedKey;
            if (ModuleType == "64")
            {
                selectedList = Modules64;
                selectedKey = Regx64modules;
            }
            else
            {
                selectedList = Modules86;
                selectedKey = Regx86modules;
            } //kill me

            return selectedList.ContainsKey(ImportName);
        }

        public void Delete()
        {
            ProfileList.Remove(this);
            Modules64 = null;
            Modules86 = null;

            if (Regx86modules != null)
            {
                Regx86modules.Dispose();
                Regx64modules.Dispose();
                RegConfig.Dispose();
            }

            Regx86modules = null;
            Regx64modules = null;
            RegConfig = null;

            if (Program.DebugWriteRegistry == true)
            {
                Program.MainRegistry.DeleteSubKey(this.Name + "_Config");
                Program.MainRegistry.DeleteSubKey(this.Name + "_Modulex64");
                Program.MainRegistry.DeleteSubKey(this.Name + "_Modulex86");
            }
        }

        private List<DictEntry> SerializeDict(Dictionary<string, string> dictionary)
        {
            List<DictEntry> entries = new List<DictEntry>(dictionary.Count);
            foreach (string key in dictionary.Keys)
            {
                entries.Add(new DictEntry(key, dictionary[key]));
            }
            return entries;
        }

        private Dictionary<string, string> DeserializeDict(List<DictEntry> list)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (DictEntry entry in list)
            {
                dict.Add(entry.Key, entry.Value);
            }
            return dict;
        }

        public void SaveToFile(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Profile));
            TextWriter writer = new StreamWriter(path);
            XML_Modules64 = SerializeDict(Modules64);
            XML_Modules86 = SerializeDict(Modules86);
            serializer.Serialize(writer, this);
            writer.Dispose();
            XML_Modules64 = null;
            XML_Modules86 = null;
        }

        public void Initialize()
        {
            Modules64 = DeserializeDict(XML_Modules64);
            Modules86 = DeserializeDict(XML_Modules86);

            XML_Modules64 = null;
            XML_Modules86 = null;

            CreateNewRegistry();
            SaveToRegistry();
            ProfileList.Add(this);
        }
    }
}

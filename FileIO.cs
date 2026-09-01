using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SSConfig
{
    class FileIO
    {
        public static Icon GetIconFromFilePath(string path)
        {
            if (File.Exists(path))
            {
                Icon rawIcon = Icon.ExtractAssociatedIcon(path);
                Icon icon = new Icon(rawIcon, new Size(24, 24));
                return icon;
            }
            else return null;
        }

        public static void ReadProfXml(string path)
        {
            TextReader reader = new StreamReader(path);
            XmlSerializer serializer = new XmlSerializer(typeof(Profile));
            Profile newProf;
            try
            {
                newProf = (Profile)serializer.Deserialize(reader);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show("This is not a valid Second System profile.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Dispose();
                return;
            }
            reader.Dispose();

            if (newProf.Name == null ||
                newProf.FriendlyName == null ||
                newProf.XML_Modules64 == null ||
                newProf.XML_Modules86 == null)
            {
                MessageBox.Show("This is not a valid Second System profile.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Profile.GetProfileWithName(newProf.Name) != null)
            {
                MessageBox.Show("A profile with name " + newProf.Name + " already exists. Please rename it and try again.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newProf.DataVersion != Program.DataVersion)
            {
                DialogResult res = MessageBox.Show("The imported profile was saved with a different version of SSConfig. This may cause unwanted side effects. Do you wish to proceed?",
                    "SSConfig",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (res != DialogResult.Yes)
                {
                    return;
                }
            }

            newProf.Initialize();
        }
    }
}

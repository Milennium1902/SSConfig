using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.IO;

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
    }
}

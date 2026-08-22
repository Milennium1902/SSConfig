using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SSConfig
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.VersionLabel.Text = "Version " + Program.Version;
        }

    }
}

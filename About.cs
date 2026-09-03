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
        private MainWindow window;

        public About(MainWindow caller)
        {
            InitializeComponent();
            this.VersionLabel.Text = "Version " + Program.Version;
            this.SSVer.Text = "Developed for Second System " + Program.TargetSSVer;
            window = caller;
        }

        private void label2_DoubleClick(object sender, EventArgs e) //funny little easter egg
        {
            window.OpenDirBtn.Image = SSConfig.Properties.Resources.folder;
            System.Media.SystemSounds.Beep.Play();
        }

    }
}

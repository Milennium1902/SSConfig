using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSConfig
{
    public partial class RenameDlg : Form
    {
        public RenameDlg(Profile prof)
        {
            InitializeComponent();
            TargetProf = prof;
            MainLabel.Text = "Enter new name for profile " + prof.Name + ":";
        }

        private Profile TargetProf;

        private void OkBtn_Click(object sender, EventArgs e)
        {
            string newName = ProfNameBox.Text;
            if (newName == null || newName == "")
            {
                MessageBox.Show("Profile name cannot be empty.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.None;
                return;
            }

            if (Profile.GetValidProfileNames().Contains(newName))
            {
                MessageBox.Show("A profile with this name already exists.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.None;
                return;
            }

            Profile newProfile = new Profile(TargetProf, newName);
            Profile.ProfileList.Add(newProfile);
            TargetProf.Delete();
        }
    }
}

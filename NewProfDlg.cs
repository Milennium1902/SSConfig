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
    public partial class NewProfDlg : Form
    {
        public NewProfDlg()
        {
            InitializeComponent();

            foreach (Profile prof in Profile.ProfileList)
            {
                CopyProfileCombo.Items.Add(prof.Name);
            }
            CopyProfileCombo.SelectedItem = CopyProfileCombo.Items[1];
        }

        private void MakeCopy_CheckedChanged(object sender, EventArgs e)
        {
            CopyProfileCombo.Enabled = MakeCopy.Checked;
        }

        private void OkButton_Click(object sender, EventArgs e)
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

            Profile newProfile;
            if (MakeCopy.Checked == true)
            {
                Profile oldProfile = Profile.GetProfileWithName(CopyProfileCombo.Text);
                if (oldProfile == null) //who knows
                {
                    MessageBox.Show("An error occured while cloning the profile.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    return;
                }
                newProfile = new Profile(oldProfile, newName);
            }
            else
            {
                newProfile = new Profile(newName);
            }

            Profile.ProfileList.Add(newProfile);
        }
    }
}

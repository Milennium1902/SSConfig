using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SSConfig
{
    public partial class MainWindow : Form
    {
        private void EnableDefaultBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableDefaultBox.Checked == true)
            {
                if (DefaultProfileCombo.SelectedItem == null)
                {
                    DefaultProfileCombo.SelectedItem = DefaultProfileCombo.Items[1]; //second system 6.7 release notes: now DefaultConfig is no longer the second profile in profile list just to break ts
                }
                CurrentSettings.DefaultProfile = DefaultProfileCombo.SelectedItem.ToString();
            }
            else
            {
                CurrentSettings.DefaultProfile = "Passive";
            }
            DefaultProfLabel.Enabled = EnableDefaultBox.Checked;
            DefaultProfileCombo.Enabled = EnableDefaultBox.Checked;

            CurrentSettings.SaveToRegistry();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", CurrentSettings.SecondSystemPath);
        }


        private void DefaultProfileCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CurrentSettings.DefaultProfile = DefaultProfileCombo.SelectedItem.ToString();
            CurrentSettings.SaveToRegistry();
        }

        private void NewContextMenuBox_CheckedChanged(object sender, EventArgs e)
        {
            CurrentSettings.NewContextMenu = NewContextMenuBox.Checked;
            CurrentSettings.SaveToRegistry();
        }
    }
}
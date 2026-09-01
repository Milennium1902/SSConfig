using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SSConfig
{
    public partial class MainWindow : Form
    {
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About dlg = new About();
            dlg.ShowDialog();
            dlg.Dispose();
        }

        private void importProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string filePath = dlg.FileName;
                FileIO.ReadProfXml(filePath);
                RefreshTreeView();
                CurrentSettings.SaveToRegistry();
            }
        }

        private void displayAppIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.DebugShowIcons = Program.DebugShowIcons == false;
            displayAppIconsToolStripMenuItem.Checked = Program.DebugShowIcons;
        }

        private void writeToRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.DebugWriteRegistry = Program.DebugWriteRegistry == false;
            writeToRegistryToolStripMenuItem.Checked = Program.DebugWriteRegistry;
        }

        private void addAnAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string filePath = dlg.FileName;
                if (Program.MainRegistry.GetValue(filePath) != null)
                {
                    MessageBox.Show("This app is already defined.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DataGridViewRow newRow = NewAppGridRow(filePath);
                newRow.Cells["ChosenProfile"].Value = CurrentSettings.DefaultProfile;
                AppsGrid.ClearSelection();
                newRow.Selected = true;
                AppsGrid.FirstDisplayedScrollingRowIndex = newRow.Index;
            }
        }

        private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProfDlg dialog = new NewProfDlg();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                RefreshTreeView();
                CurrentSettings.SaveToRegistry();
            }
            dialog.Dispose();
        }   

    }
}
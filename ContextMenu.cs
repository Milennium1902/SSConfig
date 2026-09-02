using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SSConfig
{
    public partial class MainWindow : Form
    {
        private void renameProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile prof = (Profile)TreeView.SelectedNode.Tag;
            RenameDlg dlg = new RenameDlg(prof);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TreeView.SelectedNode = TreeView.Nodes[2];
                RefreshTreeView();
                CurrentSettings.SaveToRegistry();
            }
            dlg.Dispose();
        }

        private void exportProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile prof = (Profile)TreeView.SelectedNode.Tag;
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string filePath = dlg.FileName;
                prof.SaveToFile(filePath);
                MessageBox.Show("Successfully exported profile.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile prof = (Profile)TreeView.SelectedNode.Tag;

            DialogResult areYouSure = MessageBox.Show("Are you sure you want to delete profile " + prof.Name + "? This will break any apps currently set to use this profile.",
                "SSConfig",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (areYouSure == DialogResult.Yes)
            {
                prof.Delete();
                TreeView.SelectedNode = TreeView.Nodes[2];
                RefreshTreeView();
                CurrentSettings.SaveToRegistry(); //this will update the drop-down menu
                MainPropGrid.SelectedObject = null;
            }
        }
    }
}
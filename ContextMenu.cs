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
            MessageBox.Show("Not implemented.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control c = ProfileContextMenu.SourceControl;
            MessageBox.Show(sender.ToString(), "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
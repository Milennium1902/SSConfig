using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SSConfig
{
    public partial class MainWindow: Form
    {
        private DataGridViewRow NewAppGridRow(string app)
        {
            int index = AppsGrid.Rows.Add();
            DataGridViewRow newRow = AppsGrid.Rows[index];

            newRow.Cells["AppName"].Value = app;

            if (Program.DebugShowIcons == true)
            {
                Icon icon = FileIO.GetIconFromFilePath(app);
                if (icon != null)
                {
                    newRow.Cells["AppIcon"].Value = icon;
                }
            }

            return newRow;
        }

        private void OnAppsGridValChange(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2)
            {
                return;
            }
            if (Program.DebugWriteRegistry == false)
            {
                return;
            }
            DataGridViewRow currentRow = AppsGrid.Rows[e.RowIndex];
            Program.MainRegistry.SetValue(currentRow.Cells["AppName"].Value.ToString(), currentRow.Cells["ChosenProfile"].Value.ToString());
        }

        private void OnAppsGridRowDelete(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (AppsGrid.SelectedRows.Count == AppsGrid.Rows.Count)
            {
                if (UserSawDeletionPopup == false)
                {
                    MessageBox.Show("You may have accidentally selected all rows to delete. This action was ignored.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UserSawDeletionPopup = true;
                }
                e.Cancel = true;
                return;
            }

            if (Program.DebugWriteRegistry == false)
            {
                return;
            }

            Program.MainRegistry.DeleteValue(e.Row.Cells["AppName"].Value.ToString());
        }

        private void AppsGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is ArgumentException)
            {
                DataGridViewRow row = AppsGrid.Rows[e.RowIndex];

                string err = row.Cells["AppName"].Value + " is configured to use invalid profile " + row.Cells["ChosenProfile"].Value + ". Second System has been disabled for this app.";
                row.Cells["ChosenProfile"].Value = "Passive";

                MessageBox.Show(err, "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(e.Exception.ToString(), "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
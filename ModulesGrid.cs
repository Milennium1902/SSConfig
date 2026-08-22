using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SSConfig
{
    public partial class MainWindow : Form
    {
        private void OnModuleGridValChange(object sender, DataGridViewCellEventArgs e)
        {
            SelectedModuleListInfo infoTag = (SelectedModuleListInfo)ModulesGrid.Tag;
            Profile currentProf = infoTag.SelectedProfile;
            DataGridViewRow currentRow = ModulesGrid.Rows[e.RowIndex];
            string name = (string)currentRow.Cells[0].Value;
            string val = (string)currentRow.Cells[1].Value;
            if (val == null)
            {
                val = "";
            }

            if (currentRow.Tag == null) //user just added a new row
            {
                HandleNewModuleRow(currentRow, currentProf, infoTag);
                return;
            }

            if (e.ColumnIndex == 0)
            {
                string ogName = (string)currentRow.Tag;
                if (name == ogName)
                {
                    return;
                }
                if (name == null || name == "")
                {
                    MessageBox.Show("Module name cannot be empty.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    currentRow.Cells[0].Value = ogName;
                    return;
                }
                if (currentProf.IsModuleDefined(infoTag.SelectedModules, name))
                {
                    MessageBox.Show("That module name is already defined.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    currentRow.Cells[0].Value = ogName;
                    return;
                }
                currentProf.RenameModule(infoTag.SelectedModules, ogName, name, val);
                currentRow.Tag = name;
            }
            else
            {
                currentProf.UpdateModule(infoTag.SelectedModules, name, val);
            }
        }

        private void ModulesGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (ModulesGrid.SelectedRows.Count == ModulesGrid.Rows.Count)
            {
                if (UserSawDeletionPopup == false)
                {
                    MessageBox.Show("You may have accidentally selected all rows to delete. This action was ignored.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UserSawDeletionPopup = true;
                }
                e.Cancel = true;
                return;
            }

            SelectedModuleListInfo infoTag = (SelectedModuleListInfo)ModulesGrid.Tag;
            Profile currentProf = infoTag.SelectedProfile;
            currentProf.RemoveModule(infoTag.SelectedModules, e.Row.Cells[0].Value.ToString());
        }

        private void HandleNewModuleRow(DataGridViewRow currentRow, Profile currentProf, SelectedModuleListInfo infoTag)
        {
            string name = (string)currentRow.Cells[0].Value;

            if (name == null || name == "")
            {
                MessageBox.Show("You must type the import name first.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ModulesGrid.Rows.Remove(currentRow);
                return;
            }

            if (currentProf.IsModuleDefined(infoTag.SelectedModules, name))
            {
                MessageBox.Show("That module name is already defined.", "SSConfig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ModulesGrid.Rows.Remove(currentRow);
                return;
            }

            currentProf.UpdateModule(infoTag.SelectedModules, name, ""); //omgb couldve just added a new "add module" func
            currentRow.Tag = name;
            return;
        }
    }
}
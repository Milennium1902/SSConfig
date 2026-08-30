using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SSConfig
{
    public partial class MainWindow : Form
    {
        private MainSettings CurrentSettings;

        private bool UserSawDeletionPopup;

        public MainWindow(MainSettings settings)
        {
            InitializeComponent();
            CurrentSettings = settings;
            MainPropGrid.SelectedObject = CurrentSettings;

            RefreshTreeView();

            displayAppIconsToolStripMenuItem.Checked = Program.DebugShowIcons;
            writeToRegistryToolStripMenuItem.Checked = Program.DebugWriteRegistry;

            UpdateDefaultProfCombo();

            bool defaultEnable = CurrentSettings.DefaultProfile != "Passive";

            if (defaultEnable == true)
            {
                DefaultProfileCombo.SelectedItem = CurrentSettings.DefaultProfile;
            }

            EnableDefaultBox.Checked = defaultEnable;
            DefaultProfLabel.Enabled = defaultEnable;
            DefaultProfileCombo.Enabled = defaultEnable;

            ModulesGrid.Tag = new SelectedModuleListInfo();
        }

        private void RefreshTreeView()
        {
            TreeView.Nodes["Profiles"].Nodes.Clear();
            foreach (Profile p in Profile.ProfileList)
            {
                TreeNode node = TreeView.Nodes[2].Nodes.Add(p.Name);
                node.Tag = p;
                node.ContextMenuStrip = ProfileContextMenu;
                TreeNode node64 = node.Nodes.Add("x64 Modules");
                node64.Name = "64";
                TreeNode node86 = node.Nodes.Add("x86 Modules");
                node86.Name = "86";

            }
        }

        private void UpdateDefaultProfCombo()
        {
            DefaultProfileCombo.Items.Clear();
            foreach (Profile prof in Profile.ProfileList)
            {
                DefaultProfileCombo.Items.Add(prof.Name);
            }
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MainPropGrid.Hide();
            ModulesGrid.Hide();
            ModulesGrid.Rows.Clear();
            AppsGrid.Hide();
            AppsGrid.Rows.Clear();
            GeneralPanel.Hide();
            UserSawDeletionPopup = false;
            addAnAppToolStripMenuItem.Enabled = false;
            if (e.Node.FullPath == "General")
            {
                UpdateDefaultProfCombo();
                GeneralPanel.Show();
            }
            else if (e.Node.Tag != null) //selected profile settings
            {
                MainPropGrid.SelectedObject = e.Node.Tag;
                MainPropGrid.Show();
            }
            else if (e.Node.Parent != null && e.Node.Parent.Tag != null) //selected profile modules
            {
                Profile SelectedProfile = (Profile)e.Node.Parent.Tag;
                Dictionary<string, string> SelectedTable;
                SelectedModuleListInfo infoTag = (SelectedModuleListInfo)ModulesGrid.Tag;
                ModulesGrid.CellValueChanged -= OnModuleGridValChange;

                if (e.Node.Name  == "64")
                {
                    SelectedTable = SelectedProfile.Modules64;
                }
                else
                {
                    SelectedTable = SelectedProfile.Modules86;
                }

                foreach (KeyValuePair<string, string> redirect in SelectedTable)
                {
                    string[] data = { redirect.Key, redirect.Value };
                    int index = ModulesGrid.Rows.Add(data);
                    ModulesGrid.Rows[index].Tag = redirect.Key;
                }

                infoTag.SelectedProfile = SelectedProfile;
                infoTag.SelectedModules = e.Node.Name;
                ModulesGrid.CellValueChanged += OnModuleGridValChange;
                ModulesGrid.Show();
            }
            else if (e.Node.FullPath == "Apps")
            {
                AppsGrid.CellValueChanged -= OnAppsGridValChange;
                AppsGrid.UserDeletingRow -= OnAppsGridRowDelete;
                ChosenProfile.Items.Clear();
                foreach (string profile in Profile.GetValidProfileNames())
                {
                    ChosenProfile.Items.Add(profile);
                }
                this.Cursor = Cursors.WaitCursor;
                AppsGrid.Show();
                foreach (string app in MainSettings.GetRegisteredApps())
                {
                    DataGridViewRow newRow = NewAppGridRow(app);
                    newRow.Cells["ChosenProfile"].Value = Program.MainRegistry.GetValue(app).ToString();
                }
                this.Cursor = Cursors.Arrow;
                AppsGrid.CellValueChanged += OnAppsGridValChange;
                AppsGrid.UserDeletingRow += OnAppsGridRowDelete;
                addAnAppToolStripMenuItem.Enabled = true;
            }
        }

        private void MainPropGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            Profile selectedProfile = (Profile)MainPropGrid.SelectedObject;
            selectedProfile.SaveToRegistry();
        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeView.SelectedNode = e.Node;
            }
        }

        private void DefaultProfileCombo_DropDown(object sender, EventArgs e)
        {
            UpdateDefaultProfCombo();
        }

    }
}

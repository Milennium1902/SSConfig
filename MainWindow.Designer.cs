namespace SSConfig
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Apps");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Profiles");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAppIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToRegistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.MainPropGrid = new System.Windows.Forms.PropertyGrid();
            this.ModulesGrid = new System.Windows.Forms.DataGridView();
            this.ImportDll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SsDll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppsGrid = new System.Windows.Forms.DataGridView();
            this.AppIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.AppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChosenProfile = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DefaultProfileCombo = new System.Windows.Forms.ComboBox();
            this.DefaultProfLabel = new System.Windows.Forms.Label();
            this.EnableDefaultBox = new System.Windows.Forms.CheckBox();
            this.NewContextMenuBox = new System.Windows.Forms.CheckBox();
            this.ProfileContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppsGrid)).BeginInit();
            this.GeneralPanel.SuspendLayout();
            this.ProfileContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAnAppToolStripMenuItem,
            this.toolStripSeparator2,
            this.newProfileToolStripMenuItem,
            this.importProfileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addAnAppToolStripMenuItem
            // 
            this.addAnAppToolStripMenuItem.Name = "addAnAppToolStripMenuItem";
            this.addAnAppToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addAnAppToolStripMenuItem.Text = "Add an app...";
            this.addAnAppToolStripMenuItem.Click += new System.EventHandler(this.addAnAppToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // newProfileToolStripMenuItem
            // 
            this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
            this.newProfileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newProfileToolStripMenuItem.Text = "New profile...";
            this.newProfileToolStripMenuItem.Click += new System.EventHandler(this.newProfileToolStripMenuItem_Click);
            // 
            // importProfileToolStripMenuItem
            // 
            this.importProfileToolStripMenuItem.Name = "importProfileToolStripMenuItem";
            this.importProfileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.importProfileToolStripMenuItem.Text = "Import profile...";
            this.importProfileToolStripMenuItem.Click += new System.EventHandler(this.importProfileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAppIconsToolStripMenuItem,
            this.writeToRegistryToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // displayAppIconsToolStripMenuItem
            // 
            this.displayAppIconsToolStripMenuItem.Checked = true;
            this.displayAppIconsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayAppIconsToolStripMenuItem.Name = "displayAppIconsToolStripMenuItem";
            this.displayAppIconsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.displayAppIconsToolStripMenuItem.Text = "Display app icons";
            this.displayAppIconsToolStripMenuItem.Click += new System.EventHandler(this.displayAppIconsToolStripMenuItem_Click);
            // 
            // writeToRegistryToolStripMenuItem
            // 
            this.writeToRegistryToolStripMenuItem.Name = "writeToRegistryToolStripMenuItem";
            this.writeToRegistryToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.writeToRegistryToolStripMenuItem.Text = "Write to registry";
            this.writeToRegistryToolStripMenuItem.Click += new System.EventHandler(this.writeToRegistryToolStripMenuItem_Click);
            // 
            // TreeView
            // 
            this.TreeView.Location = new System.Drawing.Point(5, 30);
            this.TreeView.Name = "TreeView";
            treeNode1.Name = "General";
            treeNode1.Text = "General";
            treeNode2.Name = "Apps";
            treeNode2.Text = "Apps";
            treeNode3.Name = "Profiles";
            treeNode3.Text = "Profiles";
            this.TreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.TreeView.Size = new System.Drawing.Size(150, 277);
            this.TreeView.TabIndex = 1;
            this.TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            this.TreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseClick);
            // 
            // MainPropGrid
            // 
            this.MainPropGrid.Location = new System.Drawing.Point(161, 30);
            this.MainPropGrid.Name = "MainPropGrid";
            this.MainPropGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.MainPropGrid.Size = new System.Drawing.Size(511, 277);
            this.MainPropGrid.TabIndex = 5;
            this.MainPropGrid.ToolbarVisible = false;
            this.MainPropGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.MainPropGrid_PropertyValueChanged);
            // 
            // ModulesGrid
            // 
            this.ModulesGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ModulesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ModulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModulesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImportDll,
            this.SsDll});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ModulesGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ModulesGrid.Location = new System.Drawing.Point(161, 30);
            this.ModulesGrid.Name = "ModulesGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ModulesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ModulesGrid.Size = new System.Drawing.Size(511, 277);
            this.ModulesGrid.TabIndex = 6;
            this.ModulesGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ModulesGrid_UserDeletingRow);
            // 
            // ImportDll
            // 
            this.ImportDll.HeaderText = "Import";
            this.ImportDll.Name = "ImportDll";
            this.ImportDll.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImportDll.Width = 225;
            // 
            // SsDll
            // 
            this.SsDll.HeaderText = "Wrapper";
            this.SsDll.Name = "SsDll";
            this.SsDll.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SsDll.Width = 225;
            // 
            // AppsGrid
            // 
            this.AppsGrid.AllowUserToAddRows = false;
            this.AppsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.AppsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppIcon,
            this.AppName,
            this.ChosenProfile});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AppsGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.AppsGrid.Location = new System.Drawing.Point(161, 30);
            this.AppsGrid.Name = "AppsGrid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.AppsGrid.Size = new System.Drawing.Size(511, 277);
            this.AppsGrid.TabIndex = 7;
            this.AppsGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.AppsGrid_DataError);
            // 
            // AppIcon
            // 
            this.AppIcon.HeaderText = "";
            this.AppIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.AppIcon.Name = "AppIcon";
            this.AppIcon.ReadOnly = true;
            this.AppIcon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AppIcon.Width = 24;
            // 
            // AppName
            // 
            this.AppName.HeaderText = "File path";
            this.AppName.Name = "AppName";
            this.AppName.ReadOnly = true;
            this.AppName.Width = 276;
            // 
            // ChosenProfile
            // 
            this.ChosenProfile.HeaderText = "Profile";
            this.ChosenProfile.Name = "ChosenProfile";
            this.ChosenProfile.Width = 150;
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Controls.Add(this.button1);
            this.GeneralPanel.Controls.Add(this.DefaultProfileCombo);
            this.GeneralPanel.Controls.Add(this.DefaultProfLabel);
            this.GeneralPanel.Controls.Add(this.EnableDefaultBox);
            this.GeneralPanel.Controls.Add(this.NewContextMenuBox);
            this.GeneralPanel.Location = new System.Drawing.Point(161, 30);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(510, 277);
            this.GeneralPanel.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Image = global::SSConfig.Properties.Resources.folder;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Open installation directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DefaultProfileCombo
            // 
            this.DefaultProfileCombo.FormattingEnabled = true;
            this.DefaultProfileCombo.Location = new System.Drawing.Point(148, 43);
            this.DefaultProfileCombo.Name = "DefaultProfileCombo";
            this.DefaultProfileCombo.Size = new System.Drawing.Size(121, 21);
            this.DefaultProfileCombo.TabIndex = 3;
            this.DefaultProfileCombo.DropDown += new System.EventHandler(this.DefaultProfileCombo_DropDown);
            this.DefaultProfileCombo.SelectionChangeCommitted += new System.EventHandler(this.DefaultProfileCombo_SelectionChangeCommitted);
            // 
            // DefaultProfLabel
            // 
            this.DefaultProfLabel.AutoSize = true;
            this.DefaultProfLabel.Location = new System.Drawing.Point(3, 46);
            this.DefaultProfLabel.Name = "DefaultProfLabel";
            this.DefaultProfLabel.Size = new System.Drawing.Size(139, 13);
            this.DefaultProfLabel.TabIndex = 2;
            this.DefaultProfLabel.Text = "Default profile for new apps:";
            // 
            // EnableDefaultBox
            // 
            this.EnableDefaultBox.AutoSize = true;
            this.EnableDefaultBox.Location = new System.Drawing.Point(3, 26);
            this.EnableDefaultBox.Name = "EnableDefaultBox";
            this.EnableDefaultBox.Size = new System.Drawing.Size(185, 17);
            this.EnableDefaultBox.TabIndex = 1;
            this.EnableDefaultBox.Text = "Enable Second System by default";
            this.EnableDefaultBox.UseVisualStyleBackColor = true;
            this.EnableDefaultBox.CheckedChanged += new System.EventHandler(this.EnableDefaultBox_CheckedChanged);
            // 
            // NewContextMenuBox
            // 
            this.NewContextMenuBox.AutoSize = true;
            this.NewContextMenuBox.Location = new System.Drawing.Point(3, 3);
            this.NewContextMenuBox.Name = "NewContextMenuBox";
            this.NewContextMenuBox.Size = new System.Drawing.Size(165, 17);
            this.NewContextMenuBox.TabIndex = 0;
            this.NewContextMenuBox.Text = "Use drop-down context menu";
            this.NewContextMenuBox.UseVisualStyleBackColor = true;
            this.NewContextMenuBox.CheckedChanged += new System.EventHandler(this.NewContextMenuBox_CheckedChanged);
            // 
            // ProfileContextMenu
            // 
            this.ProfileContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameProfileToolStripMenuItem,
            this.exportProfileToolStripMenuItem,
            this.deleteProfileToolStripMenuItem});
            this.ProfileContextMenu.Name = "ProfileContextMenu";
            this.ProfileContextMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // renameProfileToolStripMenuItem
            // 
            this.renameProfileToolStripMenuItem.Name = "renameProfileToolStripMenuItem";
            this.renameProfileToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.renameProfileToolStripMenuItem.Text = "Rename";
            this.renameProfileToolStripMenuItem.Click += new System.EventHandler(this.renameProfileToolStripMenuItem_Click);
            // 
            // exportProfileToolStripMenuItem
            // 
            this.exportProfileToolStripMenuItem.Name = "exportProfileToolStripMenuItem";
            this.exportProfileToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exportProfileToolStripMenuItem.Text = "Export...";
            this.exportProfileToolStripMenuItem.Click += new System.EventHandler(this.exportProfileToolStripMenuItem_Click);
            // 
            // deleteProfileToolStripMenuItem
            // 
            this.deleteProfileToolStripMenuItem.Name = "deleteProfileToolStripMenuItem";
            this.deleteProfileToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteProfileToolStripMenuItem.Text = "Delete";
            this.deleteProfileToolStripMenuItem.Click += new System.EventHandler(this.deleteProfileToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 315);
            this.Controls.Add(this.TreeView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.AppsGrid);
            this.Controls.Add(this.ModulesGrid);
            this.Controls.Add(this.MainPropGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Second System Configuration Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppsGrid)).EndInit();
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.ProfileContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.ToolStripMenuItem addAnAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem importProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProfileToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid MainPropGrid;
        private System.Windows.Forms.DataGridView ModulesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportDll;
        private System.Windows.Forms.DataGridViewTextBoxColumn SsDll;
        private System.Windows.Forms.DataGridView AppsGrid;
        private System.Windows.Forms.DataGridViewImageColumn AppIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ChosenProfile;
        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.ComboBox DefaultProfileCombo;
        private System.Windows.Forms.Label DefaultProfLabel;
        private System.Windows.Forms.CheckBox EnableDefaultBox;
        private System.Windows.Forms.CheckBox NewContextMenuBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAppIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToRegistryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ProfileContextMenu;
        private System.Windows.Forms.ToolStripMenuItem renameProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProfileToolStripMenuItem;
    }
}


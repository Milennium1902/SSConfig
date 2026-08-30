namespace SSConfig
{
    partial class NewProfDlg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LeaveBlank = new System.Windows.Forms.RadioButton();
            this.CopyProfileCombo = new System.Windows.Forms.ComboBox();
            this.MakeCopy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ProfNameBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LeaveBlank);
            this.groupBox1.Controls.Add(this.CopyProfileCombo);
            this.groupBox1.Controls.Add(this.MakeCopy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile template";
            // 
            // LeaveBlank
            // 
            this.LeaveBlank.AutoSize = true;
            this.LeaveBlank.Location = new System.Drawing.Point(6, 69);
            this.LeaveBlank.Name = "LeaveBlank";
            this.LeaveBlank.Size = new System.Drawing.Size(84, 17);
            this.LeaveBlank.TabIndex = 2;
            this.LeaveBlank.TabStop = true;
            this.LeaveBlank.Text = "Leave blank";
            this.LeaveBlank.UseVisualStyleBackColor = true;
            // 
            // CopyProfileCombo
            // 
            this.CopyProfileCombo.FormattingEnabled = true;
            this.CopyProfileCombo.Location = new System.Drawing.Point(69, 42);
            this.CopyProfileCombo.Name = "CopyProfileCombo";
            this.CopyProfileCombo.Size = new System.Drawing.Size(121, 21);
            this.CopyProfileCombo.TabIndex = 1;
            // 
            // MakeCopy
            // 
            this.MakeCopy.AutoSize = true;
            this.MakeCopy.Location = new System.Drawing.Point(6, 19);
            this.MakeCopy.Name = "MakeCopy";
            this.MakeCopy.Size = new System.Drawing.Size(199, 17);
            this.MakeCopy.TabIndex = 0;
            this.MakeCopy.TabStop = true;
            this.MakeCopy.Text = "Create a copy of the following profile:";
            this.MakeCopy.UseVisualStyleBackColor = true;
            this.MakeCopy.CheckedChanged += new System.EventHandler(this.MakeCopy_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // ProfNameBox
            // 
            this.ProfNameBox.Location = new System.Drawing.Point(56, 118);
            this.ProfNameBox.Name = "ProfNameBox";
            this.ProfNameBox.Size = new System.Drawing.Size(216, 20);
            this.ProfNameBox.TabIndex = 2;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(50, 144);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(170, 144);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NewProfDlg
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ProfNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProfDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Create new profile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LeaveBlank;
        private System.Windows.Forms.ComboBox CopyProfileCombo;
        private System.Windows.Forms.RadioButton MakeCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProfNameBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
﻿
namespace Roberta
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firearmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFirearmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFirearmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFirearmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ammunitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAmmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAmmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAmmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.logTabPage = new System.Windows.Forms.TabPage();
            this.firearmsTabPage = new System.Windows.Forms.TabPage();
            this.firearmsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.firearmsListBox = new System.Windows.Forms.ListBox();
            this.firearmCancelButton = new System.Windows.Forms.Button();
            this.firearmSaveButton = new System.Windows.Forms.Button();
            this.firearmSerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.firearmCaliberTextBox = new System.Windows.Forms.TextBox();
            this.firearmManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.firearmModelTextBox = new System.Windows.Forms.TextBox();
            this.firearmSerialNumberLabel = new System.Windows.Forms.Label();
            this.firearmCaliberLabel = new System.Windows.Forms.Label();
            this.firearmManufacturerLabel = new System.Windows.Forms.Label();
            this.firearmModelLabel = new System.Windows.Forms.Label();
            this.ammoTabPage = new System.Windows.Forms.TabPage();
            this.ammoSplitContainer = new System.Windows.Forms.SplitContainer();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.firearmsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firearmsSplitContainer)).BeginInit();
            this.firearmsSplitContainer.Panel1.SuspendLayout();
            this.firearmsSplitContainer.Panel2.SuspendLayout();
            this.firearmsSplitContainer.SuspendLayout();
            this.ammoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ammoSplitContainer)).BeginInit();
            this.ammoSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.lOGToolStripMenuItem,
            this.firearmsToolStripMenuItem,
            this.ammunitionToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lOGToolStripMenuItem
            // 
            this.lOGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem,
            this.editRecordToolStripMenuItem,
            this.removeRecordToolStripMenuItem});
            this.lOGToolStripMenuItem.Name = "lOGToolStripMenuItem";
            this.lOGToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.lOGToolStripMenuItem.Text = "LOG";
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addRecordToolStripMenuItem.Text = "Add record";
            // 
            // editRecordToolStripMenuItem
            // 
            this.editRecordToolStripMenuItem.Name = "editRecordToolStripMenuItem";
            this.editRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editRecordToolStripMenuItem.Text = "Edit record";
            // 
            // removeRecordToolStripMenuItem
            // 
            this.removeRecordToolStripMenuItem.Name = "removeRecordToolStripMenuItem";
            this.removeRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeRecordToolStripMenuItem.Text = "Remove record";
            // 
            // firearmsToolStripMenuItem
            // 
            this.firearmsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFirearmToolStripMenuItem,
            this.editFirearmToolStripMenuItem,
            this.removeFirearmToolStripMenuItem});
            this.firearmsToolStripMenuItem.Name = "firearmsToolStripMenuItem";
            this.firearmsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.firearmsToolStripMenuItem.Text = "Firearms";
            // 
            // createFirearmToolStripMenuItem
            // 
            this.createFirearmToolStripMenuItem.Name = "createFirearmToolStripMenuItem";
            this.createFirearmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createFirearmToolStripMenuItem.Text = "Create";
            this.createFirearmToolStripMenuItem.Click += new System.EventHandler(this.createFirearmToolStripMenuItem_Click);
            // 
            // editFirearmToolStripMenuItem
            // 
            this.editFirearmToolStripMenuItem.Enabled = false;
            this.editFirearmToolStripMenuItem.Name = "editFirearmToolStripMenuItem";
            this.editFirearmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editFirearmToolStripMenuItem.Text = "Edit";
            this.editFirearmToolStripMenuItem.Click += new System.EventHandler(this.editFirearmToolStripMenuItem_Click);
            // 
            // removeFirearmToolStripMenuItem
            // 
            this.removeFirearmToolStripMenuItem.Enabled = false;
            this.removeFirearmToolStripMenuItem.Name = "removeFirearmToolStripMenuItem";
            this.removeFirearmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeFirearmToolStripMenuItem.Text = "Remove";
            this.removeFirearmToolStripMenuItem.Click += new System.EventHandler(this.removeFirearmToolStripMenuItem_Click);
            // 
            // ammunitionToolStripMenuItem
            // 
            this.ammunitionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAmmoToolStripMenuItem,
            this.editAmmoToolStripMenuItem,
            this.removeAmmoToolStripMenuItem});
            this.ammunitionToolStripMenuItem.Name = "ammunitionToolStripMenuItem";
            this.ammunitionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.ammunitionToolStripMenuItem.Text = "Ammunition";
            // 
            // createAmmoToolStripMenuItem
            // 
            this.createAmmoToolStripMenuItem.Name = "createAmmoToolStripMenuItem";
            this.createAmmoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createAmmoToolStripMenuItem.Text = "Create";
            // 
            // editAmmoToolStripMenuItem
            // 
            this.editAmmoToolStripMenuItem.Name = "editAmmoToolStripMenuItem";
            this.editAmmoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editAmmoToolStripMenuItem.Text = "Edit";
            // 
            // removeAmmoToolStripMenuItem
            // 
            this.removeAmmoToolStripMenuItem.Name = "removeAmmoToolStripMenuItem";
            this.removeAmmoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeAmmoToolStripMenuItem.Text = "Remove";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.logTabPage);
            this.tabControl.Controls.Add(this.firearmsTabPage);
            this.tabControl.Controls.Add(this.ammoTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 426);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // logTabPage
            // 
            this.logTabPage.Location = new System.Drawing.Point(4, 22);
            this.logTabPage.Name = "logTabPage";
            this.logTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.logTabPage.Size = new System.Drawing.Size(792, 400);
            this.logTabPage.TabIndex = 0;
            this.logTabPage.Text = "LOG";
            this.logTabPage.UseVisualStyleBackColor = true;
            // 
            // firearmsTabPage
            // 
            this.firearmsTabPage.Controls.Add(this.firearmsSplitContainer);
            this.firearmsTabPage.Location = new System.Drawing.Point(4, 22);
            this.firearmsTabPage.Name = "firearmsTabPage";
            this.firearmsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.firearmsTabPage.Size = new System.Drawing.Size(792, 400);
            this.firearmsTabPage.TabIndex = 1;
            this.firearmsTabPage.Text = "Firearms";
            this.firearmsTabPage.UseVisualStyleBackColor = true;
            // 
            // firearmsSplitContainer
            // 
            this.firearmsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firearmsSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.firearmsSplitContainer.Name = "firearmsSplitContainer";
            // 
            // firearmsSplitContainer.Panel1
            // 
            this.firearmsSplitContainer.Panel1.Controls.Add(this.firearmsListBox);
            // 
            // firearmsSplitContainer.Panel2
            // 
            this.firearmsSplitContainer.Panel2.Controls.Add(this.firearmCancelButton);
            this.firearmsSplitContainer.Panel2.Controls.Add(this.firearmSaveButton);
            this.firearmsSplitContainer.Panel2.Controls.Add(this.firearmSerialNumberTextBox);
            this.firearmsSplitContainer.Panel2.Controls.Add(this.firearmCaliberTextBox);
            this.firearmsSplitContainer.Panel2.Controls.Add(this.firearmManufacturerTextBox);
            this.firearmsSplitContainer.Panel2.Controls.Add(this.firearmModelTextBox);
            this.firearmsSplitContainer.Panel2.Controls.Add(this.firearmSerialNumberLabel);
            this.firearmsSplitContainer.Panel2.Controls.Add(this.firearmCaliberLabel);
            this.firearmsSplitContainer.Panel2.Controls.Add(this.firearmManufacturerLabel);
            this.firearmsSplitContainer.Panel2.Controls.Add(this.firearmModelLabel);
            this.firearmsSplitContainer.Size = new System.Drawing.Size(786, 394);
            this.firearmsSplitContainer.SplitterDistance = 262;
            this.firearmsSplitContainer.TabIndex = 0;
            // 
            // firearmsListBox
            // 
            this.firearmsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firearmsListBox.FormattingEnabled = true;
            this.firearmsListBox.Location = new System.Drawing.Point(0, 0);
            this.firearmsListBox.Name = "firearmsListBox";
            this.firearmsListBox.Size = new System.Drawing.Size(262, 394);
            this.firearmsListBox.TabIndex = 0;
            this.firearmsListBox.SelectedIndexChanged += new System.EventHandler(this.firearmsListBox_SelectedIndexChanged);
            // 
            // firearmCancelButton
            // 
            this.firearmCancelButton.Location = new System.Drawing.Point(128, 175);
            this.firearmCancelButton.Name = "firearmCancelButton";
            this.firearmCancelButton.Size = new System.Drawing.Size(75, 23);
            this.firearmCancelButton.TabIndex = 9;
            this.firearmCancelButton.Text = "Cancel";
            this.firearmCancelButton.UseVisualStyleBackColor = true;
            this.firearmCancelButton.Click += new System.EventHandler(this.firearmCancelButton_Click);
            // 
            // firearmSaveButton
            // 
            this.firearmSaveButton.Location = new System.Drawing.Point(17, 175);
            this.firearmSaveButton.Name = "firearmSaveButton";
            this.firearmSaveButton.Size = new System.Drawing.Size(75, 23);
            this.firearmSaveButton.TabIndex = 8;
            this.firearmSaveButton.Text = "Save";
            this.firearmSaveButton.UseVisualStyleBackColor = true;
            this.firearmSaveButton.Click += new System.EventHandler(this.firearmSaveButton_Click);
            // 
            // firearmSerialNumberTextBox
            // 
            this.firearmSerialNumberTextBox.Location = new System.Drawing.Point(104, 92);
            this.firearmSerialNumberTextBox.Name = "firearmSerialNumberTextBox";
            this.firearmSerialNumberTextBox.Size = new System.Drawing.Size(252, 20);
            this.firearmSerialNumberTextBox.TabIndex = 7;
            // 
            // firearmCaliberTextBox
            // 
            this.firearmCaliberTextBox.Location = new System.Drawing.Point(104, 66);
            this.firearmCaliberTextBox.Name = "firearmCaliberTextBox";
            this.firearmCaliberTextBox.Size = new System.Drawing.Size(252, 20);
            this.firearmCaliberTextBox.TabIndex = 6;
            // 
            // firearmManufacturerTextBox
            // 
            this.firearmManufacturerTextBox.Location = new System.Drawing.Point(104, 40);
            this.firearmManufacturerTextBox.Name = "firearmManufacturerTextBox";
            this.firearmManufacturerTextBox.Size = new System.Drawing.Size(252, 20);
            this.firearmManufacturerTextBox.TabIndex = 5;
            // 
            // firearmModelTextBox
            // 
            this.firearmModelTextBox.Location = new System.Drawing.Point(104, 14);
            this.firearmModelTextBox.Name = "firearmModelTextBox";
            this.firearmModelTextBox.Size = new System.Drawing.Size(252, 20);
            this.firearmModelTextBox.TabIndex = 4;
            // 
            // firearmSerialNumberLabel
            // 
            this.firearmSerialNumberLabel.AutoSize = true;
            this.firearmSerialNumberLabel.Location = new System.Drawing.Point(13, 90);
            this.firearmSerialNumberLabel.Name = "firearmSerialNumberLabel";
            this.firearmSerialNumberLabel.Size = new System.Drawing.Size(30, 13);
            this.firearmSerialNumberLabel.TabIndex = 3;
            this.firearmSerialNumberLabel.Text = "S\\N:";
            // 
            // firearmCaliberLabel
            // 
            this.firearmCaliberLabel.AutoSize = true;
            this.firearmCaliberLabel.Location = new System.Drawing.Point(13, 64);
            this.firearmCaliberLabel.Name = "firearmCaliberLabel";
            this.firearmCaliberLabel.Size = new System.Drawing.Size(42, 13);
            this.firearmCaliberLabel.TabIndex = 2;
            this.firearmCaliberLabel.Text = "Caliber:";
            // 
            // firearmManufacturerLabel
            // 
            this.firearmManufacturerLabel.AutoSize = true;
            this.firearmManufacturerLabel.Location = new System.Drawing.Point(13, 38);
            this.firearmManufacturerLabel.Name = "firearmManufacturerLabel";
            this.firearmManufacturerLabel.Size = new System.Drawing.Size(73, 13);
            this.firearmManufacturerLabel.TabIndex = 1;
            this.firearmManufacturerLabel.Text = "Manufacturer:";
            // 
            // firearmModelLabel
            // 
            this.firearmModelLabel.AutoSize = true;
            this.firearmModelLabel.Location = new System.Drawing.Point(13, 14);
            this.firearmModelLabel.Name = "firearmModelLabel";
            this.firearmModelLabel.Size = new System.Drawing.Size(39, 13);
            this.firearmModelLabel.TabIndex = 0;
            this.firearmModelLabel.Text = "Model:";
            // 
            // ammoTabPage
            // 
            this.ammoTabPage.Controls.Add(this.ammoSplitContainer);
            this.ammoTabPage.Location = new System.Drawing.Point(4, 22);
            this.ammoTabPage.Name = "ammoTabPage";
            this.ammoTabPage.Size = new System.Drawing.Size(792, 400);
            this.ammoTabPage.TabIndex = 2;
            this.ammoTabPage.Text = "Ammunition";
            this.ammoTabPage.UseVisualStyleBackColor = true;
            // 
            // ammoSplitContainer
            // 
            this.ammoSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ammoSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ammoSplitContainer.Name = "ammoSplitContainer";
            this.ammoSplitContainer.Size = new System.Drawing.Size(792, 400);
            this.ammoSplitContainer.SplitterDistance = 264;
            this.ammoSplitContainer.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Name = "MainForm";
            this.Text = "Roberta";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.firearmsTabPage.ResumeLayout(false);
            this.firearmsSplitContainer.Panel1.ResumeLayout(false);
            this.firearmsSplitContainer.Panel2.ResumeLayout(false);
            this.firearmsSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firearmsSplitContainer)).EndInit();
            this.firearmsSplitContainer.ResumeLayout(false);
            this.ammoTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ammoSplitContainer)).EndInit();
            this.ammoSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firearmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFirearmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFirearmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFirearmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ammunitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAmmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAmmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAmmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage logTabPage;
        private System.Windows.Forms.TabPage firearmsTabPage;
        private System.Windows.Forms.TabPage ammoTabPage;
        private System.Windows.Forms.SplitContainer firearmsSplitContainer;
        private System.Windows.Forms.SplitContainer ammoSplitContainer;
        private System.Windows.Forms.ListBox firearmsListBox;
        private System.Windows.Forms.Button firearmCancelButton;
        private System.Windows.Forms.Button firearmSaveButton;
        private System.Windows.Forms.TextBox firearmSerialNumberTextBox;
        private System.Windows.Forms.TextBox firearmCaliberTextBox;
        private System.Windows.Forms.TextBox firearmManufacturerTextBox;
        private System.Windows.Forms.TextBox firearmModelTextBox;
        private System.Windows.Forms.Label firearmSerialNumberLabel;
        private System.Windows.Forms.Label firearmCaliberLabel;
        private System.Windows.Forms.Label firearmManufacturerLabel;
        private System.Windows.Forms.Label firearmModelLabel;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}


namespace Snakii
{
    partial class MapEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapEditor));
            this.editPanel = new System.Windows.Forms.Panel();
            this.wallTool = new System.Windows.Forms.RadioButton();
            this.testButton = new EllipseButton();
            this.nofoodTool = new System.Windows.Forms.RadioButton();
            this.spawnTool = new System.Windows.Forms.RadioButton();
            this.teleportTool = new System.Windows.Forms.RadioButton();
            this.toolsTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.removeTool = new System.Windows.Forms.RadioButton();
            this.goalTool = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNameLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.spawnToolDirection = new System.Windows.Forms.ToolStripComboBox();
            this.setTeleportPos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rectFill = new System.Windows.Forms.ToolStripButton();
            this.normalMode = new System.Windows.Forms.RadioButton();
            this.fillMode = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rectangleMode = new System.Windows.Forms.RadioButton();
            this.lineMode = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.Black;
            this.editPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editPanel.Location = new System.Drawing.Point(0, 56);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(500, 500);
            this.editPanel.TabIndex = 1;
            this.editPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editPanel_Paint);
            this.editPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.editPanel_MouseDown);
            this.editPanel.MouseEnter += new System.EventHandler(this.editPanel_MouseEnter);
            this.editPanel.MouseLeave += new System.EventHandler(this.editPanel_MouseLeave);
            this.editPanel.MouseHover += new System.EventHandler(this.editPanel_MouseHover);
            this.editPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.editPanel_MouseMove);
            this.editPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.editPanel_MouseUp);
            // 
            // wallTool
            // 
            this.wallTool.Appearance = System.Windows.Forms.Appearance.Button;
            this.wallTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.wallTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wallTool.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.wallTool.FlatAppearance.BorderSize = 3;
            this.wallTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wallTool.Location = new System.Drawing.Point(528, 274);
            this.wallTool.Name = "wallTool";
            this.wallTool.Size = new System.Drawing.Size(30, 30);
            this.wallTool.TabIndex = 1;
            this.wallTool.TabStop = true;
            this.toolsTooltip.SetToolTip(this.wallTool, "Add a wall to the map.");
            this.wallTool.UseVisualStyleBackColor = false;
            this.wallTool.CheckedChanged += new System.EventHandler(this.wallTool_CheckedChanged);
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.Silver;
            this.testButton.BackgroundImage = global::Snakii.Properties.Resources.Play50px;
            this.testButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.testButton.BorderColor = System.Drawing.SystemColors.Desktop;
            this.testButton.BorderWidth = 3;
            this.testButton.FlatAppearance.BorderSize = 0;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testButton.Location = new System.Drawing.Point(504, 310);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(80, 80);
            this.testButton.TabIndex = 0;
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // nofoodTool
            // 
            this.nofoodTool.Appearance = System.Windows.Forms.Appearance.Button;
            this.nofoodTool.BackColor = System.Drawing.Color.IndianRed;
            this.nofoodTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nofoodTool.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.nofoodTool.FlatAppearance.BorderSize = 3;
            this.nofoodTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nofoodTool.Location = new System.Drawing.Point(528, 202);
            this.nofoodTool.Name = "nofoodTool";
            this.nofoodTool.Size = new System.Drawing.Size(30, 30);
            this.nofoodTool.TabIndex = 3;
            this.nofoodTool.TabStop = true;
            this.toolsTooltip.SetToolTip(this.nofoodTool, "Add a no food zone.");
            this.nofoodTool.UseVisualStyleBackColor = false;
            this.nofoodTool.CheckedChanged += new System.EventHandler(this.nofoodTool_CheckedChanged);
            // 
            // spawnTool
            // 
            this.spawnTool.Appearance = System.Windows.Forms.Appearance.Button;
            this.spawnTool.BackColor = System.Drawing.Color.Yellow;
            this.spawnTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spawnTool.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.spawnTool.FlatAppearance.BorderSize = 3;
            this.spawnTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spawnTool.Location = new System.Drawing.Point(528, 398);
            this.spawnTool.Name = "spawnTool";
            this.spawnTool.Size = new System.Drawing.Size(30, 30);
            this.spawnTool.TabIndex = 4;
            this.spawnTool.TabStop = true;
            this.toolsTooltip.SetToolTip(this.spawnTool, "Set the spawn position of the player.");
            this.spawnTool.UseVisualStyleBackColor = false;
            this.spawnTool.CheckedChanged += new System.EventHandler(this.spawnTool_CheckedChanged);
            // 
            // teleportTool
            // 
            this.teleportTool.Appearance = System.Windows.Forms.Appearance.Button;
            this.teleportTool.BackColor = System.Drawing.Color.RoyalBlue;
            this.teleportTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teleportTool.Enabled = false;
            this.teleportTool.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.teleportTool.FlatAppearance.BorderSize = 3;
            this.teleportTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teleportTool.Location = new System.Drawing.Point(528, 434);
            this.teleportTool.Name = "teleportTool";
            this.teleportTool.Size = new System.Drawing.Size(30, 30);
            this.teleportTool.TabIndex = 5;
            this.teleportTool.TabStop = true;
            this.toolsTooltip.SetToolTip(this.teleportTool, "Add a teleport to the map.");
            this.teleportTool.UseVisualStyleBackColor = false;
            this.teleportTool.CheckedChanged += new System.EventHandler(this.teleportTool_CheckedChanged);
            // 
            // toolsTooltip
            // 
            this.toolsTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolsTooltip.ToolTipTitle = "Tool:";
            // 
            // removeTool
            // 
            this.removeTool.Appearance = System.Windows.Forms.Appearance.Button;
            this.removeTool.BackColor = System.Drawing.Color.Black;
            this.removeTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeTool.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.removeTool.FlatAppearance.BorderSize = 3;
            this.removeTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTool.Location = new System.Drawing.Point(528, 238);
            this.removeTool.Name = "removeTool";
            this.removeTool.Size = new System.Drawing.Size(30, 30);
            this.removeTool.TabIndex = 2;
            this.removeTool.TabStop = true;
            this.toolsTooltip.SetToolTip(this.removeTool, "Remove a zone.");
            this.removeTool.UseVisualStyleBackColor = false;
            this.removeTool.CheckedChanged += new System.EventHandler(this.removeTool_CheckedChanged);
            // 
            // goalTool
            // 
            this.goalTool.Appearance = System.Windows.Forms.Appearance.Button;
            this.goalTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.goalTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goalTool.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.goalTool.FlatAppearance.BorderSize = 3;
            this.goalTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goalTool.Location = new System.Drawing.Point(528, 470);
            this.goalTool.Name = "goalTool";
            this.goalTool.Size = new System.Drawing.Size(30, 30);
            this.goalTool.TabIndex = 5;
            this.goalTool.TabStop = true;
            this.toolsTooltip.SetToolTip(this.goalTool, "Set the position of the goal.");
            this.goalTool.UseVisualStyleBackColor = false;
            this.goalTool.CheckedChanged += new System.EventHandler(this.goalTool_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 556);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGridToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showGridToolStripMenuItem
            // 
            this.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem";
            this.showGridToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.showGridToolStripMenuItem.Text = "Show Grid";
            this.showGridToolStripMenuItem.Click += new System.EventHandler(this.showGridToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNameLabel,
            this.toolStripSeparator1,
            this.spawnToolDirection,
            this.setTeleportPos,
            this.toolStripSeparator2,
            this.rectFill});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(591, 26);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolNameLabel
            // 
            this.toolNameLabel.Name = "toolNameLabel";
            this.toolNameLabel.Size = new System.Drawing.Size(0, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // spawnToolDirection
            // 
            this.spawnToolDirection.Items.AddRange(new object[] {
            "Down",
            "Left",
            "Right",
            "Up"});
            this.spawnToolDirection.MaxDropDownItems = 4;
            this.spawnToolDirection.MaxLength = 4;
            this.spawnToolDirection.Name = "spawnToolDirection";
            this.spawnToolDirection.Size = new System.Drawing.Size(121, 26);
            this.spawnToolDirection.ToolTipText = "Direction of spawn";
            this.spawnToolDirection.Visible = false;
            this.spawnToolDirection.SelectedIndexChanged += new System.EventHandler(this.spawnToolDirection_SelectedIndexChanged);
            // 
            // setTeleportPos
            // 
            this.setTeleportPos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.setTeleportPos.Image = ((System.Drawing.Image)(resources.GetObject("setTeleportPos.Image")));
            this.setTeleportPos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setTeleportPos.Name = "setTeleportPos";
            this.setTeleportPos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.setTeleportPos.Size = new System.Drawing.Size(117, 23);
            this.setTeleportPos.Text = "Set teleport position";
            this.setTeleportPos.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // rectFill
            // 
            this.rectFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rectFill.Checked = true;
            this.rectFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rectFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rectFill.Image = ((System.Drawing.Image)(resources.GetObject("rectFill.Image")));
            this.rectFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectFill.Name = "rectFill";
            this.rectFill.Size = new System.Drawing.Size(31, 23);
            this.rectFill.Text = "Fill?";
            this.rectFill.Visible = false;
            this.rectFill.Click += new System.EventHandler(this.rectFill_Click);
            // 
            // normalMode
            // 
            this.normalMode.AutoSize = true;
            this.normalMode.Checked = true;
            this.normalMode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.normalMode.Location = new System.Drawing.Point(6, 30);
            this.normalMode.Name = "normalMode";
            this.normalMode.Size = new System.Drawing.Size(58, 17);
            this.normalMode.TabIndex = 9;
            this.normalMode.TabStop = true;
            this.normalMode.Text = "Normal";
            this.normalMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.normalMode.UseVisualStyleBackColor = true;
            // 
            // fillMode
            // 
            this.fillMode.AutoSize = true;
            this.fillMode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fillMode.Location = new System.Drawing.Point(6, 53);
            this.fillMode.Name = "fillMode";
            this.fillMode.Size = new System.Drawing.Size(37, 17);
            this.fillMode.TabIndex = 9;
            this.fillMode.Text = "Fill";
            this.fillMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fillMode.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.normalMode);
            this.groupBox1.Controls.Add(this.rectangleMode);
            this.groupBox1.Controls.Add(this.lineMode);
            this.groupBox1.Controls.Add(this.fillMode);
            this.groupBox1.Location = new System.Drawing.Point(507, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(78, 125);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw Mode:";
            // 
            // rectangleMode
            // 
            this.rectangleMode.AutoSize = true;
            this.rectangleMode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rectangleMode.Location = new System.Drawing.Point(6, 99);
            this.rectangleMode.Name = "rectangleMode";
            this.rectangleMode.Size = new System.Drawing.Size(74, 17);
            this.rectangleMode.TabIndex = 9;
            this.rectangleMode.Text = "Rectangle";
            this.rectangleMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rectangleMode.UseVisualStyleBackColor = true;
            this.rectangleMode.CheckedChanged += new System.EventHandler(this.rectangleMode_CheckedChanged);
            // 
            // lineMode
            // 
            this.lineMode.AutoSize = true;
            this.lineMode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lineMode.Location = new System.Drawing.Point(6, 76);
            this.lineMode.Name = "lineMode";
            this.lineMode.Size = new System.Drawing.Size(45, 17);
            this.lineMode.TabIndex = 9;
            this.lineMode.Text = "Line";
            this.lineMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lineMode.UseVisualStyleBackColor = true;
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.goalTool);
            this.Controls.Add(this.teleportTool);
            this.Controls.Add(this.spawnTool);
            this.Controls.Add(this.removeTool);
            this.Controls.Add(this.nofoodTool);
            this.Controls.Add(this.wallTool);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MapEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapEditor";
            this.Load += new System.EventHandler(this.MapEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel editPanel;
        private EllipseButton testButton;
        private System.Windows.Forms.RadioButton wallTool;
        private System.Windows.Forms.RadioButton nofoodTool;
        private System.Windows.Forms.RadioButton spawnTool;
        private System.Windows.Forms.RadioButton teleportTool;
        private System.Windows.Forms.ToolTip toolsTooltip;
        private System.Windows.Forms.RadioButton removeTool;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolNameLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RadioButton goalTool;
        private System.Windows.Forms.ToolStripButton setTeleportPos;
        private System.Windows.Forms.RadioButton normalMode;
        private System.Windows.Forms.RadioButton fillMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rectangleMode;
        private System.Windows.Forms.RadioButton lineMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton rectFill;
        private System.Windows.Forms.ToolStripComboBox spawnToolDirection;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}
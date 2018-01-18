namespace Snakii
{
    partial class MapItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.mapDescription = new System.Windows.Forms.RichTextBox();
            this.deleteMap = new System.Windows.Forms.Button();
            this.mapValue = new System.Windows.Forms.Label();
            this.mapObjective = new System.Windows.Forms.Label();
            this.mapName = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.loadMap = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.mapDescription);
            this.panel2.Controls.Add(this.loadMap);
            this.panel2.Controls.Add(this.undoButton);
            this.panel2.Controls.Add(this.deleteMap);
            this.panel2.Controls.Add(this.mapValue);
            this.panel2.Controls.Add(this.mapObjective);
            this.panel2.Controls.Add(this.mapName);
            this.panel2.Controls.Add(this.image);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 94);
            this.panel2.TabIndex = 1;
            // 
            // mapDescription
            // 
            this.mapDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mapDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mapDescription.Location = new System.Drawing.Point(90, 22);
            this.mapDescription.Name = "mapDescription";
            this.mapDescription.ReadOnly = true;
            this.mapDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.mapDescription.Size = new System.Drawing.Size(190, 44);
            this.mapDescription.TabIndex = 3;
            this.mapDescription.Text = "";
            // 
            // deleteMap
            // 
            this.deleteMap.BackColor = System.Drawing.Color.DarkRed;
            this.deleteMap.FlatAppearance.BorderSize = 0;
            this.deleteMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMap.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteMap.Location = new System.Drawing.Point(234, 0);
            this.deleteMap.Name = "deleteMap";
            this.deleteMap.Size = new System.Drawing.Size(51, 21);
            this.deleteMap.TabIndex = 2;
            this.deleteMap.Text = "Delete";
            this.deleteMap.UseVisualStyleBackColor = false;
            this.deleteMap.Click += new System.EventHandler(this.deleteMap_Click);
            // 
            // mapValue
            // 
            this.mapValue.AutoSize = true;
            this.mapValue.Location = new System.Drawing.Point(163, 78);
            this.mapValue.Name = "mapValue";
            this.mapValue.Size = new System.Drawing.Size(42, 13);
            this.mapValue.TabIndex = 1;
            this.mapValue.Text = "VALUE";
            this.mapValue.Visible = false;
            // 
            // mapObjective
            // 
            this.mapObjective.AutoSize = true;
            this.mapObjective.Location = new System.Drawing.Point(92, 78);
            this.mapObjective.Name = "mapObjective";
            this.mapObjective.Size = new System.Drawing.Size(65, 13);
            this.mapObjective.TabIndex = 1;
            this.mapObjective.Text = "OBJECTIVE";
            // 
            // mapName
            // 
            this.mapName.AutoSize = true;
            this.mapName.Location = new System.Drawing.Point(92, 8);
            this.mapName.Name = "mapName";
            this.mapName.Size = new System.Drawing.Size(61, 13);
            this.mapName.TabIndex = 1;
            this.mapName.Text = "MAPNAME";
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Black;
            this.image.Location = new System.Drawing.Point(6, 7);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(80, 80);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // loadMap
            // 
            this.loadMap.BackColor = System.Drawing.Color.DimGray;
            this.loadMap.FlatAppearance.BorderSize = 0;
            this.loadMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadMap.ForeColor = System.Drawing.SystemColors.Control;
            this.loadMap.Location = new System.Drawing.Point(234, 72);
            this.loadMap.Name = "loadMap";
            this.loadMap.Size = new System.Drawing.Size(51, 22);
            this.loadMap.TabIndex = 2;
            this.loadMap.Text = "Load";
            this.loadMap.UseVisualStyleBackColor = false;
            this.loadMap.Click += new System.EventHandler(this.loadMap_Click);
            // 
            // undoButton
            // 
            this.undoButton.BackColor = System.Drawing.Color.Purple;
            this.undoButton.FlatAppearance.BorderSize = 0;
            this.undoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.undoButton.Location = new System.Drawing.Point(182, 0);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(51, 21);
            this.undoButton.TabIndex = 2;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = false;
            this.undoButton.Visible = false;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // MapItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "MapItem";
            this.Size = new System.Drawing.Size(285, 94);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteMap;
        private System.Windows.Forms.Label mapObjective;
        private System.Windows.Forms.Label mapName;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.RichTextBox mapDescription;
        private System.Windows.Forms.Label mapValue;
        private System.Windows.Forms.Button loadMap;
        private System.Windows.Forms.Button undoButton;
    }
}

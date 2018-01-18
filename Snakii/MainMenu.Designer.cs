namespace Snakii
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.replayTicks = new System.Windows.Forms.Timer(this.components);
            this.underScore = new System.Windows.Forms.Timer(this.components);
            this.replayDisplay = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mapeditorButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.replayDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // replayTicks
            // 
            this.replayTicks.Enabled = true;
            this.replayTicks.Interval = 50;
            this.replayTicks.Tick += new System.EventHandler(this.replayTicks_Tick);
            // 
            // underScore
            // 
            this.underScore.Enabled = true;
            this.underScore.Interval = 500;
            this.underScore.Tick += new System.EventHandler(this.underScore_Tick);
            // 
            // replayDisplay
            // 
            this.replayDisplay.BackColor = System.Drawing.Color.Black;
            this.replayDisplay.Controls.Add(this.label1);
            this.replayDisplay.Controls.Add(this.mapeditorButton);
            this.replayDisplay.Controls.Add(this.playButton);
            this.replayDisplay.Location = new System.Drawing.Point(0, 30);
            this.replayDisplay.Name = "replayDisplay";
            this.replayDisplay.Size = new System.Drawing.Size(500, 500);
            this.replayDisplay.TabIndex = 1;
            this.replayDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.replayDisplay_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mononoki", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Snakii";
            // 
            // mapeditorButton
            // 
            this.mapeditorButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mapeditorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapeditorButton.Font = new System.Drawing.Font("mononoki", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapeditorButton.ForeColor = System.Drawing.Color.White;
            this.mapeditorButton.Location = new System.Drawing.Point(163, 275);
            this.mapeditorButton.Name = "mapeditorButton";
            this.mapeditorButton.Size = new System.Drawing.Size(180, 60);
            this.mapeditorButton.TabIndex = 0;
            this.mapeditorButton.Text = "MAP EDITOR";
            this.mapeditorButton.UseVisualStyleBackColor = true;
            this.mapeditorButton.Click += new System.EventHandler(this.mapeditorButton_Click);
            // 
            // playButton
            // 
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("mononoki", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(163, 182);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(180, 60);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 530);
            this.Controls.Add(this.replayDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.replayDisplay.ResumeLayout(false);
            this.replayDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel replayDisplay;
        private System.Windows.Forms.Button mapeditorButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Timer replayTicks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer underScore;
    }
}
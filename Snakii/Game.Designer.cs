namespace Snakii
{
    partial class Game
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
            this.gameTicks = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameDisplay = new System.Windows.Forms.Panel();
            this.endGamePanel = new System.Windows.Forms.Panel();
            this.restartButton = new System.Windows.Forms.Button();
            this.objectiveEndLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.endText = new System.Windows.Forms.Label();
            this.endScoreLabel = new System.Windows.Forms.Label();
            this.gameDisplay.SuspendLayout();
            this.endGamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTicks
            // 
            this.gameTicks.Interval = 50;
            this.gameTicks.Tick += new System.EventHandler(this.gameTicks_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(10, 39);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(47, 13);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score: 0";
            // 
            // gameDisplay
            // 
            this.gameDisplay.BackColor = System.Drawing.Color.Black;
            this.gameDisplay.Controls.Add(this.endGamePanel);
            this.gameDisplay.Location = new System.Drawing.Point(3, 60);
            this.gameDisplay.Name = "gameDisplay";
            this.gameDisplay.Size = new System.Drawing.Size(500, 500);
            this.gameDisplay.TabIndex = 1;
            this.gameDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.gameDisplay_Paint);
            // 
            // endGamePanel
            // 
            this.endGamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.endGamePanel.Controls.Add(this.restartButton);
            this.endGamePanel.Controls.Add(this.objectiveEndLabel);
            this.endGamePanel.Controls.Add(this.menuButton);
            this.endGamePanel.Controls.Add(this.endText);
            this.endGamePanel.Controls.Add(this.endScoreLabel);
            this.endGamePanel.Location = new System.Drawing.Point(0, 61);
            this.endGamePanel.Name = "endGamePanel";
            this.endGamePanel.Size = new System.Drawing.Size(500, 285);
            this.endGamePanel.TabIndex = 4;
            this.endGamePanel.Visible = false;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Black;
            this.restartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.ForeColor = System.Drawing.Color.White;
            this.restartButton.Location = new System.Drawing.Point(306, 222);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 42);
            this.restartButton.TabIndex = 0;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // objectiveEndLabel
            // 
            this.objectiveEndLabel.AutoSize = true;
            this.objectiveEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectiveEndLabel.ForeColor = System.Drawing.Color.White;
            this.objectiveEndLabel.Location = new System.Drawing.Point(125, 164);
            this.objectiveEndLabel.Name = "objectiveEndLabel";
            this.objectiveEndLabel.Size = new System.Drawing.Size(91, 20);
            this.objectiveEndLabel.TabIndex = 3;
            this.objectiveEndLabel.Text = "Objective: 0";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Black;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(129, 222);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 42);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // endText
            // 
            this.endText.BackColor = System.Drawing.Color.Transparent;
            this.endText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText.ForeColor = System.Drawing.Color.White;
            this.endText.Location = new System.Drawing.Point(1, 39);
            this.endText.Name = "endText";
            this.endText.Size = new System.Drawing.Size(500, 76);
            this.endText.TabIndex = 2;
            this.endText.Text = "You died! / You won!";
            this.endText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endScoreLabel
            // 
            this.endScoreLabel.AutoSize = true;
            this.endScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endScoreLabel.ForeColor = System.Drawing.Color.White;
            this.endScoreLabel.Location = new System.Drawing.Point(125, 132);
            this.endScoreLabel.Name = "endScoreLabel";
            this.endScoreLabel.Size = new System.Drawing.Size(68, 20);
            this.endScoreLabel.TabIndex = 3;
            this.endScoreLabel.Text = "Score: 0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 563);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gameDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.gameDisplay.ResumeLayout(false);
            this.endGamePanel.ResumeLayout(false);
            this.endGamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameDisplay;
        private System.Windows.Forms.Timer gameTicks;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel endGamePanel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label objectiveEndLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label endText;
        private System.Windows.Forms.Label endScoreLabel;
    }
}
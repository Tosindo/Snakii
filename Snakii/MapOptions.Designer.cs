namespace Snakii
{
    partial class MapOptions
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
            this.doneButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.objectiveType = new System.Windows.Forms.ComboBox();
            this.objectiveValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectiveValue)).BeginInit();
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(205, 239);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 5;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(65, 38);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(215, 20);
            this.nameBox.TabIndex = 0;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(11, 97);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(269, 96);
            this.descriptionBox.TabIndex = 1;
            this.descriptionBox.Text = "";
            // 
            // objectiveType
            // 
            this.objectiveType.FormattingEnabled = true;
            this.objectiveType.Items.AddRange(new object[] {
            "Score",
            "Goal"});
            this.objectiveType.Location = new System.Drawing.Point(96, 204);
            this.objectiveType.Name = "objectiveType";
            this.objectiveType.Size = new System.Drawing.Size(95, 21);
            this.objectiveType.TabIndex = 3;
            this.objectiveType.SelectedIndexChanged += new System.EventHandler(this.objectiveType_SelectedIndexChanged);
            // 
            // objectiveValue
            // 
            this.objectiveValue.Location = new System.Drawing.Point(197, 204);
            this.objectiveValue.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.objectiveValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.objectiveValue.Name = "objectiveValue";
            this.objectiveValue.Size = new System.Drawing.Size(83, 20);
            this.objectiveValue.TabIndex = 4;
            this.objectiveValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Objective Type:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(11, 237);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MapOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.objectiveValue);
            this.Controls.Add(this.objectiveType);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.doneButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MapOptions";
            this.Text = "Map Options:";
            this.Load += new System.EventHandler(this.MapOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectiveValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.ComboBox objectiveType;
        private System.Windows.Forms.NumericUpDown objectiveValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
    }
}
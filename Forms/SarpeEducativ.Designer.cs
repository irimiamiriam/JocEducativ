namespace JocEducativ.Forms
{
    partial class SarpeEducativ
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
            this.suprafataPanel = new System.Windows.Forms.Panel();
            this.punctajLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // suprafataPanel
            // 
            this.suprafataPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.suprafataPanel.Location = new System.Drawing.Point(21, 28);
            this.suprafataPanel.Name = "suprafataPanel";
            this.suprafataPanel.Size = new System.Drawing.Size(562, 426);
            this.suprafataPanel.TabIndex = 0;
            // 
            // punctajLabel
            // 
            this.punctajLabel.AutoSize = true;
            this.punctajLabel.Font = new System.Drawing.Font("Kristen ITC", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punctajLabel.ForeColor = System.Drawing.Color.Crimson;
            this.punctajLabel.Location = new System.Drawing.Point(657, 182);
            this.punctajLabel.Name = "punctajLabel";
            this.punctajLabel.Size = new System.Drawing.Size(263, 36);
            this.punctajLabel.TabIndex = 1;
            this.punctajLabel.Text = "Afisare punctaj : 0";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Kristen ITC", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.LightCoral;
            this.startButton.Location = new System.Drawing.Point(612, 251);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(147, 41);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start joc";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Kristen ITC", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.LightCoral;
            this.stopButton.Location = new System.Drawing.Point(812, 251);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(147, 41);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop joc";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // SarpeEducativ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 510);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.punctajLabel);
            this.Controls.Add(this.suprafataPanel);
            this.Name = "SarpeEducativ";
            this.Text = "Sarpe";
            this.Load += new System.EventHandler(this.SarpeEducativ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel suprafataPanel;
        private System.Windows.Forms.Label punctajLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
    }
}
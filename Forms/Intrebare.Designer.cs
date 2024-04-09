namespace JocEducativ.Forms
{
    partial class Intrebare
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
            this.intrebareTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.raspunsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // intrebareTextBox
            // 
            this.intrebareTextBox.Location = new System.Drawing.Point(27, 18);
            this.intrebareTextBox.Multiline = true;
            this.intrebareTextBox.Name = "intrebareTextBox";
            this.intrebareTextBox.Size = new System.Drawing.Size(1000, 234);
            this.intrebareTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(27, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 230);
            this.panel1.TabIndex = 1;
            // 
            // raspunsButton
            // 
            this.raspunsButton.ForeColor = System.Drawing.Color.Crimson;
            this.raspunsButton.Location = new System.Drawing.Point(391, 536);
            this.raspunsButton.Name = "raspunsButton";
            this.raspunsButton.Size = new System.Drawing.Size(265, 89);
            this.raspunsButton.TabIndex = 2;
            this.raspunsButton.Text = "Inregistreaza raspuns";
            this.raspunsButton.UseVisualStyleBackColor = true;
            this.raspunsButton.Click += new System.EventHandler(this.raspunsButton_Click);
            // 
            // Intrebare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1048, 654);
            this.Controls.Add(this.raspunsButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.intrebareTextBox);
            this.Name = "Intrebare";
            this.Text = "Intrebare";
            this.Load += new System.EventHandler(this.Intrebare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox intrebareTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button raspunsButton;
    }
}
namespace JocEducativ.Forms
{
    partial class AlegeJoc
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.topGhicestedataGridView = new System.Windows.Forms.DataGridView();
            this.topSarpedataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ghicesteButton = new System.Windows.Forms.Button();
            this.sarpeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.topGhicestedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSarpedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Crimson;
            this.welcomeLabel.Location = new System.Drawing.Point(31, 36);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(234, 44);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Bine ai venit!";
            // 
            // topGhicestedataGridView
            // 
            this.topGhicestedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.topGhicestedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topGhicestedataGridView.Location = new System.Drawing.Point(39, 169);
            this.topGhicestedataGridView.Name = "topGhicestedataGridView";
            this.topGhicestedataGridView.RowHeadersWidth = 82;
            this.topGhicestedataGridView.RowTemplate.Height = 33;
            this.topGhicestedataGridView.Size = new System.Drawing.Size(499, 352);
            this.topGhicestedataGridView.TabIndex = 3;
            // 
            // topSarpedataGridView
            // 
            this.topSarpedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.topSarpedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topSarpedataGridView.Location = new System.Drawing.Point(604, 169);
            this.topSarpedataGridView.Name = "topSarpedataGridView";
            this.topSarpedataGridView.RowHeadersWidth = 82;
            this.topSarpedataGridView.RowTemplate.Height = 33;
            this.topSarpedataGridView.Size = new System.Drawing.Size(499, 352);
            this.topSarpedataGridView.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(174, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Top scor Ghiceste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(695, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Top scor Sarpele Educativ";
            // 
            // ghicesteButton
            // 
            this.ghicesteButton.BackColor = System.Drawing.Color.Crimson;
            this.ghicesteButton.Font = new System.Drawing.Font("MV Boli", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghicesteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ghicesteButton.Location = new System.Drawing.Point(160, 570);
            this.ghicesteButton.Name = "ghicesteButton";
            this.ghicesteButton.Size = new System.Drawing.Size(240, 66);
            this.ghicesteButton.TabIndex = 7;
            this.ghicesteButton.Text = "Ghiceste";
            this.ghicesteButton.UseVisualStyleBackColor = false;
            this.ghicesteButton.Click += new System.EventHandler(this.ghicesteButton_Click);
            // 
            // sarpeButton
            // 
            this.sarpeButton.BackColor = System.Drawing.Color.Crimson;
            this.sarpeButton.Font = new System.Drawing.Font("MV Boli", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sarpeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sarpeButton.Location = new System.Drawing.Point(753, 570);
            this.sarpeButton.Name = "sarpeButton";
            this.sarpeButton.Size = new System.Drawing.Size(240, 66);
            this.sarpeButton.TabIndex = 8;
            this.sarpeButton.Text = "Sarpe Educativ";
            this.sarpeButton.UseVisualStyleBackColor = false;
            this.sarpeButton.Click += new System.EventHandler(this.sarpeButton_Click);
            // 
            // AlegeJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1142, 697);
            this.Controls.Add(this.sarpeButton);
            this.Controls.Add(this.ghicesteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.topSarpedataGridView);
            this.Controls.Add(this.topGhicestedataGridView);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "AlegeJoc";
            this.Text = "Alege Joc";
            this.Load += new System.EventHandler(this.AlegeJoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topGhicestedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSarpedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.DataGridView topGhicestedataGridView;
        private System.Windows.Forms.DataGridView topSarpedataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ghicesteButton;
        private System.Windows.Forms.Button sarpeButton;
    }
}
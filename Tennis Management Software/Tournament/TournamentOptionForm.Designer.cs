namespace Tennis_Management_Software.Tournament
{
    partial class TournamentOptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentOptionForm));
            this.newTourButton = new System.Windows.Forms.Button();
            this.openExistingTourButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newTourButton
            // 
            this.newTourButton.Location = new System.Drawing.Point(12, 12);
            this.newTourButton.Name = "newTourButton";
            this.newTourButton.Size = new System.Drawing.Size(258, 57);
            this.newTourButton.TabIndex = 0;
            this.newTourButton.Text = "Create a new tournament";
            this.newTourButton.UseVisualStyleBackColor = true;
            this.newTourButton.Click += new System.EventHandler(this.newTourButton_Click);
            // 
            // openExistingTourButton
            // 
            this.openExistingTourButton.Location = new System.Drawing.Point(12, 75);
            this.openExistingTourButton.Name = "openExistingTourButton";
            this.openExistingTourButton.Size = new System.Drawing.Size(258, 57);
            this.openExistingTourButton.TabIndex = 1;
            this.openExistingTourButton.Text = "Open an existing tournament";
            this.openExistingTourButton.UseVisualStyleBackColor = true;
            this.openExistingTourButton.Click += new System.EventHandler(this.openExistingTourButton_Click);
            // 
            // TournamentOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 142);
            this.Controls.Add(this.openExistingTourButton);
            this.Controls.Add(this.newTourButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TournamentOptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tournament Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newTourButton;
        private System.Windows.Forms.Button openExistingTourButton;
    }
}
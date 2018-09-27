namespace Tennis_Management_Software
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.privateLessonLabel = new System.Windows.Forms.Label();
            this.groupLessonLabel = new System.Windows.Forms.Label();
            this.privateLessonNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupLessonNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.semiPrivateNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.semiPrivateLessonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privateLessonNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLessonNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semiPrivateNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // privateLessonLabel
            // 
            this.privateLessonLabel.AutoSize = true;
            this.privateLessonLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privateLessonLabel.Location = new System.Drawing.Point(6, 7);
            this.privateLessonLabel.Name = "privateLessonLabel";
            this.privateLessonLabel.Size = new System.Drawing.Size(119, 17);
            this.privateLessonLabel.TabIndex = 0;
            this.privateLessonLabel.Text = "Private lesson fees:";
            // 
            // groupLessonLabel
            // 
            this.groupLessonLabel.AutoSize = true;
            this.groupLessonLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLessonLabel.Location = new System.Drawing.Point(6, 34);
            this.groupLessonLabel.Name = "groupLessonLabel";
            this.groupLessonLabel.Size = new System.Drawing.Size(117, 17);
            this.groupLessonLabel.TabIndex = 1;
            this.groupLessonLabel.Text = "Group lesson fees:";
            // 
            // privateLessonNumUpDown
            // 
            this.privateLessonNumUpDown.DecimalPlaces = 2;
            this.privateLessonNumUpDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privateLessonNumUpDown.Location = new System.Drawing.Point(164, 5);
            this.privateLessonNumUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.privateLessonNumUpDown.Name = "privateLessonNumUpDown";
            this.privateLessonNumUpDown.Size = new System.Drawing.Size(120, 25);
            this.privateLessonNumUpDown.TabIndex = 3;
            this.privateLessonNumUpDown.ThousandsSeparator = true;
            // 
            // groupLessonNumUpDown
            // 
            this.groupLessonNumUpDown.DecimalPlaces = 2;
            this.groupLessonNumUpDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLessonNumUpDown.Location = new System.Drawing.Point(164, 32);
            this.groupLessonNumUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.groupLessonNumUpDown.Name = "groupLessonNumUpDown";
            this.groupLessonNumUpDown.Size = new System.Drawing.Size(120, 25);
            this.groupLessonNumUpDown.TabIndex = 4;
            this.groupLessonNumUpDown.ThousandsSeparator = true;
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(86, 100);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 35);
            this.saveButton.TabIndex = 6;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(183, 100);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(91, 35);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // semiPrivateNumUpDown
            // 
            this.semiPrivateNumUpDown.DecimalPlaces = 2;
            this.semiPrivateNumUpDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semiPrivateNumUpDown.Location = new System.Drawing.Point(164, 58);
            this.semiPrivateNumUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.semiPrivateNumUpDown.Name = "semiPrivateNumUpDown";
            this.semiPrivateNumUpDown.Size = new System.Drawing.Size(120, 25);
            this.semiPrivateNumUpDown.TabIndex = 5;
            this.semiPrivateNumUpDown.ThousandsSeparator = true;
            // 
            // semiPrivateLessonLabel
            // 
            this.semiPrivateLessonLabel.AutoSize = true;
            this.semiPrivateLessonLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semiPrivateLessonLabel.Location = new System.Drawing.Point(6, 60);
            this.semiPrivateLessonLabel.Name = "semiPrivateLessonLabel";
            this.semiPrivateLessonLabel.Size = new System.Drawing.Size(152, 17);
            this.semiPrivateLessonLabel.TabIndex = 2;
            this.semiPrivateLessonLabel.Text = "Semi-Private lesson fees:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 138);
            this.Controls.Add(this.semiPrivateNumUpDown);
            this.Controls.Add(this.semiPrivateLessonLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupLessonNumUpDown);
            this.Controls.Add(this.privateLessonNumUpDown);
            this.Controls.Add(this.groupLessonLabel);
            this.Controls.Add(this.privateLessonLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.privateLessonNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLessonNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semiPrivateNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label privateLessonLabel;
        private System.Windows.Forms.Label groupLessonLabel;
        private System.Windows.Forms.NumericUpDown privateLessonNumUpDown;
        private System.Windows.Forms.NumericUpDown groupLessonNumUpDown;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown semiPrivateNumUpDown;
        private System.Windows.Forms.Label semiPrivateLessonLabel;

    }
}
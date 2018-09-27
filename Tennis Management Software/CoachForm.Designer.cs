namespace Tennis_Management_Software
{
    partial class CoachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoachForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchPicture = new Tennis_Management_Software.PictureInput();
            this.lessonsListBox = new System.Windows.Forms.ListBox();
            this.bottomRightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.extraHourlyPaymentRateNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourlyPaymentRateNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.extraHourlyPaymentRateLabel = new System.Windows.Forms.Label();
            this.hourlyPaymentRateLabel = new System.Windows.Forms.Label();
            this.addTimetableButton = new System.Windows.Forms.Button();
            this.inputInformation = new Tennis_Management_Software.InputInformation();
            this.lessonContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainTableLayoutPanel.SuspendLayout();
            this.bottomRightTableLayoutPanel.SuspendLayout();
            this.informationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extraHourlyPaymentRateNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyPaymentRateNumUpDown)).BeginInit();
            this.lessonContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.78F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.22F));
            this.mainTableLayoutPanel.Controls.Add(this.searchPicture, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.lessonsListBox, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.bottomRightTableLayoutPanel, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.informationPanel, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.1956F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.8044F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(664, 409);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // searchPicture
            // 
            this.searchPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPicture.Location = new System.Drawing.Point(273, 3);
            this.searchPicture.Name = "searchPicture";
            this.searchPicture.Size = new System.Drawing.Size(388, 322);
            this.searchPicture.TabIndex = 0;
            // 
            // lessonsListBox
            // 
            this.lessonsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lessonsListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonsListBox.FormattingEnabled = true;
            this.lessonsListBox.ItemHeight = 15;
            this.lessonsListBox.Location = new System.Drawing.Point(3, 331);
            this.lessonsListBox.Name = "lessonsListBox";
            this.lessonsListBox.Size = new System.Drawing.Size(264, 75);
            this.lessonsListBox.TabIndex = 0;
            this.lessonsListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lessonsListBox_MouseUp);
            // 
            // bottomRightTableLayoutPanel
            // 
            this.bottomRightTableLayoutPanel.ColumnCount = 2;
            this.bottomRightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomRightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomRightTableLayoutPanel.Controls.Add(this.cancelButton, 1, 0);
            this.bottomRightTableLayoutPanel.Controls.Add(this.saveButton, 0, 0);
            this.bottomRightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRightTableLayoutPanel.Location = new System.Drawing.Point(273, 331);
            this.bottomRightTableLayoutPanel.Name = "bottomRightTableLayoutPanel";
            this.bottomRightTableLayoutPanel.RowCount = 1;
            this.bottomRightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomRightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.bottomRightTableLayoutPanel.Size = new System.Drawing.Size(388, 75);
            this.bottomRightTableLayoutPanel.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(197, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(188, 69);
            this.cancelButton.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.cancelButton, "Cancel");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(188, 69);
            this.saveButton.TabIndex = 0;
            this.mainToolTip.SetToolTip(this.saveButton, "Save");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // informationPanel
            // 
            this.informationPanel.Controls.Add(this.extraHourlyPaymentRateNumUpDown);
            this.informationPanel.Controls.Add(this.hourlyPaymentRateNumUpDown);
            this.informationPanel.Controls.Add(this.extraHourlyPaymentRateLabel);
            this.informationPanel.Controls.Add(this.hourlyPaymentRateLabel);
            this.informationPanel.Controls.Add(this.addTimetableButton);
            this.informationPanel.Controls.Add(this.inputInformation);
            this.informationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationPanel.Location = new System.Drawing.Point(3, 3);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(264, 322);
            this.informationPanel.TabIndex = 7;
            // 
            // extraHourlyPaymentRateNumUpDown
            // 
            this.extraHourlyPaymentRateNumUpDown.DecimalPlaces = 2;
            this.extraHourlyPaymentRateNumUpDown.Location = new System.Drawing.Point(150, 263);
            this.extraHourlyPaymentRateNumUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.extraHourlyPaymentRateNumUpDown.Name = "extraHourlyPaymentRateNumUpDown";
            this.extraHourlyPaymentRateNumUpDown.Size = new System.Drawing.Size(104, 20);
            this.extraHourlyPaymentRateNumUpDown.TabIndex = 4;
            // 
            // hourlyPaymentRateNumUpDown
            // 
            this.hourlyPaymentRateNumUpDown.DecimalPlaces = 2;
            this.hourlyPaymentRateNumUpDown.Location = new System.Drawing.Point(150, 237);
            this.hourlyPaymentRateNumUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.hourlyPaymentRateNumUpDown.Name = "hourlyPaymentRateNumUpDown";
            this.hourlyPaymentRateNumUpDown.Size = new System.Drawing.Size(104, 20);
            this.hourlyPaymentRateNumUpDown.TabIndex = 3;
            // 
            // extraHourlyPaymentRateLabel
            // 
            this.extraHourlyPaymentRateLabel.AutoSize = true;
            this.extraHourlyPaymentRateLabel.Location = new System.Drawing.Point(3, 265);
            this.extraHourlyPaymentRateLabel.Name = "extraHourlyPaymentRateLabel";
            this.extraHourlyPaymentRateLabel.Size = new System.Drawing.Size(141, 13);
            this.extraHourlyPaymentRateLabel.TabIndex = 2;
            this.extraHourlyPaymentRateLabel.Text = "Extra hourly rate of payment:";
            // 
            // hourlyPaymentRateLabel
            // 
            this.hourlyPaymentRateLabel.AutoSize = true;
            this.hourlyPaymentRateLabel.Location = new System.Drawing.Point(3, 239);
            this.hourlyPaymentRateLabel.Name = "hourlyPaymentRateLabel";
            this.hourlyPaymentRateLabel.Size = new System.Drawing.Size(104, 13);
            this.hourlyPaymentRateLabel.TabIndex = 1;
            this.hourlyPaymentRateLabel.Text = "Hourly payment rate:";
            // 
            // addTimetableButton
            // 
            this.addTimetableButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTimetableButton.Location = new System.Drawing.Point(2, 293);
            this.addTimetableButton.Name = "addTimetableButton";
            this.addTimetableButton.Size = new System.Drawing.Size(103, 23);
            this.addTimetableButton.TabIndex = 5;
            this.addTimetableButton.Text = "Add Timetable";
            this.addTimetableButton.UseVisualStyleBackColor = true;
            this.addTimetableButton.Click += new System.EventHandler(this.addTimetableButton_Click);
            // 
            // inputInformation
            // 
            this.inputInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputInformation.Location = new System.Drawing.Point(0, 0);
            this.inputInformation.Name = "inputInformation";
            this.inputInformation.Size = new System.Drawing.Size(264, 236);
            this.inputInformation.TabIndex = 0;
            // 
            // lessonContextMenuStrip
            // 
            this.lessonContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.lessonContextMenuStrip.Name = "lessonContextMenuStrip";
            this.lessonContextMenuStrip.Size = new System.Drawing.Size(118, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // CoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 409);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CoachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Coach";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.bottomRightTableLayoutPanel.ResumeLayout(false);
            this.informationPanel.ResumeLayout(false);
            this.informationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extraHourlyPaymentRateNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyPaymentRateNumUpDown)).EndInit();
            this.lessonContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private PictureInput searchPicture;
        private System.Windows.Forms.ListBox lessonsListBox;
        private System.Windows.Forms.TableLayoutPanel bottomRightTableLayoutPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.Button addTimetableButton;
        private InputInformation inputInformation;
        private System.Windows.Forms.Label hourlyPaymentRateLabel;
        private System.Windows.Forms.NumericUpDown hourlyPaymentRateNumUpDown;
        private System.Windows.Forms.Label extraHourlyPaymentRateLabel;
        private System.Windows.Forms.NumericUpDown extraHourlyPaymentRateNumUpDown;
        private System.Windows.Forms.ContextMenuStrip lessonContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolTip mainToolTip;
    }
}
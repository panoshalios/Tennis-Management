namespace Tennis_Management_Software
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.mainTLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bottomRightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.inputInformation = new Tennis_Management_Software.InputInformation();
            this.addTimetableButton = new System.Windows.Forms.Button();
            this.healthCertificateNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.motherPhoneNumLabel = new System.Windows.Forms.Label();
            this.studentLevelLabel = new System.Windows.Forms.Label();
            this.staNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.studentLevelCbox = new System.Windows.Forms.ComboBox();
            this.motherNameTbox = new System.Windows.Forms.TextBox();
            this.fatherPhoneNumLabel = new System.Windows.Forms.Label();
            this.fatherNameTbox = new System.Windows.Forms.TextBox();
            this.motherPhoneNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.staNumLabel = new System.Windows.Forms.Label();
            this.fatherPhoneNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.healthCertificateNumLabel = new System.Windows.Forms.Label();
            this.fatherNameLabel = new System.Windows.Forms.Label();
            this.motherNameLabel = new System.Windows.Forms.Label();
            this.lessonsListBox = new System.Windows.Forms.ListBox();
            this.searchPicture = new Tennis_Management_Software.PictureInput();
            this.lessonContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainTLayoutPanel.SuspendLayout();
            this.bottomRightTableLayoutPanel.SuspendLayout();
            this.informationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthCertificateNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherPhoneNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatherPhoneNumUpDown)).BeginInit();
            this.lessonContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTLayoutPanel
            // 
            this.mainTLayoutPanel.ColumnCount = 2;
            this.mainTLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.7767F));
            this.mainTLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.2233F));
            this.mainTLayoutPanel.Controls.Add(this.bottomRightTableLayoutPanel, 1, 1);
            this.mainTLayoutPanel.Controls.Add(this.informationPanel, 0, 0);
            this.mainTLayoutPanel.Controls.Add(this.lessonsListBox, 0, 1);
            this.mainTLayoutPanel.Controls.Add(this.searchPicture, 1, 0);
            this.mainTLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTLayoutPanel.Name = "mainTLayoutPanel";
            this.mainTLayoutPanel.RowCount = 2;
            this.mainTLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.0922F));
            this.mainTLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.9078F));
            this.mainTLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTLayoutPanel.Size = new System.Drawing.Size(648, 564);
            this.mainTLayoutPanel.TabIndex = 0;
            // 
            // bottomRightTableLayoutPanel
            // 
            this.bottomRightTableLayoutPanel.ColumnCount = 2;
            this.bottomRightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomRightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomRightTableLayoutPanel.Controls.Add(this.cancelButton, 1, 0);
            this.bottomRightTableLayoutPanel.Controls.Add(this.saveButton, 0, 0);
            this.bottomRightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRightTableLayoutPanel.Location = new System.Drawing.Point(267, 466);
            this.bottomRightTableLayoutPanel.Name = "bottomRightTableLayoutPanel";
            this.bottomRightTableLayoutPanel.RowCount = 1;
            this.bottomRightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomRightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.bottomRightTableLayoutPanel.Size = new System.Drawing.Size(378, 95);
            this.bottomRightTableLayoutPanel.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(192, 34);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(183, 58);
            this.cancelButton.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.cancelButton, "Cancel");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(3, 34);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(183, 58);
            this.saveButton.TabIndex = 0;
            this.mainToolTip.SetToolTip(this.saveButton, "Save the student");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // informationPanel
            // 
            this.informationPanel.Controls.Add(this.inputInformation);
            this.informationPanel.Controls.Add(this.addTimetableButton);
            this.informationPanel.Controls.Add(this.healthCertificateNumUpDown);
            this.informationPanel.Controls.Add(this.motherPhoneNumLabel);
            this.informationPanel.Controls.Add(this.studentLevelLabel);
            this.informationPanel.Controls.Add(this.staNumUpDown);
            this.informationPanel.Controls.Add(this.studentLevelCbox);
            this.informationPanel.Controls.Add(this.motherNameTbox);
            this.informationPanel.Controls.Add(this.fatherPhoneNumLabel);
            this.informationPanel.Controls.Add(this.fatherNameTbox);
            this.informationPanel.Controls.Add(this.motherPhoneNumUpDown);
            this.informationPanel.Controls.Add(this.staNumLabel);
            this.informationPanel.Controls.Add(this.fatherPhoneNumUpDown);
            this.informationPanel.Controls.Add(this.healthCertificateNumLabel);
            this.informationPanel.Controls.Add(this.fatherNameLabel);
            this.informationPanel.Controls.Add(this.motherNameLabel);
            this.informationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationPanel.Location = new System.Drawing.Point(3, 3);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(258, 457);
            this.informationPanel.TabIndex = 0;
            // 
            // inputInformation
            // 
            this.inputInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputInformation.Location = new System.Drawing.Point(0, 0);
            this.inputInformation.Name = "inputInformation";
            this.inputInformation.Size = new System.Drawing.Size(258, 236);
            this.inputInformation.TabIndex = 0;
            // 
            // addTimetableButton
            // 
            this.addTimetableButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addTimetableButton.Location = new System.Drawing.Point(3, 434);
            this.addTimetableButton.Name = "addTimetableButton";
            this.addTimetableButton.Size = new System.Drawing.Size(105, 23);
            this.addTimetableButton.TabIndex = 15;
            this.addTimetableButton.Text = "Add timetable";
            this.mainToolTip.SetToolTip(this.addTimetableButton, "Add a timetable for the student");
            this.addTimetableButton.UseVisualStyleBackColor = true;
            this.addTimetableButton.Click += new System.EventHandler(this.addTimetableButton_Click);
            // 
            // healthCertificateNumUpDown
            // 
            this.healthCertificateNumUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthCertificateNumUpDown.Location = new System.Drawing.Point(154, 378);
            this.healthCertificateNumUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.healthCertificateNumUpDown.Name = "healthCertificateNumUpDown";
            this.healthCertificateNumUpDown.Size = new System.Drawing.Size(89, 23);
            this.healthCertificateNumUpDown.TabIndex = 13;
            // 
            // motherPhoneNumLabel
            // 
            this.motherPhoneNumLabel.AutoSize = true;
            this.motherPhoneNumLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherPhoneNumLabel.Location = new System.Drawing.Point(3, 268);
            this.motherPhoneNumLabel.Name = "motherPhoneNumLabel";
            this.motherPhoneNumLabel.Size = new System.Drawing.Size(131, 15);
            this.motherPhoneNumLabel.TabIndex = 2;
            this.motherPhoneNumLabel.Text = "Mother phone number:";
            // 
            // studentLevelLabel
            // 
            this.studentLevelLabel.AutoSize = true;
            this.studentLevelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLevelLabel.Location = new System.Drawing.Point(3, 410);
            this.studentLevelLabel.Name = "studentLevelLabel";
            this.studentLevelLabel.Size = new System.Drawing.Size(81, 15);
            this.studentLevelLabel.TabIndex = 7;
            this.studentLevelLabel.Text = "Student Level:";
            // 
            // staNumUpDown
            // 
            this.staNumUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staNumUpDown.Location = new System.Drawing.Point(140, 349);
            this.staNumUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.staNumUpDown.Name = "staNumUpDown";
            this.staNumUpDown.Size = new System.Drawing.Size(103, 23);
            this.staNumUpDown.TabIndex = 12;
            // 
            // studentLevelCbox
            // 
            this.studentLevelCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentLevelCbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLevelCbox.FormattingEnabled = true;
            this.studentLevelCbox.Items.AddRange(new object[] {
            "New student",
            "Half ball",
            "One ball",
            "Two balls",
            "One racquet",
            "One racquet, one ball",
            "One racquet, two balls",
            "Two racquets",
            "Two racquets, one ball",
            "Two racquets, two balls",
            "One star",
            "Two stars",
            "Three stars",
            "Four stars",
            "Five stars"});
            this.studentLevelCbox.Location = new System.Drawing.Point(90, 407);
            this.studentLevelCbox.Name = "studentLevelCbox";
            this.studentLevelCbox.Size = new System.Drawing.Size(153, 23);
            this.studentLevelCbox.TabIndex = 14;
            // 
            // motherNameTbox
            // 
            this.motherNameTbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherNameTbox.Location = new System.Drawing.Point(140, 320);
            this.motherNameTbox.MaxLength = 50;
            this.motherNameTbox.Name = "motherNameTbox";
            this.motherNameTbox.Size = new System.Drawing.Size(103, 23);
            this.motherNameTbox.TabIndex = 11;
            // 
            // fatherPhoneNumLabel
            // 
            this.fatherPhoneNumLabel.AutoSize = true;
            this.fatherPhoneNumLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatherPhoneNumLabel.Location = new System.Drawing.Point(3, 239);
            this.fatherPhoneNumLabel.Name = "fatherPhoneNumLabel";
            this.fatherPhoneNumLabel.Size = new System.Drawing.Size(125, 15);
            this.fatherPhoneNumLabel.TabIndex = 1;
            this.fatherPhoneNumLabel.Text = "Father phone number:";
            // 
            // fatherNameTbox
            // 
            this.fatherNameTbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatherNameTbox.Location = new System.Drawing.Point(140, 293);
            this.fatherNameTbox.MaxLength = 50;
            this.fatherNameTbox.Name = "fatherNameTbox";
            this.fatherNameTbox.Size = new System.Drawing.Size(103, 23);
            this.fatherNameTbox.TabIndex = 10;
            // 
            // motherPhoneNumUpDown
            // 
            this.motherPhoneNumUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherPhoneNumUpDown.Location = new System.Drawing.Point(140, 266);
            this.motherPhoneNumUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.motherPhoneNumUpDown.Name = "motherPhoneNumUpDown";
            this.motherPhoneNumUpDown.Size = new System.Drawing.Size(103, 23);
            this.motherPhoneNumUpDown.TabIndex = 9;
            // 
            // staNumLabel
            // 
            this.staNumLabel.AutoSize = true;
            this.staNumLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staNumLabel.Location = new System.Drawing.Point(3, 351);
            this.staNumLabel.Name = "staNumLabel";
            this.staNumLabel.Size = new System.Drawing.Size(85, 15);
            this.staNumLabel.TabIndex = 5;
            this.staNumLabel.Text = "S.T.A. number:";
            this.mainToolTip.SetToolTip(this.staNumLabel, "Student Tennis Association number");
            // 
            // fatherPhoneNumUpDown
            // 
            this.fatherPhoneNumUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatherPhoneNumUpDown.Location = new System.Drawing.Point(140, 237);
            this.fatherPhoneNumUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.fatherPhoneNumUpDown.Name = "fatherPhoneNumUpDown";
            this.fatherPhoneNumUpDown.Size = new System.Drawing.Size(103, 23);
            this.fatherPhoneNumUpDown.TabIndex = 8;
            // 
            // healthCertificateNumLabel
            // 
            this.healthCertificateNumLabel.AutoSize = true;
            this.healthCertificateNumLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthCertificateNumLabel.Location = new System.Drawing.Point(3, 380);
            this.healthCertificateNumLabel.Name = "healthCertificateNumLabel";
            this.healthCertificateNumLabel.Size = new System.Drawing.Size(145, 15);
            this.healthCertificateNumLabel.TabIndex = 6;
            this.healthCertificateNumLabel.Text = "Health certificate number:";
            // 
            // fatherNameLabel
            // 
            this.fatherNameLabel.AutoSize = true;
            this.fatherNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatherNameLabel.Location = new System.Drawing.Point(3, 296);
            this.fatherNameLabel.Name = "fatherNameLabel";
            this.fatherNameLabel.Size = new System.Drawing.Size(76, 15);
            this.fatherNameLabel.TabIndex = 3;
            this.fatherNameLabel.Text = "Father name:";
            // 
            // motherNameLabel
            // 
            this.motherNameLabel.AutoSize = true;
            this.motherNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherNameLabel.Location = new System.Drawing.Point(3, 323);
            this.motherNameLabel.Name = "motherNameLabel";
            this.motherNameLabel.Size = new System.Drawing.Size(82, 15);
            this.motherNameLabel.TabIndex = 4;
            this.motherNameLabel.Text = "Mother name:";
            // 
            // lessonsListBox
            // 
            this.lessonsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lessonsListBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lessonsListBox.FormattingEnabled = true;
            this.lessonsListBox.ItemHeight = 15;
            this.lessonsListBox.Location = new System.Drawing.Point(3, 466);
            this.lessonsListBox.Name = "lessonsListBox";
            this.lessonsListBox.Size = new System.Drawing.Size(258, 95);
            this.lessonsListBox.TabIndex = 1;
            this.lessonsListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lessonsListBox_MouseUp);
            // 
            // searchPicture
            // 
            this.searchPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPicture.Location = new System.Drawing.Point(267, 3);
            this.searchPicture.Name = "searchPicture";
            this.searchPicture.Size = new System.Drawing.Size(378, 457);
            this.searchPicture.TabIndex = 3;
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
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 564);
            this.Controls.Add(this.mainTLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(664, 603);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student";
            this.mainTLayoutPanel.ResumeLayout(false);
            this.bottomRightTableLayoutPanel.ResumeLayout(false);
            this.informationPanel.ResumeLayout(false);
            this.informationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthCertificateNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherPhoneNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatherPhoneNumUpDown)).EndInit();
            this.lessonContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel bottomRightTableLayoutPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addTimetableButton;
        private System.Windows.Forms.ComboBox studentLevelCbox;
        private System.Windows.Forms.Label studentLevelLabel;
        private System.Windows.Forms.NumericUpDown fatherPhoneNumUpDown;
        private System.Windows.Forms.NumericUpDown motherPhoneNumUpDown;
        private System.Windows.Forms.Label fatherPhoneNumLabel;
        private System.Windows.Forms.Label motherPhoneNumLabel;
        private System.Windows.Forms.NumericUpDown healthCertificateNumUpDown;
        private System.Windows.Forms.NumericUpDown staNumUpDown;
        private System.Windows.Forms.TextBox motherNameTbox;
        private System.Windows.Forms.TextBox fatherNameTbox;
        private System.Windows.Forms.Label staNumLabel;
        private System.Windows.Forms.Label healthCertificateNumLabel;
        private System.Windows.Forms.Label motherNameLabel;
        private System.Windows.Forms.Label fatherNameLabel;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Panel informationPanel;
        private InputInformation inputInformation;
        private System.Windows.Forms.ListBox lessonsListBox;
        private System.Windows.Forms.ContextMenuStrip lessonContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private PictureInput searchPicture;
    }
}
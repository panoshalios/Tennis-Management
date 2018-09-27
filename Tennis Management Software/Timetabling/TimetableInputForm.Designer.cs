namespace Tennis_Management_Software.Timetabling
{
    partial class TimetableInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimetableInputForm));
            this.toTimeLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.dayCbox = new System.Windows.Forms.ComboBox();
            this.fromTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tennisCourtNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.studentsInLessonLabel = new System.Windows.Forms.Label();
            this.nameSurnameTbox = new System.Windows.Forms.TextBox();
            this.studentBrowseButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.removeCMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coachNameSurnameTbox = new System.Windows.Forms.TextBox();
            this.coachBrowseButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.coachNameSurnameLabel = new System.Windows.Forms.Label();
            this.fromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.coachPanel = new System.Windows.Forms.Panel();
            this.groupLessonRButton = new System.Windows.Forms.RadioButton();
            this.privateLessonRButton = new System.Windows.Forms.RadioButton();
            this.semiPrivateLessonRButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tennisCourtNumUpDown)).BeginInit();
            this.removeCMenuStrip.SuspendLayout();
            this.studentPanel.SuspendLayout();
            this.coachPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toTimeLabel
            // 
            this.toTimeLabel.AutoSize = true;
            this.toTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTimeLabel.Location = new System.Drawing.Point(12, 65);
            this.toTimeLabel.Name = "toTimeLabel";
            this.toTimeLabel.Size = new System.Drawing.Size(51, 15);
            this.toTimeLabel.TabIndex = 2;
            this.toTimeLabel.Text = "To time:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(12, 9);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(30, 15);
            this.dayLabel.TabIndex = 0;
            this.dayLabel.Text = "Day:";
            // 
            // dayCbox
            // 
            this.dayCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayCbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayCbox.FormattingEnabled = true;
            this.dayCbox.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.dayCbox.Location = new System.Drawing.Point(47, 6);
            this.dayCbox.Name = "dayCbox";
            this.dayCbox.Size = new System.Drawing.Size(121, 23);
            this.dayCbox.TabIndex = 4;
            // 
            // fromTimeLabel
            // 
            this.fromTimeLabel.AutoSize = true;
            this.fromTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTimeLabel.Location = new System.Drawing.Point(12, 39);
            this.fromTimeLabel.Name = "fromTimeLabel";
            this.fromTimeLabel.Size = new System.Drawing.Size(65, 15);
            this.fromTimeLabel.TabIndex = 1;
            this.fromTimeLabel.Text = "From time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tennis court number:";
            // 
            // tennisCourtNumUpDown
            // 
            this.tennisCourtNumUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tennisCourtNumUpDown.Location = new System.Drawing.Point(139, 89);
            this.tennisCourtNumUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.tennisCourtNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tennisCourtNumUpDown.Name = "tennisCourtNumUpDown";
            this.tennisCourtNumUpDown.Size = new System.Drawing.Size(120, 23);
            this.tennisCourtNumUpDown.TabIndex = 7;
            this.tennisCourtNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // studentsInLessonLabel
            // 
            this.studentsInLessonLabel.AutoSize = true;
            this.studentsInLessonLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsInLessonLabel.Location = new System.Drawing.Point(3, 5);
            this.studentsInLessonLabel.Name = "studentsInLessonLabel";
            this.studentsInLessonLabel.Size = new System.Drawing.Size(172, 15);
            this.studentsInLessonLabel.TabIndex = 1;
            this.studentsInLessonLabel.Text = "Other students in group lesson:";
            // 
            // nameSurnameTbox
            // 
            this.nameSurnameTbox.Location = new System.Drawing.Point(181, 3);
            this.nameSurnameTbox.MaxLength = 40;
            this.nameSurnameTbox.Name = "nameSurnameTbox";
            this.nameSurnameTbox.Size = new System.Drawing.Size(97, 23);
            this.nameSurnameTbox.TabIndex = 2;
            // 
            // studentBrowseButton
            // 
            this.studentBrowseButton.Location = new System.Drawing.Point(284, 3);
            this.studentBrowseButton.Name = "studentBrowseButton";
            this.studentBrowseButton.Size = new System.Drawing.Size(60, 21);
            this.studentBrowseButton.TabIndex = 3;
            this.studentBrowseButton.Text = "Browse...";
            this.studentBrowseButton.UseVisualStyleBackColor = true;
            this.studentBrowseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(350, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(60, 21);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 15;
            this.studentListBox.Location = new System.Drawing.Point(6, 29);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(404, 79);
            this.studentListBox.TabIndex = 0;
            this.studentListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.studentListBox_MouseUp);
            // 
            // removeCMenuStrip
            // 
            this.removeCMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.removeCMenuStrip.Name = "removeCMenuStrip";
            this.removeCMenuStrip.Size = new System.Drawing.Size(193, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.deleteToolStripMenuItem.Text = "Delete selected person";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // coachNameSurnameTbox
            // 
            this.coachNameSurnameTbox.Location = new System.Drawing.Point(158, 3);
            this.coachNameSurnameTbox.MaxLength = 40;
            this.coachNameSurnameTbox.Name = "coachNameSurnameTbox";
            this.coachNameSurnameTbox.Size = new System.Drawing.Size(120, 23);
            this.coachNameSurnameTbox.TabIndex = 1;
            // 
            // coachBrowseButton
            // 
            this.coachBrowseButton.Location = new System.Drawing.Point(284, 3);
            this.coachBrowseButton.Name = "coachBrowseButton";
            this.coachBrowseButton.Size = new System.Drawing.Size(60, 21);
            this.coachBrowseButton.TabIndex = 2;
            this.coachBrowseButton.Text = "Browse...";
            this.coachBrowseButton.UseVisualStyleBackColor = true;
            this.coachBrowseButton.Click += new System.EventHandler(this.coachBrowseButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("okButton.BackgroundImage")));
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Location = new System.Drawing.Point(234, 278);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(93, 41);
            this.okButton.TabIndex = 11;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(333, 278);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 41);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // coachNameSurnameLabel
            // 
            this.coachNameSurnameLabel.AutoSize = true;
            this.coachNameSurnameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coachNameSurnameLabel.Location = new System.Drawing.Point(3, 5);
            this.coachNameSurnameLabel.Name = "coachNameSurnameLabel";
            this.coachNameSurnameLabel.Size = new System.Drawing.Size(149, 15);
            this.coachNameSurnameLabel.TabIndex = 0;
            this.coachNameSurnameLabel.Text = "Coach name and surname:";
            // 
            // fromTimePicker
            // 
            this.fromTimePicker.CustomFormat = "HH:mm";
            this.fromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromTimePicker.Location = new System.Drawing.Point(83, 35);
            this.fromTimePicker.Name = "fromTimePicker";
            this.fromTimePicker.ShowUpDown = true;
            this.fromTimePicker.Size = new System.Drawing.Size(85, 20);
            this.fromTimePicker.TabIndex = 5;
            // 
            // toTimePicker
            // 
            this.toTimePicker.CustomFormat = "HH:mm";
            this.toTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toTimePicker.Location = new System.Drawing.Point(83, 61);
            this.toTimePicker.Name = "toTimePicker";
            this.toTimePicker.ShowUpDown = true;
            this.toTimePicker.Size = new System.Drawing.Size(85, 20);
            this.toTimePicker.TabIndex = 6;
            // 
            // studentPanel
            // 
            this.studentPanel.Controls.Add(this.studentsInLessonLabel);
            this.studentPanel.Controls.Add(this.studentListBox);
            this.studentPanel.Controls.Add(this.addButton);
            this.studentPanel.Controls.Add(this.studentBrowseButton);
            this.studentPanel.Controls.Add(this.nameSurnameTbox);
            this.studentPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studentPanel.Location = new System.Drawing.Point(11, 134);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(414, 111);
            this.studentPanel.TabIndex = 17;
            // 
            // coachPanel
            // 
            this.coachPanel.Controls.Add(this.coachNameSurnameLabel);
            this.coachPanel.Controls.Add(this.coachNameSurnameTbox);
            this.coachPanel.Controls.Add(this.coachBrowseButton);
            this.coachPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.coachPanel.Location = new System.Drawing.Point(15, 248);
            this.coachPanel.Name = "coachPanel";
            this.coachPanel.Size = new System.Drawing.Size(348, 30);
            this.coachPanel.TabIndex = 18;
            // 
            // groupLessonRButton
            // 
            this.groupLessonRButton.AutoSize = true;
            this.groupLessonRButton.Checked = true;
            this.groupLessonRButton.Location = new System.Drawing.Point(11, 119);
            this.groupLessonRButton.Name = "groupLessonRButton";
            this.groupLessonRButton.Size = new System.Drawing.Size(87, 17);
            this.groupLessonRButton.TabIndex = 8;
            this.groupLessonRButton.TabStop = true;
            this.groupLessonRButton.Text = "Group lesson";
            this.groupLessonRButton.UseVisualStyleBackColor = true;
            // 
            // privateLessonRButton
            // 
            this.privateLessonRButton.AutoSize = true;
            this.privateLessonRButton.Location = new System.Drawing.Point(104, 118);
            this.privateLessonRButton.Name = "privateLessonRButton";
            this.privateLessonRButton.Size = new System.Drawing.Size(91, 17);
            this.privateLessonRButton.TabIndex = 9;
            this.privateLessonRButton.TabStop = true;
            this.privateLessonRButton.Text = "Private lesson";
            this.privateLessonRButton.UseVisualStyleBackColor = true;
            // 
            // semiPrivateLessonRButton
            // 
            this.semiPrivateLessonRButton.AutoSize = true;
            this.semiPrivateLessonRButton.Location = new System.Drawing.Point(193, 119);
            this.semiPrivateLessonRButton.Name = "semiPrivateLessonRButton";
            this.semiPrivateLessonRButton.Size = new System.Drawing.Size(121, 17);
            this.semiPrivateLessonRButton.TabIndex = 10;
            this.semiPrivateLessonRButton.TabStop = true;
            this.semiPrivateLessonRButton.Text = "Semi-Private Lesson";
            this.semiPrivateLessonRButton.UseVisualStyleBackColor = true;
            // 
            // TimetableInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 325);
            this.Controls.Add(this.semiPrivateLessonRButton);
            this.Controls.Add(this.privateLessonRButton);
            this.Controls.Add(this.groupLessonRButton);
            this.Controls.Add(this.coachPanel);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.toTimePicker);
            this.Controls.Add(this.fromTimePicker);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.fromTimeLabel);
            this.Controls.Add(this.dayCbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toTimeLabel);
            this.Controls.Add(this.tennisCourtNumUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TimetableInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Timetable";
            ((System.ComponentModel.ISupportInitialize)(this.tennisCourtNumUpDown)).EndInit();
            this.removeCMenuStrip.ResumeLayout(false);
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            this.coachPanel.ResumeLayout(false);
            this.coachPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.ComboBox dayCbox;
        private System.Windows.Forms.Label toTimeLabel;
        private System.Windows.Forms.Label fromTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tennisCourtNumUpDown;
        private System.Windows.Forms.Label studentsInLessonLabel;
        private System.Windows.Forms.TextBox nameSurnameTbox;
        private System.Windows.Forms.Button studentBrowseButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Label coachNameSurnameLabel;
        private System.Windows.Forms.TextBox coachNameSurnameTbox;
        private System.Windows.Forms.Button coachBrowseButton;
        private System.Windows.Forms.DateTimePicker fromTimePicker;
        private System.Windows.Forms.DateTimePicker toTimePicker;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.Panel coachPanel;
        private System.Windows.Forms.ContextMenuStrip removeCMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.RadioButton groupLessonRButton;
        private System.Windows.Forms.RadioButton privateLessonRButton;
        private System.Windows.Forms.RadioButton semiPrivateLessonRButton;






    }
}
namespace Tennis_Management_Software
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tournamentButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchTBOX = new System.Windows.Forms.TextBox();
            this.studentCoachCBOX = new System.Windows.Forms.ComboBox();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.statInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.statiInfoPanel = new System.Windows.Forms.Panel();
            this.statInfoLabel = new System.Windows.Forms.Label();
            this.personInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.personPictureBox = new System.Windows.Forms.PictureBox();
            this.InformationPanel = new System.Windows.Forms.Panel();
            this.informationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.personTimetableButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.studentCoachCMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.coachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.statInfoGroupBox.SuspendLayout();
            this.statiInfoPanel.SuspendLayout();
            this.personInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).BeginInit();
            this.InformationPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.studentCoachCMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.60591F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.39409F));
            this.mainLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.mainDataGridView, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 2;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.556437F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.44356F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(812, 708);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.aboutButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tournamentButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // aboutButton
            // 
            this.aboutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutButton.BackgroundImage")));
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Location = new System.Drawing.Point(360, 3);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(114, 55);
            this.aboutButton.TabIndex = 4;
            this.mainToolTip.SetToolTip(this.aboutButton, "About the software.");
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(122, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(113, 55);
            this.settingsButton.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.settingsButton, "Modify the settings.");
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(113, 55);
            this.addButton.TabIndex = 0;
            this.mainToolTip.SetToolTip(this.addButton, "Add a new student or tennis coach.");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tournamentButton
            // 
            this.tournamentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tournamentButton.BackgroundImage")));
            this.tournamentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tournamentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tournamentButton.FlatAppearance.BorderSize = 0;
            this.tournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tournamentButton.Location = new System.Drawing.Point(241, 3);
            this.tournamentButton.Name = "tournamentButton";
            this.tournamentButton.Size = new System.Drawing.Size(113, 55);
            this.tournamentButton.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.tournamentButton, "Tournament creator.");
            this.tournamentButton.UseVisualStyleBackColor = true;
            this.tournamentButton.Click += new System.EventHandler(this.tournamentButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.searchTBOX, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.studentCoachCBOX, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(486, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(323, 61);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // searchTBOX
            // 
            this.searchTBOX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTBOX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTBOX.Location = new System.Drawing.Point(164, 3);
            this.searchTBOX.Name = "searchTBOX";
            this.searchTBOX.Size = new System.Drawing.Size(156, 23);
            this.searchTBOX.TabIndex = 0;
            this.searchTBOX.Text = "Search";
            this.mainToolTip.SetToolTip(this.searchTBOX, "Search for students or tennis coaches.");
            this.searchTBOX.TextChanged += new System.EventHandler(this.searchTBOX_TextChanged);
            // 
            // studentCoachCBOX
            // 
            this.studentCoachCBOX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentCoachCBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentCoachCBOX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentCoachCBOX.FormattingEnabled = true;
            this.studentCoachCBOX.Items.AddRange(new object[] {
            "Students",
            "Coaches"});
            this.studentCoachCBOX.Location = new System.Drawing.Point(3, 3);
            this.studentCoachCBOX.Name = "studentCoachCBOX";
            this.studentCoachCBOX.Size = new System.Drawing.Size(155, 23);
            this.studentCoachCBOX.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.studentCoachCBOX, "Switch to view and search between students or tennis coaches.");
            this.studentCoachCBOX.SelectedIndexChanged += new System.EventHandler(this.studentCoachCBOX_SelectedIndexChanged);
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.surnameColumn,
            this.ageColumn,
            this.genderColumn});
            this.mainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataGridView.Location = new System.Drawing.Point(3, 70);
            this.mainDataGridView.MultiSelect = false;
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDataGridView.Size = new System.Drawing.Size(477, 635);
            this.mainDataGridView.TabIndex = 3;
            this.mainToolTip.SetToolTip(this.mainDataGridView, "Add a new student or tennis coach");
            this.mainDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGridView_CellClick);
            this.mainDataGridView.SizeChanged += new System.EventHandler(this.mainDataGridView_SizeChanged);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 115;
            // 
            // surnameColumn
            // 
            this.surnameColumn.HeaderText = "Surname";
            this.surnameColumn.Name = "surnameColumn";
            this.surnameColumn.ReadOnly = true;
            this.surnameColumn.Width = 115;
            // 
            // ageColumn
            // 
            this.ageColumn.HeaderText = "Age";
            this.ageColumn.Name = "ageColumn";
            this.ageColumn.ReadOnly = true;
            this.ageColumn.Width = 115;
            // 
            // genderColumn
            // 
            this.genderColumn.HeaderText = "Gender";
            this.genderColumn.Name = "genderColumn";
            this.genderColumn.ReadOnly = true;
            this.genderColumn.Width = 115;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.statInfoGroupBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.personInfoGroupBox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(486, 70);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.53543F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.46457F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(323, 635);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // statInfoGroupBox
            // 
            this.statInfoGroupBox.Controls.Add(this.statiInfoPanel);
            this.statInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statInfoGroupBox.Location = new System.Drawing.Point(3, 488);
            this.statInfoGroupBox.Name = "statInfoGroupBox";
            this.statInfoGroupBox.Size = new System.Drawing.Size(317, 144);
            this.statInfoGroupBox.TabIndex = 0;
            this.statInfoGroupBox.TabStop = false;
            this.statInfoGroupBox.Text = "Statistical Information";
            // 
            // statiInfoPanel
            // 
            this.statiInfoPanel.AutoScroll = true;
            this.statiInfoPanel.BackColor = System.Drawing.SystemColors.Control;
            this.statiInfoPanel.Controls.Add(this.statInfoLabel);
            this.statiInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statiInfoPanel.Location = new System.Drawing.Point(3, 19);
            this.statiInfoPanel.Name = "statiInfoPanel";
            this.statiInfoPanel.Size = new System.Drawing.Size(311, 122);
            this.statiInfoPanel.TabIndex = 21;
            // 
            // statInfoLabel
            // 
            this.statInfoLabel.AutoSize = true;
            this.statInfoLabel.Location = new System.Drawing.Point(5, 0);
            this.statInfoLabel.Name = "statInfoLabel";
            this.statInfoLabel.Size = new System.Drawing.Size(70, 15);
            this.statInfoLabel.TabIndex = 2;
            this.statInfoLabel.Text = "Information";
            // 
            // personInfoGroupBox
            // 
            this.personInfoGroupBox.Controls.Add(this.personPictureBox);
            this.personInfoGroupBox.Controls.Add(this.InformationPanel);
            this.personInfoGroupBox.Controls.Add(this.tableLayoutPanel4);
            this.personInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.personInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.personInfoGroupBox.Name = "personInfoGroupBox";
            this.personInfoGroupBox.Size = new System.Drawing.Size(317, 479);
            this.personInfoGroupBox.TabIndex = 1;
            this.personInfoGroupBox.TabStop = false;
            this.personInfoGroupBox.Text = "Person Information";
            // 
            // personPictureBox
            // 
            this.personPictureBox.BackgroundImage = global::Tennis_Management_Software.Properties.Resources.NoImage;
            this.personPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.personPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personPictureBox.Location = new System.Drawing.Point(3, 19);
            this.personPictureBox.Name = "personPictureBox";
            this.personPictureBox.Size = new System.Drawing.Size(311, 129);
            this.personPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personPictureBox.TabIndex = 21;
            this.personPictureBox.TabStop = false;
            // 
            // InformationPanel
            // 
            this.InformationPanel.AutoScroll = true;
            this.InformationPanel.BackColor = System.Drawing.SystemColors.Control;
            this.InformationPanel.Controls.Add(this.informationLabel);
            this.InformationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InformationPanel.Location = new System.Drawing.Point(3, 148);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(311, 271);
            this.InformationPanel.TabIndex = 20;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(5, 3);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(70, 15);
            this.informationLabel.TabIndex = 1;
            this.informationLabel.Text = "Information";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.personTimetableButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.deleteButton, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.editButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.saveButton, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.printButton, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 419);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(311, 57);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // personTimetableButton
            // 
            this.personTimetableButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personTimetableButton.BackgroundImage")));
            this.personTimetableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.personTimetableButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personTimetableButton.FlatAppearance.BorderSize = 0;
            this.personTimetableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personTimetableButton.Location = new System.Drawing.Point(3, 3);
            this.personTimetableButton.Name = "personTimetableButton";
            this.personTimetableButton.Size = new System.Drawing.Size(56, 51);
            this.personTimetableButton.TabIndex = 11;
            this.mainToolTip.SetToolTip(this.personTimetableButton, "Display the selected person\'s timetable.");
            this.personTimetableButton.UseVisualStyleBackColor = true;
            this.personTimetableButton.Click += new System.EventHandler(this.personTimetableButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(127, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(56, 51);
            this.deleteButton.TabIndex = 9;
            this.mainToolTip.SetToolTip(this.deleteButton, "Delete the selected person.");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(65, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(56, 51);
            this.editButton.TabIndex = 10;
            this.mainToolTip.SetToolTip(this.editButton, "Edit the selected person\'s information.");
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(189, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(56, 51);
            this.saveButton.TabIndex = 12;
            this.mainToolTip.SetToolTip(this.saveButton, "Save the selected person\'s information.");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printButton.BackgroundImage")));
            this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.printButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Location = new System.Drawing.Point(251, 3);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(57, 51);
            this.printButton.TabIndex = 13;
            this.mainToolTip.SetToolTip(this.printButton, "Print the selected person\'s information.");
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // studentCoachCMenuStrip
            // 
            this.studentCoachCMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.toolStripSeparator1,
            this.coachToolStripMenuItem});
            this.studentCoachCMenuStrip.Name = "studentCoachCMenuStrip";
            this.studentCoachCMenuStrip.Size = new System.Drawing.Size(116, 54);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
            // 
            // coachToolStripMenuItem
            // 
            this.coachToolStripMenuItem.Name = "coachToolStripMenuItem";
            this.coachToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.coachToolStripMenuItem.Text = "Coach";
            this.coachToolStripMenuItem.Click += new System.EventHandler(this.coachToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 708);
            this.Controls.Add(this.mainLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(828, 747);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tennis Management Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.statInfoGroupBox.ResumeLayout(false);
            this.statiInfoPanel.ResumeLayout(false);
            this.statiInfoPanel.PerformLayout();
            this.personInfoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).EndInit();
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.studentCoachCMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.TextBox searchTBOX;
        private System.Windows.Forms.ComboBox studentCoachCBOX;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox statInfoGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderColumn;
        private System.Windows.Forms.ContextMenuStrip studentCoachCMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem coachToolStripMenuItem;
        private System.Windows.Forms.GroupBox personInfoGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button personTimetableButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.PictureBox personPictureBox;
        private System.Windows.Forms.Panel InformationPanel;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Panel statiInfoPanel;
        private System.Windows.Forms.Label statInfoLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button tournamentButton;
    }
}


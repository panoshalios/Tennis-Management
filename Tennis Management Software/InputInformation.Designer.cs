namespace Tennis_Management_Software
{
    partial class InputInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.phoneNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.surnameTbox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.homeAddressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.emailTbox = new System.Windows.Forms.TextBox();
            this.homeAddressTbox = new System.Windows.Forms.TextBox();
            this.homePhoneLabel = new System.Windows.Forms.Label();
            this.homePhoneNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePhoneNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneNumericUpDown
            // 
            this.phoneNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumericUpDown.Location = new System.Drawing.Point(96, 90);
            this.phoneNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.phoneNumericUpDown.Name = "phoneNumericUpDown";
            this.phoneNumericUpDown.Size = new System.Drawing.Size(122, 23);
            this.phoneNumericUpDown.TabIndex = 10;
            this.mainToolTip.SetToolTip(this.phoneNumericUpDown, "Enter the phone number of the person (leave \"0\" if no phone number is available)");
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(-4, 92);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(89, 15);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Phone number:";
            // 
            // surnameTbox
            // 
            this.surnameTbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTbox.Location = new System.Drawing.Point(96, 32);
            this.surnameTbox.MaxLength = 15;
            this.surnameTbox.Name = "surnameTbox";
            this.surnameTbox.Size = new System.Drawing.Size(122, 23);
            this.surnameTbox.TabIndex = 8;
            this.mainToolTip.SetToolTip(this.surnameTbox, "Type the surname of the person");
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLabel.Location = new System.Drawing.Point(-3, 37);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(57, 15);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Surname:";
            // 
            // nameTbox
            // 
            this.nameTbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTbox.Location = new System.Drawing.Point(96, 3);
            this.nameTbox.MaxLength = 15;
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(122, 23);
            this.nameTbox.TabIndex = 7;
            this.mainToolTip.SetToolTip(this.nameTbox, "Type the name of the person");
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(-4, 67);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(76, 15);
            this.dobLabel.TabIndex = 2;
            this.dobLabel.Text = "Date of birth:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(96, 61);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(122, 23);
            this.dateTimePicker.TabIndex = 9;
            this.mainToolTip.SetToolTip(this.dateTimePicker, "Select the date of birth of the person");
            // 
            // homeAddressLabel
            // 
            this.homeAddressLabel.AutoSize = true;
            this.homeAddressLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeAddressLabel.Location = new System.Drawing.Point(-4, 150);
            this.homeAddressLabel.Name = "homeAddressLabel";
            this.homeAddressLabel.Size = new System.Drawing.Size(88, 15);
            this.homeAddressLabel.TabIndex = 5;
            this.homeAddressLabel.Text = "Home Address:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(-3, 179);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 15);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "E-mail:";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioButton.Location = new System.Drawing.Point(8, 210);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(51, 19);
            this.maleRadioButton.TabIndex = 14;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.Location = new System.Drawing.Point(65, 210);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(63, 19);
            this.femaleRadioButton.TabIndex = 15;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // emailTbox
            // 
            this.emailTbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTbox.Location = new System.Drawing.Point(96, 176);
            this.emailTbox.MaxLength = 50;
            this.emailTbox.Name = "emailTbox";
            this.emailTbox.Size = new System.Drawing.Size(122, 23);
            this.emailTbox.TabIndex = 13;
            this.mainToolTip.SetToolTip(this.emailTbox, "Enter the e-mail of the person");
            // 
            // homeAddressTbox
            // 
            this.homeAddressTbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeAddressTbox.Location = new System.Drawing.Point(96, 147);
            this.homeAddressTbox.MaxLength = 50;
            this.homeAddressTbox.Name = "homeAddressTbox";
            this.homeAddressTbox.Size = new System.Drawing.Size(122, 23);
            this.homeAddressTbox.TabIndex = 12;
            this.mainToolTip.SetToolTip(this.homeAddressTbox, "Type the home address of the person");
            // 
            // homePhoneLabel
            // 
            this.homePhoneLabel.AutoSize = true;
            this.homePhoneLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePhoneLabel.Location = new System.Drawing.Point(-3, 121);
            this.homePhoneLabel.Name = "homePhoneLabel";
            this.homePhoneLabel.Size = new System.Drawing.Size(80, 15);
            this.homePhoneLabel.TabIndex = 4;
            this.homePhoneLabel.Text = "Home phone:";
            // 
            // homePhoneNumericUpDown
            // 
            this.homePhoneNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePhoneNumericUpDown.Location = new System.Drawing.Point(96, 119);
            this.homePhoneNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.homePhoneNumericUpDown.Name = "homePhoneNumericUpDown";
            this.homePhoneNumericUpDown.Size = new System.Drawing.Size(122, 23);
            this.homePhoneNumericUpDown.TabIndex = 11;
            this.mainToolTip.SetToolTip(this.homePhoneNumericUpDown, "Enter the home phone  number of the person");
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(-3, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // InputInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.phoneNumericUpDown);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.surnameTbox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.homeAddressLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.emailTbox);
            this.Controls.Add(this.homeAddressTbox);
            this.Controls.Add(this.homePhoneLabel);
            this.Controls.Add(this.homePhoneNumericUpDown);
            this.Controls.Add(this.nameLabel);
            this.Name = "InputInformation";
            this.Size = new System.Drawing.Size(228, 239);
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePhoneNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown phoneNumericUpDown;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox surnameTbox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label homeAddressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.TextBox emailTbox;
        private System.Windows.Forms.TextBox homeAddressTbox;
        private System.Windows.Forms.Label homePhoneLabel;
        private System.Windows.Forms.NumericUpDown homePhoneNumericUpDown;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ToolTip mainToolTip;

    }
}

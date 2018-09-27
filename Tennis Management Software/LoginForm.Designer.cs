namespace Tennis_Management_Software
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usrnameLBL = new System.Windows.Forms.Label();
            this.passwordLBL = new System.Windows.Forms.Label();
            this.usernameTBOX = new System.Windows.Forms.TextBox();
            this.passwordTBOX = new System.Windows.Forms.TextBox();
            this.loginBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usrnameLBL
            // 
            this.usrnameLBL.AutoSize = true;
            this.usrnameLBL.Dock = System.Windows.Forms.DockStyle.Right;
            this.usrnameLBL.Location = new System.Drawing.Point(23, 0);
            this.usrnameLBL.Name = "usrnameLBL";
            this.usrnameLBL.Size = new System.Drawing.Size(58, 31);
            this.usrnameLBL.TabIndex = 0;
            this.usrnameLBL.Text = "Username:";
            // 
            // passwordLBL
            // 
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.Dock = System.Windows.Forms.DockStyle.Right;
            this.passwordLBL.Location = new System.Drawing.Point(25, 31);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Size = new System.Drawing.Size(56, 31);
            this.passwordLBL.TabIndex = 1;
            this.passwordLBL.Text = "Password:";
            // 
            // usernameTBOX
            // 
            this.usernameTBOX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTBOX.Location = new System.Drawing.Point(87, 3);
            this.usernameTBOX.Multiline = true;
            this.usernameTBOX.Name = "usernameTBOX";
            this.usernameTBOX.Size = new System.Drawing.Size(144, 25);
            this.usernameTBOX.TabIndex = 2;
            // 
            // passwordTBOX
            // 
            this.passwordTBOX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTBOX.Location = new System.Drawing.Point(87, 34);
            this.passwordTBOX.Multiline = true;
            this.passwordTBOX.Name = "passwordTBOX";
            this.passwordTBOX.PasswordChar = '*';
            this.passwordTBOX.Size = new System.Drawing.Size(144, 25);
            this.passwordTBOX.TabIndex = 3;
            // 
            // loginBTN
            // 
            this.loginBTN.Location = new System.Drawing.Point(87, 65);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(75, 23);
            this.loginBTN.TabIndex = 4;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.04061F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.95939F));
            this.tableLayoutPanel1.Controls.Add(this.usrnameLBL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.loginBTN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.usernameTBOX, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordTBOX, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordLBL, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 94);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 94);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usrnameLBL;
        private System.Windows.Forms.Label passwordLBL;
        private System.Windows.Forms.TextBox usernameTBOX;
        private System.Windows.Forms.TextBox passwordTBOX;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
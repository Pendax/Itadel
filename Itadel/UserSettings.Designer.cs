namespace Itadel
{
    partial class UserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettings));
            this.Close = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.LblCName = new System.Windows.Forms.Label();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.AutoAccess = new System.Windows.Forms.CheckBox();
            this.DomainAccess = new System.Windows.Forms.CheckBox();
            this.LocalAccess = new System.Windows.Forms.CheckBox();
            this.UserAccess = new System.Windows.Forms.CheckBox();
            this.Menu = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.StartLock = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblCDomain = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.PUser = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Menu.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Close.BackgroundImage = global::Itadel.Properties.Resources.crossout;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Close.Location = new System.Drawing.Point(285, 2);
            this.Close.Margin = new System.Windows.Forms.Padding(2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(19, 18);
            this.Close.TabIndex = 1;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Logo
            // 
            this.Logo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Image = global::Itadel.Properties.Resources.Itadeltop;
            this.Logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(5);
            this.Logo.Name = "Logo";
            this.Logo.Padding = new System.Windows.Forms.Padding(15, 5, 10, 5);
            this.Logo.Size = new System.Drawing.Size(306, 61);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUser.Location = new System.Drawing.Point(5, 13);
            this.lblUser.Margin = new System.Windows.Forms.Padding(5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 18);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Current User:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCName
            // 
            this.LblCName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCName.Font = new System.Drawing.Font("Arial", 12F);
            this.LblCName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LblCName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblCName.Location = new System.Drawing.Point(138, 10);
            this.LblCName.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.LblCName.MaximumSize = new System.Drawing.Size(300, 24);
            this.LblCName.MinimumSize = new System.Drawing.Size(148, 24);
            this.LblCName.Name = "LblCName";
            this.LblCName.Size = new System.Drawing.Size(148, 24);
            this.LblCName.TabIndex = 10;
            this.LblCName.Text = "Username";
            this.LblCName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tooltip
            // 
            this.Tooltip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            // 
            // AutoAccess
            // 
            this.AutoAccess.AutoSize = true;
            this.AutoAccess.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AutoAccess.Location = new System.Drawing.Point(7, 5);
            this.AutoAccess.Margin = new System.Windows.Forms.Padding(25, 5, 0, 5);
            this.AutoAccess.Name = "AutoAccess";
            this.AutoAccess.Size = new System.Drawing.Size(96, 22);
            this.AutoAccess.TabIndex = 13;
            this.AutoAccess.Text = "Auto Start";
            this.Tooltip.SetToolTip(this.AutoAccess, "The application is going to start on windows boot and will need login to allow ac" +
        "cess");
            this.AutoAccess.UseVisualStyleBackColor = true;
            this.AutoAccess.Visible = false;
            // 
            // DomainAccess
            // 
            this.DomainAccess.AutoSize = true;
            this.DomainAccess.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomainAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DomainAccess.Location = new System.Drawing.Point(30, 5);
            this.DomainAccess.Margin = new System.Windows.Forms.Padding(25, 5, 0, 5);
            this.DomainAccess.Name = "DomainAccess";
            this.DomainAccess.Size = new System.Drawing.Size(132, 22);
            this.DomainAccess.TabIndex = 14;
            this.DomainAccess.Text = "Define Domain";
            this.Tooltip.SetToolTip(this.DomainAccess, "User must define domain before being allowed access");
            this.DomainAccess.UseVisualStyleBackColor = true;
            // 
            // LocalAccess
            // 
            this.LocalAccess.AutoSize = true;
            this.LocalAccess.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LocalAccess.Location = new System.Drawing.Point(30, 5);
            this.LocalAccess.Margin = new System.Windows.Forms.Padding(0, 5, 25, 5);
            this.LocalAccess.Name = "LocalAccess";
            this.LocalAccess.Size = new System.Drawing.Size(99, 22);
            this.LocalAccess.TabIndex = 14;
            this.LocalAccess.Text = "Local user";
            this.Tooltip.SetToolTip(this.LocalAccess, "Restricts unlock exclusively to the local user\r\n");
            this.LocalAccess.UseVisualStyleBackColor = true;
            this.LocalAccess.CheckedChanged += new System.EventHandler(this.LocalAccessBtn_Click);
            // 
            // UserAccess
            // 
            this.UserAccess.AutoSize = true;
            this.UserAccess.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.UserAccess.Location = new System.Drawing.Point(169, 5);
            this.UserAccess.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.UserAccess.Name = "UserAccess";
            this.UserAccess.Size = new System.Drawing.Size(112, 22);
            this.UserAccess.TabIndex = 12;
            this.UserAccess.Text = "Current user";
            this.Tooltip.SetToolTip(this.UserAccess, "Restricts unlock exclusively to the active user");
            this.UserAccess.UseVisualStyleBackColor = true;
            this.UserAccess.CheckedChanged += new System.EventHandler(this.UserAccessBtn_Click);
            // 
            // Menu
            // 
            this.Menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Controls.Add(this.panel7);
            this.Menu.Controls.Add(this.panel6);
            this.Menu.Controls.Add(this.panel5);
            this.Menu.Controls.Add(this.panel4);
            this.Menu.Controls.Add(this.panel3);
            this.Menu.Controls.Add(this.panel2);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Controls.Add(this.PUser);
            this.Menu.Controls.Add(this.Close);
            this.Menu.Controls.Add(this.Logo);
            this.Menu.Location = new System.Drawing.Point(1, 1);
            this.Menu.Margin = new System.Windows.Forms.Padding(1);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(306, 253);
            this.Menu.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.Controls.Add(this.AutoAccess);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(162, 171);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(144, 32);
            this.panel7.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DomainAccess);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 171);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(162, 32);
            this.panel6.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.Settings);
            this.panel5.Controls.Add(this.StartLock);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 203);
            this.panel5.MinimumSize = new System.Drawing.Size(0, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 50);
            this.panel5.TabIndex = 20;
            // 
            // StartLock
            // 
            this.StartLock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(92)))), ((int)(((byte)(160)))));
            this.StartLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartLock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLock.ForeColor = System.Drawing.Color.White;
            this.StartLock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartLock.Location = new System.Drawing.Point(226, 10);
            this.StartLock.Margin = new System.Windows.Forms.Padding(10);
            this.StartLock.Name = "StartLock";
            this.StartLock.Size = new System.Drawing.Size(70, 30);
            this.StartLock.TabIndex = 6;
            this.StartLock.Text = "Start";
            this.StartLock.UseVisualStyleBackColor = false;
            this.StartLock.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 0);
            this.panel4.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 0);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.UserAccess);
            this.panel2.Controls.Add(this.LocalAccess);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 32);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.LblCDomain);
            this.panel1.Controls.Add(this.lblDomain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 39);
            this.panel1.TabIndex = 16;
            // 
            // LblCDomain
            // 
            this.LblCDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCDomain.AutoEllipsis = true;
            this.LblCDomain.AutoSize = true;
            this.LblCDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCDomain.Font = new System.Drawing.Font("Arial", 12F);
            this.LblCDomain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LblCDomain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblCDomain.Location = new System.Drawing.Point(138, 7);
            this.LblCDomain.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.LblCDomain.MaximumSize = new System.Drawing.Size(300, 24);
            this.LblCDomain.MinimumSize = new System.Drawing.Size(148, 24);
            this.LblCDomain.Name = "LblCDomain";
            this.LblCDomain.Padding = new System.Windows.Forms.Padding(1, 1, 5, 1);
            this.LblCDomain.Size = new System.Drawing.Size(148, 24);
            this.LblCDomain.TabIndex = 11;
            this.LblCDomain.Text = "Domain name";
            this.LblCDomain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDomain
            // 
            this.lblDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDomain.AutoSize = true;
            this.lblDomain.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDomain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblDomain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDomain.Location = new System.Drawing.Point(5, 9);
            this.lblDomain.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(122, 18);
            this.lblDomain.TabIndex = 8;
            this.lblDomain.Text = "Current Domain:";
            this.lblDomain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PUser
            // 
            this.PUser.AutoSize = true;
            this.PUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PUser.Controls.Add(this.lblUser);
            this.PUser.Controls.Add(this.LblCName);
            this.PUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.PUser.Location = new System.Drawing.Point(0, 61);
            this.PUser.Name = "PUser";
            this.PUser.Size = new System.Drawing.Size(306, 39);
            this.PUser.TabIndex = 15;
            // 
            // Settings
            // 
            this.Settings.AutoSize = true;
            this.Settings.Font = new System.Drawing.Font("Arial", 12F);
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Settings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Settings.Location = new System.Drawing.Point(30, 5);
            this.Settings.Margin = new System.Windows.Forms.Padding(25, 5, 0, 5);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(84, 22);
            this.Settings.TabIndex = 16;
            this.Settings.Text = "Settings";
            this.Tooltip.SetToolTip(this.Settings, "User is able to change settings upon succesfull login");
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(310, 256);
            this.ControlBox = false;
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "UserSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSettings_Close);
            this.Load += new System.EventHandler(this.UserSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PUser.ResumeLayout(false);
            this.PUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label LblCName;
        private System.Windows.Forms.ToolTip Tooltip;
        private new System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Label LblCDomain;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Panel PUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button StartLock;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox AutoAccess;
        private System.Windows.Forms.CheckBox DomainAccess;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox LocalAccess;
        private System.Windows.Forms.CheckBox UserAccess;
        private System.Windows.Forms.CheckBox Settings;
    }
}
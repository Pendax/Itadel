using System;
namespace Itadel
{
    partial class Login
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
        if (ptrHook != IntPtr.Zero)
        {
           NativeMethods.UnhookWindowsHookEx(ptrHook);
           ptrHook = IntPtr.Zero;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Panel();
            this.PButton = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.CheckBox();
            this.PPassword = new System.Windows.Forms.Panel();
            this.lblPwd = new System.Windows.Forms.Label();
            this.PDomain = new System.Windows.Forms.Panel();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.LblDomain = new System.Windows.Forms.Label();
            this.PUser = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.PAccess = new System.Windows.Forms.Panel();
            this.Accessdenied = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Lock = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Menu.SuspendLayout();
            this.PButton.SuspendLayout();
            this.PPassword.SuspendLayout();
            this.PDomain.SuspendLayout();
            this.PUser.SuspendLayout();
            this.PAccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lock)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            resources.ApplyResources(this.txtUser, "txtUser");
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtUser.Name = "txtUser";
            // 
            // txtPwd
            // 
            resources.ApplyResources(this.txtPwd, "txtPwd");
            this.txtPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // Send
            // 
            resources.ApplyResources(this.Send, "Send");
            this.Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(92)))), ((int)(((byte)(160)))));
            this.Send.ForeColor = System.Drawing.Color.White;
            this.Send.Name = "Send";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            this.Send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.Send.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Login_KeyUp);
            // 
            // Menu
            // 
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Menu.Controls.Add(this.PButton);
            this.Menu.Controls.Add(this.PPassword);
            this.Menu.Controls.Add(this.PDomain);
            this.Menu.Controls.Add(this.PUser);
            this.Menu.Controls.Add(this.PAccess);
            this.Menu.Controls.Add(this.Close);
            this.Menu.Controls.Add(this.Logo);
            this.Menu.Name = "Menu";
            // 
            // PButton
            // 
            resources.ApplyResources(this.PButton, "PButton");
            this.PButton.Controls.Add(this.Settings);
            this.PButton.Controls.Add(this.Send);
            this.PButton.Name = "PButton";
            // 
            // Settings
            // 
            resources.ApplyResources(this.Settings, "Settings");
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Settings.Name = "Settings";
            this.toolTip1.SetToolTip(this.Settings, resources.GetString("Settings.ToolTip"));
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // PPassword
            // 
            resources.ApplyResources(this.PPassword, "PPassword");
            this.PPassword.Controls.Add(this.txtPwd);
            this.PPassword.Controls.Add(this.lblPwd);
            this.PPassword.Name = "PPassword";
            // 
            // lblPwd
            // 
            resources.ApplyResources(this.lblPwd, "lblPwd");
            this.lblPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblPwd.Name = "lblPwd";
            // 
            // PDomain
            // 
            resources.ApplyResources(this.PDomain, "PDomain");
            this.PDomain.Controls.Add(this.txtDomain);
            this.PDomain.Controls.Add(this.LblDomain);
            this.PDomain.Name = "PDomain";
            // 
            // txtDomain
            // 
            resources.ApplyResources(this.txtDomain, "txtDomain");
            this.txtDomain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.UseSystemPasswordChar = true;
            // 
            // LblDomain
            // 
            resources.ApplyResources(this.LblDomain, "LblDomain");
            this.LblDomain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LblDomain.Name = "LblDomain";
            // 
            // PUser
            // 
            resources.ApplyResources(this.PUser, "PUser");
            this.PUser.Controls.Add(this.txtUser);
            this.PUser.Controls.Add(this.lblUser);
            this.PUser.Name = "PUser";
            // 
            // lblUser
            // 
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblUser.Name = "lblUser";
            // 
            // PAccess
            // 
            resources.ApplyResources(this.PAccess, "PAccess");
            this.PAccess.Controls.Add(this.Accessdenied);
            this.PAccess.Name = "PAccess";
            // 
            // Accessdenied
            // 
            resources.ApplyResources(this.Accessdenied, "Accessdenied");
            this.Accessdenied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Accessdenied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Accessdenied.ForeColor = System.Drawing.Color.Black;
            this.Accessdenied.Name = "Accessdenied";
            // 
            // Close
            // 
            resources.ApplyResources(this.Close, "Close");
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Close.BackgroundImage = global::Itadel.Properties.Resources.crossout;
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Close.Name = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.Close.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Login_KeyUp);
            // 
            // Logo
            // 
            this.Logo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Image = global::Itadel.Properties.Resources.Itadeltop;
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            // 
            // Lock
            // 
            resources.ApplyResources(this.Lock, "Lock");
            this.Lock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Lock.Image = global::Itadel.Properties.Resources.lockedpadlock;
            this.Lock.Name = "Lock";
            this.Lock.TabStop = false;
            this.Lock.Click += new System.EventHandler(this.Login_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.Send;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.Close;
            this.ControlBox = false;
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Lock);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(102)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Opacity = 0.01D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.Lock_Focusloss);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Click += new System.EventHandler(this.Login_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Login_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.PButton.ResumeLayout(false);
            this.PButton.PerformLayout();
            this.PPassword.ResumeLayout(false);
            this.PPassword.PerformLayout();
            this.PDomain.ResumeLayout(false);
            this.PDomain.PerformLayout();
            this.PUser.ResumeLayout(false);
            this.PUser.PerformLayout();
            this.PAccess.ResumeLayout(false);
            this.PAccess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button Send;
        private new System.Windows.Forms.Panel Menu;
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox Lock;
        private System.Windows.Forms.Label LblDomain;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Panel PButton;
        private System.Windows.Forms.Panel PPassword;
        private System.Windows.Forms.Panel PDomain;
        private System.Windows.Forms.Panel PUser;
        private System.Windows.Forms.Panel PAccess;
        private System.Windows.Forms.Label Accessdenied;
        private System.Windows.Forms.CheckBox Settings;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
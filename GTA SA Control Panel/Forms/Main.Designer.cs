namespace GTASAControlPanel.Forms
{
    partial class Main
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
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMainWindow = new System.Windows.Forms.TabControl();
            this.tabPlayerStats = new System.Windows.Forms.TabPage();
            this.playerStats = new GTASAControlPanel.UserControls.PlayerStats();
            this.v20SteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControlMainWindow.SuspendLayout();
            this.tabPlayerStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 17);
            this.lblStatus.Text = "Initialising...";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(790, 41);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh data from GTA:SA";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.gitHubToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v10ToolStripMenuItem,
            this.v11ToolStripMenuItem,
            this.v20SteamToolStripMenuItem});
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // v10ToolStripMenuItem
            // 
            this.v10ToolStripMenuItem.Name = "v10ToolStripMenuItem";
            this.v10ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.v10ToolStripMenuItem.Text = "v1.0";
            this.v10ToolStripMenuItem.Click += new System.EventHandler(this.v10ToolStripMenuItem_Click);
            // 
            // v11ToolStripMenuItem
            // 
            this.v11ToolStripMenuItem.Name = "v11ToolStripMenuItem";
            this.v11ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.v11ToolStripMenuItem.Text = "v1.1";
            this.v11ToolStripMenuItem.Click += new System.EventHandler(this.v11ToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.bugReportToolStripMenuItem,
            this.featureRequestToolStripMenuItem});
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.projectToolStripMenuItem.Text = "Project";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // bugReportToolStripMenuItem
            // 
            this.bugReportToolStripMenuItem.Name = "bugReportToolStripMenuItem";
            this.bugReportToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.bugReportToolStripMenuItem.Text = "Bug Report";
            this.bugReportToolStripMenuItem.Click += new System.EventHandler(this.bugReportToolStripMenuItem_Click);
            // 
            // featureRequestToolStripMenuItem
            // 
            this.featureRequestToolStripMenuItem.Name = "featureRequestToolStripMenuItem";
            this.featureRequestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.featureRequestToolStripMenuItem.Text = "Feature Request";
            this.featureRequestToolStripMenuItem.Click += new System.EventHandler(this.featureRequestToolStripMenuItem_Click);
            // 
            // tabControlMainWindow
            // 
            this.tabControlMainWindow.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlMainWindow.Controls.Add(this.tabPlayerStats);
            this.tabControlMainWindow.Location = new System.Drawing.Point(12, 74);
            this.tabControlMainWindow.Name = "tabControlMainWindow";
            this.tabControlMainWindow.SelectedIndex = 0;
            this.tabControlMainWindow.Size = new System.Drawing.Size(790, 410);
            this.tabControlMainWindow.TabIndex = 9;
            // 
            // tabPlayerStats
            // 
            this.tabPlayerStats.BackColor = System.Drawing.SystemColors.Control;
            this.tabPlayerStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPlayerStats.Controls.Add(this.playerStats);
            this.tabPlayerStats.Location = new System.Drawing.Point(4, 25);
            this.tabPlayerStats.Name = "tabPlayerStats";
            this.tabPlayerStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayerStats.Size = new System.Drawing.Size(782, 381);
            this.tabPlayerStats.TabIndex = 0;
            this.tabPlayerStats.Text = "Player Stats";
            // 
            // playerStats
            // 
            this.playerStats.Location = new System.Drawing.Point(-1, -1);
            this.playerStats.Name = "playerStats";
            this.playerStats.Size = new System.Drawing.Size(781, 377);
            this.playerStats.TabIndex = 8;
            // 
            // v20SteamToolStripMenuItem
            // 
            this.v20SteamToolStripMenuItem.Name = "v20SteamToolStripMenuItem";
            this.v20SteamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.v20SteamToolStripMenuItem.Text = "v2.0 / Steam";
            this.v20SteamToolStripMenuItem.Click += new System.EventHandler(this.v20SteamToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 509);
            this.Controls.Add(this.tabControlMainWindow);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "GTA SA Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMainWindow.ResumeLayout(false);
            this.tabPlayerStats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private UserControls.PlayerStats playerStats;
        private System.Windows.Forms.TabControl tabControlMainWindow;
        private System.Windows.Forms.TabPage tabPlayerStats;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v20SteamToolStripMenuItem;
    }
}


using GTASAControlPanel.Modules;
using System;
using System.Windows.Forms;

namespace GTASAControlPanel.Forms
{
    /// <summary>Main Form of the user display</summary>
    public partial class Main : Form
    {
        private bool isLoaded = false;

        #region Control Updaters

        private void UpdateControls()
        {
            playerStats.UpdateControls();
        }

        #endregion Control Updaters

        #region Form Actions

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            playerStats.SaveSettings();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            LoadSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();

            updateTimer.Start();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (!Memory.IsConnected)
            {
                try
                {
                    Memory.Initialize();
                    lblStatus.Text = "Connected.";
                }
                catch
                {
                    Utilities.ResetAllControls(this);
                    Utilities.ResetAllControls(playerStats);
                    lblStatus.Text = "Waiting to connect...";
                    isLoaded = false;
                }
            }
            else
            {
                if (!AddressBook.PlayerInGame)
                {
                    Utilities.ResetAllControls(this);
                    Utilities.ResetAllControls(playerStats);
                    lblStatus.Text = "Connected. No Game Loaded";
                }
                else
                {
                    lblStatus.Text = "Connected. Player in Game";
                    if (!isLoaded)
                    {
                        UpdateControls();
                        isLoaded = true;
                    }
                    else
                    {
                        UpdateControls();
                    }
                }
            }
        }

        private void v10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v11ToolStripMenuItem.Checked = false;
            v10ToolStripMenuItem.Checked = true;
            v3SteamToolStripMenuItem.Checked = false;

            Properties.Settings.Default.GTAExeVersion = (int)GTAExeVersion.v1_0;
            Properties.Settings.Default.Save();

            SetMemoryAddresses();
        }

        private void v11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v11ToolStripMenuItem.Checked = true;
            v10ToolStripMenuItem.Checked = false;
            v3SteamToolStripMenuItem.Checked = false;

            Properties.Settings.Default.GTAExeVersion = (int)GTAExeVersion.v1_1;
            Properties.Settings.Default.Save();

            SetMemoryAddresses();
        }

        private void v3SteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v11ToolStripMenuItem.Checked = false;
            v10ToolStripMenuItem.Checked = false;
            v3SteamToolStripMenuItem.Checked = true;

            Properties.Settings.Default.GTAExeVersion = (int)GTAExeVersion.v3_Steam;
            Properties.Settings.Default.Save();

            SetMemoryAddresses();
        }

        #endregion Form Actions

        #region Misc

        private void LoadSettings()
        {
            GTAExeVersion gtaVersion = (GTAExeVersion)Properties.Settings.Default.GTAExeVersion;

            switch (gtaVersion)
            {
                case GTAExeVersion.v1_0:
                    v10ToolStripMenuItem.Checked = true;
                    v11ToolStripMenuItem.Checked = false;
                    v3SteamToolStripMenuItem.Checked = false;
                    break;

                case GTAExeVersion.v1_1:
                    v10ToolStripMenuItem.Checked = false;
                    v11ToolStripMenuItem.Checked = true;
                    v3SteamToolStripMenuItem.Checked = false;
                    break;

                case GTAExeVersion.v3_Steam:
                    v10ToolStripMenuItem.Checked = false;
                    v11ToolStripMenuItem.Checked = false;
                    v3SteamToolStripMenuItem.Checked = true;
                    break;
            }

            SetMemoryAddresses();

            playerStats.LoadSettings();
        }

        private static void SetMemoryAddresses()
        {
            GTAExeVersion gtaVersion = (GTAExeVersion)Properties.Settings.Default.GTAExeVersion;

            switch (gtaVersion)
            {
                case GTAExeVersion.v1_0:
                    Global.Addresses = Addresses.Version1_0;
                    break;

                case GTAExeVersion.v1_1:
                    Global.Addresses = Addresses.Version1_1;
                    break;

                case GTAExeVersion.v3_Steam:
                    Global.Addresses = Addresses.Version3_Steam;
                    break;
            }
        }

        /// <summary>Main form class</summary>
        public Main()
        {
            InitializeComponent();
        }

        #endregion Misc

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.ProjectPage);
        }

        private void bugReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.BugReport);
        }

        private void featureRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.FeatureRequest);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(updateTimer.Enabled)
            {
                updateTimer.Stop();
                connectToolStripMenuItem.Text = "Connect";
                Utilities.ResetAllControls(this);
                Utilities.ResetAllControls(playerStats);
                lblStatus.Text = "Disconnected";
                isLoaded = false;
            }
            else
            {
                updateTimer.Start();
                connectToolStripMenuItem.Text = "Disconnect";
            }
        }
    }
}
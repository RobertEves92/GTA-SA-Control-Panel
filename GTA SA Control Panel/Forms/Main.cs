using GTASAControlPanel.Modules;
using System;
using System.Windows.Forms;

namespace GTASAControlPanel.Forms
{
    /// <summary>
    /// Main Form of the user display
    /// </summary>
    public partial class Main : Form
    {
        private bool isLoaded = false;

        #region Control Updaters
        private void UpdateControls()
        {
            playerStats.UpdateControls();
        }
        #endregion

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
                    Memory.Initialize("gta-sa");
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void v10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v11ToolStripMenuItem.Checked = false;
            v10ToolStripMenuItem.Checked = true;

            Properties.Settings.Default.GTAExeVersion = (int)GTAExeVersion.v10;
            Properties.Settings.Default.Save();

            SetMemoryAddresses();
        }

        private void v11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v11ToolStripMenuItem.Checked = true;
            v10ToolStripMenuItem.Checked = false;

            Properties.Settings.Default.GTAExeVersion = (int)GTAExeVersion.v11;
            Properties.Settings.Default.Save();

            SetMemoryAddresses();
        }
        #endregion

        #region Misc
        private void LoadSettings()
        {
            GTAExeVersion gtaVersion = (GTAExeVersion)Properties.Settings.Default.GTAExeVersion;

            switch (gtaVersion)
            {
                case GTAExeVersion.v10:
                    v10ToolStripMenuItem.Checked = true;
                    v11ToolStripMenuItem.Checked = false;
                    break;
                case GTAExeVersion.v11:
                    v10ToolStripMenuItem.Checked = false;
                    v11ToolStripMenuItem.Checked = true;
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
                case GTAExeVersion.v10:
                    Global.Addresses = Addresses.Version1;
                    break;
                case GTAExeVersion.v11:
                    Global.Addresses = Addresses.Version2;
                    break;
            }
        }

        /// <summary>
        /// Main form class
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        #endregion

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RobertEves92/GTA-SA-Control-Panel");
        }

        private void bugReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RobertEves92/GTA-SA-Control-Panel/issues/new?assignees=&labels=bug&template=bug-report.md&title=%5BBUG%5D");
        }

        private void featureRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RobertEves92/GTA-SA-Control-Panel/issues/new?assignees=&labels=enhancement&template=feature_request.md&title=%5BFEATURE%5D");
        }
    }
}

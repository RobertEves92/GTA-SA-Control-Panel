using GTASAControlPanel.Modules;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTASAControlPanel.UserControls
{
    /// <summary>
    /// Player stats control
    /// </summary>
    public partial class PlayerStats : UserControl
    {
        /// <summary>
        /// Player stats control
        /// </summary>
        public PlayerStats()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the controls eith values from in game
        /// </summary>
        public void UpdateControls()
        {
            UpdateLockedValues();

            if (!txtMoney.Modified) { txtMoney.Text = AddressBook.Player.Money.ToString(); }
            statArmour.ControlCurrentValue = Convert.ToInt32(AddressBook.Player.Armour);
            statHealth.ControlMaxValue = Convert.ToInt32(AddressBook.Player.MaxHealth);
            statHealth.ControlCurrentValue = Convert.ToInt32(AddressBook.Player.CurrentHealth);
            statFat.ControlCurrentValue = Convert.ToInt32(AddressBook.Player.Fat);
            statStamina.ControlCurrentValue = Convert.ToInt32(AddressBook.Player.Stamina);
            statMuscle.ControlCurrentValue = Convert.ToInt32(AddressBook.Player.Muscle);
            statDriving.ControlCurrentValue = Convert.ToInt32(AddressBook.Player.Skills.Transport.Driving);
            statBiking.ControlCurrentValue = Convert.ToInt32(AddressBook.Player.Skills.Transport.Biking);
            statCycle.ControlCurrentValue = Convert.ToInt32(AddressBook.Player.Skills.Transport.Cycling);
            statPlane.ControlCurrentValue = Convert.ToInt32(AddressBook.Player.Skills.Transport.Flying);
            statLung.ControlCurrentValue = Convert.ToInt32(AddressBook.Player.LungCapacity);
            statGambling.ControlCurrentValue = Convert.ToInt32(AddressBook.Player.Skills.Gambling);
        }

        /// <summary>
        /// Commits user settings
        /// </summary>
        public void SaveSettings()
        {
            Properties.Settings.Default.LockHealth = statHealth.ControlLock;
            Properties.Settings.Default.LockArmour = statArmour.ControlLock;
            Properties.Settings.Default.LockFat = statFat.ControlLock;
            Properties.Settings.Default.LockStamina = statStamina.ControlLock;
            Properties.Settings.Default.LockMuscle = statMuscle.ControlLock;
            Properties.Settings.Default.LockDrivingSkill = statDriving.ControlLock;
            Properties.Settings.Default.LockBikingSkill = statBiking.ControlLock;
            Properties.Settings.Default.LockCyclingSkill = statCycle.ControlLock;
            Properties.Settings.Default.LockFlyingSkill = statPlane.ControlLock;
            Properties.Settings.Default.LockLungCapacity = statLung.ControlLock;
            Properties.Settings.Default.LockGamblingSkill = statGambling.ControlLock;

            Properties.Settings.Default.PlayerDamageProtection[0] = chkBullets.Checked.ToString();
            Properties.Settings.Default.PlayerDamageProtection[1] = chkFire.Checked.ToString();
            Properties.Settings.Default.PlayerDamageProtection[2] = chkExplosions.Checked.ToString();
            Properties.Settings.Default.PlayerDamageProtection[3] = chkCollisions.Checked.ToString();

            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// Loads user settings
        /// </summary>
        public void LoadSettings()
        {
            statHealth.ControlLock = Properties.Settings.Default.LockHealth;
            statArmour.ControlLock = Properties.Settings.Default.LockArmour;
            statFat.ControlLock = Properties.Settings.Default.LockFat;
            statStamina.ControlLock = Properties.Settings.Default.LockStamina;
            statMuscle.ControlLock = Properties.Settings.Default.LockMuscle;
            statDriving.ControlLock = Properties.Settings.Default.LockDrivingSkill;
            statBiking.ControlLock = Properties.Settings.Default.LockBikingSkill;
            statCycle.ControlLock = Properties.Settings.Default.LockCyclingSkill;
            statPlane.ControlLock = Properties.Settings.Default.LockFlyingSkill;
            statLung.ControlLock = Properties.Settings.Default.LockLungCapacity;
            statGambling.ControlLock = Properties.Settings.Default.LockGamblingSkill;

            chkBullets.Checked = Convert.ToBoolean(Properties.Settings.Default.PlayerDamageProtection[0]);
            chkFire.Checked = Convert.ToBoolean(Properties.Settings.Default.PlayerDamageProtection[1]);
            chkExplosions.Checked = Convert.ToBoolean(Properties.Settings.Default.PlayerDamageProtection[2]);
            chkCollisions.Checked = Convert.ToBoolean(Properties.Settings.Default.PlayerDamageProtection[3]);
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            if (txtMoney.Focused)
            {
                txtMoney.BackColor = Color.Red;
            }
        }

        private void txtMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int newMoney = int.Parse(txtMoney.Text);
                    AddressBook.Player.Money = newMoney;
                    txtMoney.BackColor = SystemColors.Window;
                    txtMoney.Modified = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void statHealth_TrackValueChanged(object sender, EventArgs e)
        {
            AddressBook.Player.CurrentHealth = statHealth.ControlCurrentValue;
        }

        private void statArmour_TrackValueChanged(object sender, EventArgs e)
        {
            AddressBook.Player.Armour = statArmour.ControlCurrentValue;
        }

        private void statFat_TrackValueChanged(object sender, EventArgs e)
        {
            AddressBook.Player.Fat = statFat.ControlCurrentValue;
        }

        private void statStamina_TrackValueChanged(object sender, EventArgs e)
        {
            AddressBook.Player.Stamina = statStamina.ControlCurrentValue;
        }

        private void statMuscle_TrackValueChanged(object sender, EventArgs e)
        {
            AddressBook.Player.Muscle = statMuscle.ControlCurrentValue;
        }

        private void statDriving_TrackValueChanged(object sender, EventArgs e)
        {
            AddressBook.Player.Skills.Transport.Driving = (uint)statDriving.ControlCurrentValue;
        }

        private void statBiking_TrackValueChanged(object sender, EventArgs e)
        {
            AddressBook.Player.Skills.Transport.Biking = (uint)statBiking.ControlCurrentValue;
        }

        private void statCycle_TrackValueChanged(object sender, EventArgs e)
        {
            AddressBook.Player.Skills.Transport.Cycling = (uint)statCycle.ControlCurrentValue;
        }

        private void statPlane_TrackValueChanged(object sender, EventArgs e)
        {
            AddressBook.Player.Skills.Transport.Flying = (uint)statPlane.ControlCurrentValue;
        }

        private void UpdateLockedValues()
        {
            SetBitOnInteger((int)AddressBook.Player.PlayerAddress + 66, 6, chkCollisions.Checked);
            SetBitOnInteger((int)AddressBook.Player.PlayerAddress + 66, 7, chkExplosions.Checked);
            SetBitOnInteger((int)AddressBook.Player.PlayerAddress + 66, 3, chkFire.Checked);
            SetBitOnInteger((int)AddressBook.Player.PlayerAddress + 66, 2, chkBullets.Checked);

            foreach (Control c in Controls)
            {
                if (c is StatControl)
                {
                    StatControl sc = (StatControl)c;
                    if (sc.ControlLock)
                    {
                        sc.UpdateValue(null);
                    }
                }

            }
        }

        private void statLung_TrackValueChanged(object sender, EventArgs e)
        {
            AddressBook.Player.LungCapacity = (uint)statLung.ControlCurrentValue;
        }

        private void statGambling_TrackValueChanged(object sender, EventArgs e)
        {
            AddressBook.Player.Skills.Gambling = (uint)statGambling.ControlCurrentValue;
        }

        private void btnWeaponSkills_Click(object sender, EventArgs e)
        {
            Forms.WeaponStats weaponStats = new Forms.WeaponStats();
            weaponStats.ShowDialog();
        }

        private void SetBitOnInteger(int iAdr, int iBitOffset, bool isSetON)
        {
            int intBitOPBuffer = Memory.ReadMemory<int>(iAdr);

            if (isSetON)
            {
                intBitOPBuffer = intBitOPBuffer | Convert.ToInt32(Math.Pow(2, iBitOffset));
            }
            else
            {
                intBitOPBuffer = intBitOPBuffer & Convert.ToInt32(255 - (Math.Pow(2, iBitOffset)));
            }

            //Memory.WriteMemory<int>(iAdr, intBitOPBuffer, 2, 2);
            Memory.WriteMemory<int>(iAdr, intBitOPBuffer);
        }
    }
}

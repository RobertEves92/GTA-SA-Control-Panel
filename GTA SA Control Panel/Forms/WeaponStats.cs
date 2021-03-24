using GTASAControlPanel.Modules;
using GTASAControlPanel.UserControls;
using System;
using System.Windows.Forms;

namespace GTASAControlPanel.Forms
{
    public partial class WeaponStats : Form
    {
        /// <summary>
        /// Form to get/set weapon stats
        /// </summary>
        public WeaponStats()
        {
            InitializeComponent();
        }

        private void WeaponStats_Load(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void UpdateValues()
        {
            statPistol.ControlCurrentValue = (int)AddressBook.Player.Skills.Weapons.Pistol;
            statSilencedPistol.ControlCurrentValue = (int)AddressBook.Player.Skills.Weapons.SilencedPistol;
            statDesertEagle.ControlCurrentValue = (int)AddressBook.Player.Skills.Weapons.DesertEagle;
            statShotgun.ControlCurrentValue = (int)AddressBook.Player.Skills.Weapons.Shotgun;
            statSawnoffShotgun.ControlCurrentValue = (int)AddressBook.Player.Skills.Weapons.SawnoffShotgun;
            statCombatShotgun.ControlCurrentValue = (int)AddressBook.Player.Skills.Weapons.CombatShotgun;
            statMachinePistol.ControlCurrentValue = (int)AddressBook.Player.Skills.Weapons.MachinePistol;
            statSMG.ControlCurrentValue = (int)AddressBook.Player.Skills.Weapons.SMG;
            statAK47.ControlCurrentValue = (int)AddressBook.Player.Skills.Weapons.AK47;
            statM4.ControlCurrentValue = (int)AddressBook.Player.Skills.Weapons.M4;
        }

        private void statWeapon_TrackValueChanged(object sender, EventArgs e)
        {
            StatControl s = (StatControl)sender;

            switch (s.ControlText)
            {
                case "Pistol":
                    AddressBook.Player.Skills.Weapons.Pistol = s.ControlCurrentValue;
                    break;

                case "Silenced Pistol":
                    AddressBook.Player.Skills.Weapons.SilencedPistol = s.ControlCurrentValue;
                    break;

                case "Desert Eagle":
                    AddressBook.Player.Skills.Weapons.DesertEagle = s.ControlCurrentValue;
                    break;

                case "Shotgun":
                    AddressBook.Player.Skills.Weapons.Shotgun = s.ControlCurrentValue;
                    break;

                case "Sawnoff Shotgun":
                    AddressBook.Player.Skills.Weapons.SawnoffShotgun = s.ControlCurrentValue;
                    break;

                case "Combat Shotgun":
                    AddressBook.Player.Skills.Weapons.CombatShotgun = s.ControlCurrentValue;
                    break;

                case "Machine Pistol":
                    AddressBook.Player.Skills.Weapons.MachinePistol = s.ControlCurrentValue;
                    break;

                case "SMG":
                    AddressBook.Player.Skills.Weapons.SMG = s.ControlCurrentValue;
                    break;

                case "AK47":
                    AddressBook.Player.Skills.Weapons.AK47 = s.ControlCurrentValue;
                    break;

                case "M4":
                    AddressBook.Player.Skills.Weapons.M4 = s.ControlCurrentValue;
                    break;
            }

            UpdateValues();
        }
    }
}
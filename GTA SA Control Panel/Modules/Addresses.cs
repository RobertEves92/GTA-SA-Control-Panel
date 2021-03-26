namespace GTASAControlPanel.Modules
{
    /// <summary>Memory Addresses for GTA:SA</summary>
    public class Addresses
    {
        #region Player Addresses

        #region References to Offsets and Addresses that vary between versions

        /*
         * Offset determines the STANDARD offset to use between versions
         * Some addresses vary more than just by the standard offset and need
         * either a totally new address, a different offset, or both, depending
         * on which version of GTA:SA is being run
         */
        private int Offset { get; set; }
        private int Money { get; set; }
        private int PlayerAdd { get; set; }
        private int CurrentHealthOffset { get; set; }
        private int ArmorOffset { get; set; }

        #endregion References to Offsets and Addresses that vary between versions

        #region Address Class Constructors

        //private int MemoryWithTwoDifferentAddresses { get; set; } //does not use the offset - placeholder as a reminder

        /// <summary>Addresses for v1.0 of GTA:SA</summary>
        public static Addresses Version1_0 { get; } = new Addresses()//for v1.0
        {
            Offset = 0,            // <-- No Offset for version 1
            Money = 0xB7CE50,
            PlayerAdd = 0xB6F5F0,
            CurrentHealthOffset = 1344,
            ArmorOffset = 1352,
        };

        /// <summary>Addresses for v1.1 of GTA:SA</summary>
        public static Addresses Version1_1 { get; } = new Addresses()//for v1.1
        {
            Offset = 0x2680,
            Money = 0xB7F4D0,
            PlayerAdd = 0xB71C70,
            CurrentHealthOffset = 1344,
            ArmorOffset = 1352,
        };

        /// <summary>Addresses for v3_Steam / Steam Version of GTA:SA</summary>
        public static Addresses Version3_Steam { get; } = new Addresses()//for Steam
        {
            Offset = (-314840),
            Money = 0xB30188,
            PlayerAdd = 0xB1C7D8,
            CurrentHealthOffset = 0x540,
            ArmorOffset = 0x548,
        };

        private Addresses()
        {
        }

        #endregion Address Class Constructors

        #region Misc

        /// <summary>Player Data Address</summary>
        public int PlayerAddress => PlayerAdd;

        /// <summary>Secondary Player Data Address</summary>
        public int PlayerAddress2 => 0xB7CD98 + Offset;

        /// <summary>Money Address</summary>
        public int MoneyAddress => Money;

        /// <summary>Current Health Address</summary>
        public long CurrentHealthAddress => AddressBook.Player.PlayerAddress + CurrentHealthOffset;

        /// <summary>Armor Address</summary>
        public long ArmorAddress => AddressBook.Player.PlayerAddress + ArmorOffset;

        #endregion Misc

        #region Body Stats

        /// <summary>Fat Address</summary>
        public int Fat => 0xB793D4 + Offset;

        /// <summary>Stamina Address</summary>
        public int Stamina => 0xB793D8 + Offset;

        /// <summary>Muscle Address</summary>
        public int Muscle => 0xB793DC + Offset;

        /// <summary>Lung Capacity Address</summary>
        public int LungCapacity => 0xB791A4 + Offset;

        /// <summary>Gambling skill address</summary>
        public int Gambling => 0xB794C4 + Offset;

        #endregion Body Stats

        #region Transport Skills (Driving, Biking, Cycling, Flying)

        /// <summary>Driving skill address</summary>
        public int Driving => 0xB790A0 + Offset;

        /// <summary>Biking skill address</summary>
        public int Biking => 0xB791B4 + Offset;

        /// <summary>Cycling skill address</summary>
        public int Cycling => 0xB791B8 + Offset;

        /// <summary>Flying skill address</summary>
        public int Flying => 0xB7919C + Offset;

        #endregion Transport Skills (Driving, Biking, Cycling, Flying)

        #region Gun Skills

        /// <summary>Pistol skill address</summary>
        public int Pistol => 0xB79494 + Offset;

        /// <summary>Silenced Pistol skill address</summary>
        public int SilencedPistol => 0xB79498 + Offset;

        /// <summary>Desert Eagle skill address</summary>
        public int DesertEagle => 0xB7949C + Offset;

        /// <summary>Shotgun skill address</summary>
        public int Shotgun => 0xB794A0 + Offset;

        /// <summary>Sawnoff Shotgun skill address</summary>
        public int SawnoffShotgun => 0xB794A4 + Offset;

        /// <summary>Combat Shotgun skill address</summary>
        public int CombatShotgun => 0xB794A8 + Offset;

        /// <summary>Machine Pistol skill address</summary>
        public int MachinePistol => 0xB794AC + Offset;

        /// <summary>SMG skill address</summary>
        public int SMG => 0xB794B0 + Offset;

        /// <summary>AK47 skill address</summary>
        public int AK47 => 0xB794B4 + Offset;

        /// <summary>M4 skill address</summary>
        public int M4 => 0xB794B8 + Offset;

        #endregion Gun Skills

        #endregion Player Addresses
    }

    /// <summary>Class of methods for getting and setting game data values</summary>
    public static class AddressBook
    {
        /// <summary>Checks if the player is in a game or not</summary>
        public static bool PlayerInGame
        {
            get
            {
                if (Player.PlayerAddress == 0 && Player.PlayerAddress2 == 0)
                { return false; }
                return true;
            }
        }

        /// <summary>Data relating to the player character (CJ)</summary>
        public static class Player
        {
            /// <summary>Gets the player address</summary>
            public static long PlayerAddress => Memory.ReadMemory<int>(Global.Addresses.PlayerAddress);

            /// <summary>Gets the secondary player address</summary>
            public static long PlayerAddress2 => Memory.ReadMemory<int>(Global.Addresses.PlayerAddress2);

            #region Money/Health/Armour

            /// <summary>Gets or Sets players money</summary>
            public static int Money
            {
                get => Memory.ReadMemory<int>(Global.Addresses.MoneyAddress);
                set => Memory.WriteMemory(Global.Addresses.MoneyAddress, value);
            }

            /// <summary>Gets or Sets players current health level</summary>
            public static float CurrentHealth
            {
                get => Memory.ReadMemory<float>(Global.Addresses.CurrentHealthAddress);
                set => Memory.WriteMemory((int)(Global.Addresses.CurrentHealthAddress), value);
            }

            /// <summary>Gets or Sets players stamina (0-150)</summary>
            public static float Armour
            {
                get => Memory.ReadMemory<float>(Global.Addresses.ArmorAddress);
                set => Memory.WriteMemory((int)(Global.Addresses.ArmorAddress), value);
            }

            #endregion Money/Health/Armour

            #region Body Stats / Abilities

            /// <summary>Gets or Sets players fat (0-1000)</summary>
            public static float Fat
            {
                get => Memory.ReadMemory<float>(Global.Addresses.Fat);
                set => Memory.WriteMemory(Global.Addresses.Fat, value);
            }

            /// <summary>Gets or Sets players stamina (0-1000)</summary>
            public static float Stamina
            {
                get => Memory.ReadMemory<float>(Global.Addresses.Stamina);
                set => Memory.WriteMemory(Global.Addresses.Stamina, value);
            }

            /// <summary>Gets or Sets players muscle level (0-1000)</summary>
            public static float Muscle
            {
                get => Memory.ReadMemory<float>(Global.Addresses.Muscle);
                set => Memory.WriteMemory(Global.Addresses.Muscle, value);
            }

            /// <summary>Gets or Sets players lung capacity (0-1000)</summary>
            public static uint LungCapacity
            {
                get => Memory.ReadMemory<uint>(Global.Addresses.LungCapacity);
                set => Memory.WriteMemory(Global.Addresses.LungCapacity, value);
            }

            #endregion Body Stats / Abilities

            /// <summary>Data relating to CJs skills</summary>

            public static class Skills
            {
                /// <summary>Gets or Sets players gambling level (0-1000)</summary>
                public static float Gambling
                {
                    get => Memory.ReadMemory<float>(Global.Addresses.Gambling);
                    set => Memory.WriteMemory(Global.Addresses.Gambling, value);
                }

                /// <summary>Driving, Biking, Cycling, and Flying skills</summary>
                public static class Transport
                {
                    /// <summary>Gets or Sets players car driving skill (0-1000)</summary>
                    public static uint Driving
                    {
                        get => Memory.ReadMemory<uint>(Global.Addresses.Driving);
                        set => Memory.WriteMemory(Global.Addresses.Driving, value);
                    }

                    /// <summary>Gets or Sets players motorbike driving skill (0-1000)</summary>
                    public static uint Biking
                    {
                        get => Memory.ReadMemory<uint>(Global.Addresses.Biking);
                        set => Memory.WriteMemory(Global.Addresses.Biking, value);
                    }

                    /// <summary>Gets or Sets players cycling skill (0-1000)</summary>
                    public static uint Cycling
                    {
                        get => Memory.ReadMemory<uint>(Global.Addresses.Cycling);
                        set => Memory.WriteMemory(Global.Addresses.Cycling, value);
                    }

                    /// <summary>Gets or Sets players flying skill (0-1000)</summary>
                    public static uint Flying
                    {
                        get => Memory.ReadMemory<uint>(Global.Addresses.Flying);
                        set => Memory.WriteMemory(Global.Addresses.Flying, value);
                    }
                }

                /// <summary>Weapon skill levels</summary>
                public static class Weapons
                {
                    /// <summary>Gets or Sets the skill level for: Pistol</summary>
                    public static float Pistol
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.Pistol);
                        set => Memory.WriteMemory(Global.Addresses.Pistol, value);
                    }

                    /// <summary>Gets or Sets the skill level for: Silenced Pistol</summary>
                    public static float SilencedPistol
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.SilencedPistol);
                        set => Memory.WriteMemory(Global.Addresses.SilencedPistol, value);
                    }

                    /// <summary>Gets or Sets the skill level for: Desert Eagle</summary>
                    public static float DesertEagle
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.DesertEagle);
                        set => Memory.WriteMemory(Global.Addresses.DesertEagle, value);
                    }

                    /// <summary>Gets or Sets the skill level for: Shotgun</summary>
                    public static float Shotgun
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.Shotgun);
                        set => Memory.WriteMemory(Global.Addresses.Shotgun, value);
                    }

                    /// <summary>Gets or Sets the skill level for: Sawnoff Shotgun</summary>
                    public static float SawnoffShotgun
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.SawnoffShotgun);
                        set => Memory.WriteMemory(Global.Addresses.SawnoffShotgun, value);
                    }

                    /// <summary>Gets or Sets the skill level for: Combat Shotgun</summary>
                    public static float CombatShotgun
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.CombatShotgun);
                        set => Memory.WriteMemory(Global.Addresses.CombatShotgun, value);
                    }

                    /// <summary>Gets or Sets the skill level for: Machine Pistol</summary>
                    public static float MachinePistol
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.MachinePistol);
                        set => Memory.WriteMemory(Global.Addresses.MachinePistol, value);
                    }

                    /// <summary>Gets or Sets the skill level for: SMG</summary>
                    public static float SMG
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.SMG);
                        set => Memory.WriteMemory(Global.Addresses.SMG, value);
                    }

                    /// <summary>Gets or Sets the skill level for: AK47</summary>
                    public static float AK47
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.AK47);
                        set => Memory.WriteMemory(Global.Addresses.AK47, value);
                    }

                    /// <summary>Gets or Sets the skill level for: M4</summary>
                    public static float M4
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.M4);
                        set => Memory.WriteMemory(Global.Addresses.M4, value);
                    }
                }
            }
        }
    }
}
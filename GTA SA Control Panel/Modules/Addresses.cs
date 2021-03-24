namespace GTASAControlPanel.Modules
{
    /// <summary>
    /// Memory Addresses for GTA:SA
    /// </summary>
    public class Addresses
    {
        private int Offset { get; set; }

        #region Player Addresses

        #region Misc

        /// <summary>
        /// Player Data Address
        /// </summary>
        public int PlayerAddress => 0xB6F5F0 + Offset;

        /// <summary>
        /// Secondary Player Data Address
        /// </summary>
        public int PlayerAddress2 => 0xB7CD98 + Offset;

        /// <summary>
        /// Money Address
        /// </summary>
        public int Money => 0xB7CE50 + Offset;

        #endregion Misc

        #region Body Stats

        /// <summary>
        /// Fat Address
        /// </summary>
        public int Fat => 0xB793D4 + Offset;

        /// <summary>
        /// Stamina Address
        /// </summary>
        public int Stamina => 0xB793D8 + Offset;

        /// <summary>
        /// Muscle Address
        /// </summary>
        public int Muscle => 0xB793DC + Offset;

        /// <summary>
        /// Lung Capacity Address
        /// </summary>
        public int LungCapacity => 0xB791A4 + Offset;

        /// <summary>
        /// Gambling skill address
        /// </summary>
        public int Gambling => 0xB794C4 + Offset;

        #endregion Body Stats

        #region Transport Skills (Driving, Biking, Cycling, Flying)

        /// <summary>
        /// Driving skill address
        /// </summary>
        public int Driving => 0xB790A0 + Offset;

        /// <summary>
        /// Biking skill address
        /// </summary>
        public int Biking => 0xB791B4 + Offset;

        /// <summary>
        /// Cycling skill address
        /// </summary>
        public int Cycling => 0xB791B8 + Offset;

        /// <summary>
        /// Flying skill address
        /// </summary>
        public int Flying => 0xB7919C + Offset;

        #endregion Transport Skills (Driving, Biking, Cycling, Flying)

        #region Gun Skills

        /// <summary>
        /// Pistol skill address
        /// </summary>
        public int Pistol => 0xB79494 + Offset;

        /// <summary>
        /// Silenced Pistol skill address
        /// </summary>
        public int SilencedPistol => 0xB79498 + Offset;

        /// <summary>
        /// Desert Eagle skill address
        /// </summary>
        public int DesertEagle => 0xB7949C + Offset;

        /// <summary>
        /// Shotgun skill address
        /// </summary>
        public int Shotgun => 0xB794A0 + Offset;

        /// <summary>
        /// Sawnoff Shotgun skill address
        /// </summary>
        public int SawnoffShotgun => 0xB794A4 + Offset;

        /// <summary>
        /// Combat Shotgun skill address
        /// </summary>
        public int CombatShotgun => 0xB794A8 + Offset;

        /// <summary>
        /// Machine Pistol skill address
        /// </summary>
        public int MachinePistol => 0xB794AC + Offset;

        /// <summary>
        /// SMG skill address
        /// </summary>
        public int SMG => 0xB794B0 + Offset;

        /// <summary>
        /// AK47 skill address
        /// </summary>
        public int AK47 => 0xB794B4 + Offset;

        /// <summary>
        /// M4 skill address
        /// </summary>
        public int M4 => 0xB794B8 + Offset;

        #endregion Gun Skills

        #endregion Player Addresses

        #region Misc

        //private int MemoryWithTwoDifferentAddresses { get; set; } //does not use the offset - placeholder as a reminder

        #endregion Misc

        /// <summary>
        /// Addresses for v1.0 of GTA:SA
        /// </summary>
        public static Addresses Version1 { get; } = new Addresses()//for v1.0
        {
            Offset = 0,            // <-- No Offset for version 1
            //MemoryWithTwoDifferentAddresses = 123456,  // <-- Explicit address for version 1
        };

        /// <summary>
        /// Addresses for v1.1 of GTA:SA
        /// </summary>
        public static Addresses Version2 { get; } = new Addresses()//for v1.1
        {
            Offset = 0x2680,                 // <-- No offset for version 2
            //MemoryWithTwoDifferentAddresses = 987654,  // <-- Different explicit address for version 2
        };

        private Addresses()
        {
        }
    }

    /// <summary>
    /// Class of methods for getting and setting game data values
    /// </summary>
    public static class AddressBook
    {
        /// <summary>
        /// Checks if the player is in a game or not
        /// </summary>
        public static bool PlayerInGame
        {
            get
            {
                if (Player.PlayerAddress == 0 && Player.PlayerAddress2 == 0)
                { return false; }
                return true;
            }
        }

        /// <summary>
        /// Data relating to the player character (CJ)
        /// </summary>
        public static class Player
        {
            /// <summary>
            /// Gets the player address
            /// </summary>
            public static long PlayerAddress => Memory.ReadMemory<int>(Global.Addresses.PlayerAddress);

            /// <summary>
            /// Gets the secondary player address
            /// </summary>
            public static long PlayerAddress2 => Memory.ReadMemory<int>(Global.Addresses.PlayerAddress2);

            #region Money/Health/Armour

            /// <summary>
            /// Gets or Sets players money
            /// </summary>
            public static int Money
            {
                get => Memory.ReadMemory<int>(Global.Addresses.Money);
                set => Memory.WriteMemory<int>(Global.Addresses.Money, value);
            }

            /// <summary>
            /// Gets or Sets players current health level
            /// </summary>
            public static float CurrentHealth
            {
                get => Memory.ReadMemory<float>(PlayerAddress + 1344);
                set => Memory.WriteMemory<float>((int)(PlayerAddress + 1344), value);
            }

            /// <summary>
            /// Gets or Sets players max health level
            /// </summary>
            public static float MaxHealth
            {
                get => Memory.ReadMemory<float>(PlayerAddress + 1348);
                set => Memory.WriteMemory<float>((int)(PlayerAddress + 1348), value);
            }

            /// <summary>
            /// Gets or Sets players stamina (0-150)
            /// </summary>
            public static float Armour
            {
                get => Memory.ReadMemory<float>(PlayerAddress + 1352);
                set => Memory.WriteMemory<float>((int)(PlayerAddress + 1352), value);
            }

            #endregion Money/Health/Armour

            #region Body Stats / Abilities

            /// <summary>
            /// Gets or Sets players fat (0-1000)
            /// </summary>
            public static float Fat
            {
                get => Memory.ReadMemory<float>(Global.Addresses.Fat);
                set => Memory.WriteMemory<float>(Global.Addresses.Fat, value);
            }

            /// <summary>
            /// Gets or Sets players stamina (0-1000)
            /// </summary>
            public static float Stamina
            {
                get => Memory.ReadMemory<float>(Global.Addresses.Stamina);
                set => Memory.WriteMemory<float>(Global.Addresses.Stamina, value);
            }

            /// <summary>
            /// Gets or Sets players muscle level (0-1000)
            /// </summary>
            public static float Muscle
            {
                get => Memory.ReadMemory<float>(Global.Addresses.Muscle);
                set => Memory.WriteMemory<float>(Global.Addresses.Muscle, value);
            }

            /// <summary>
            /// Gets or Sets players lung capacity (0-1000)
            /// </summary>
            public static float LungCapacity
            {
                get => Memory.ReadMemory<float>(Global.Addresses.LungCapacity);
                set => Memory.WriteMemory<float>(Global.Addresses.LungCapacity, value);
            }

            #endregion Body Stats / Abilities

            /// <summary>
            /// Data relating to CJs skills
            /// </summary>

            public static class Skills
            {
                /// <summary>
                /// Gets or Sets players gambling level (0-1000)
                /// </summary>
                public static float Gambling
                {
                    get => Memory.ReadMemory<float>(Global.Addresses.Gambling);
                    set => Memory.WriteMemory<float>(Global.Addresses.Gambling, value);
                }

                /// <summary>
                /// Driving, Biking, Cycling, and Flying skills
                /// </summary>
                public static class Transport
                {
                    /// <summary>
                    /// Gets or Sets players car driving skill (0-1000)
                    /// </summary>
                    public static uint Driving
                    {
                        get => Memory.ReadMemory<uint>(Global.Addresses.Driving);
                        set => Memory.WriteMemory<uint>(Global.Addresses.Driving, value);
                    }

                    /// <summary>
                    /// Gets or Sets players motorbike driving skill (0-1000)
                    /// </summary>
                    public static uint Biking
                    {
                        get => Memory.ReadMemory<uint>(Global.Addresses.Biking);
                        set => Memory.WriteMemory<uint>(Global.Addresses.Biking, value);
                    }

                    /// <summary>
                    /// Gets or Sets players cycling skill (0-1000)
                    /// </summary>
                    public static uint Cycling
                    {
                        get => Memory.ReadMemory<uint>(Global.Addresses.Cycling);
                        set => Memory.WriteMemory<uint>(Global.Addresses.Cycling, value);
                    }

                    /// <summary>
                    /// Gets or Sets players flying skill (0-1000)
                    /// </summary>
                    public static uint Flying
                    {
                        get => Memory.ReadMemory<uint>(Global.Addresses.Flying);
                        set => Memory.WriteMemory<uint>(Global.Addresses.Flying, value);
                    }
                }

                /// <summary>
                /// Weapon skill levels
                /// </summary>
                public static class Weapons
                {
                    /// <summary>
                    /// Gets or Sets the skill level for: Pistol
                    /// </summary>
                    public static float Pistol
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.Pistol);
                        set => Memory.WriteMemory<float>(Global.Addresses.Pistol, value);
                    }

                    /// <summary>
                    /// Gets or Sets the skill level for: Silenced Pistol
                    /// </summary>
                    public static float SilencedPistol
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.SilencedPistol);
                        set => Memory.WriteMemory<float>(Global.Addresses.SilencedPistol, value);
                    }

                    /// <summary>
                    /// Gets or Sets the skill level for: Desert Eagle
                    /// </summary>
                    public static float DesertEagle
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.DesertEagle);
                        set => Memory.WriteMemory<float>(Global.Addresses.DesertEagle, value);
                    }

                    /// <summary>
                    /// Gets or Sets the skill level for: Shotgun
                    /// </summary>
                    public static float Shotgun
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.Shotgun);
                        set => Memory.WriteMemory<float>(Global.Addresses.Shotgun, value);
                    }

                    /// <summary>
                    /// Gets or Sets the skill level for: Sawnoff Shotgun
                    /// </summary>
                    public static float SawnoffShotgun
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.SawnoffShotgun);
                        set => Memory.WriteMemory<float>(Global.Addresses.SawnoffShotgun, value);
                    }

                    /// <summary>
                    /// Gets or Sets the skill level for: Combat Shotgun
                    /// </summary>
                    public static float CombatShotgun
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.CombatShotgun);
                        set => Memory.WriteMemory<float>(Global.Addresses.CombatShotgun, value);
                    }

                    /// <summary>
                    /// Gets or Sets the skill level for: Machine Pistol
                    /// </summary>
                    public static float MachinePistol
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.MachinePistol);
                        set => Memory.WriteMemory<float>(Global.Addresses.MachinePistol, value);
                    }

                    /// <summary>
                    /// Gets or Sets the skill level for: SMG
                    /// </summary>
                    public static float SMG
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.SMG);
                        set => Memory.WriteMemory<float>(Global.Addresses.SMG, value);
                    }

                    /// <summary>
                    /// Gets or Sets the skill level for: AK47
                    /// </summary>
                    public static float AK47
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.AK47);
                        set => Memory.WriteMemory<float>(Global.Addresses.AK47, value);
                    }

                    /// <summary>
                    /// Gets or Sets the skill level for: M4
                    /// </summary>
                    public static float M4
                    {
                        get => Memory.ReadMemory<float>(Global.Addresses.M4);
                        set => Memory.WriteMemory<float>(Global.Addresses.M4, value);
                    }
                }
            }
        }
    }
}
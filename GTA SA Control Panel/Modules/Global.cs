using GTASAControlPanel.Modules;

namespace GTASAControlPanel
{
    /// <summary>Class for globally accessable bits</summary>
    public static class Global
    {
        /// <summary>Addresses in use</summary>
        public static Addresses Addresses { get; set; }

        /// <summary>List of custom process names specified in command line arguments</summary>
        public static string[] CustomProcess { get; set; }
    }
}
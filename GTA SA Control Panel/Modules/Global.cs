using GTASAControlPanel.Modules;

namespace GTASAControlPanel
{
    /// <summary>
    /// Class for globally accessable bits
    /// </summary>
    public static class Global
    {
        /// <summary>
        /// Addresses in use
        /// </summary>
        public static Addresses Addresses { get; set; }

        public static string[] CustomProcess { get; set; }
    }
}
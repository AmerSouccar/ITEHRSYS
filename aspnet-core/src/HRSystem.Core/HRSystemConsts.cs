using HRSystem.Debugging;

namespace HRSystem
{
    public class HRSystemConsts
    {
        public const string LocalizationSourceName = "HRSystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "460ce1354c854e2ea2ff1a0c8c39a5a0";
    }
}

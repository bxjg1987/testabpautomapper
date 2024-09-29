using TestAutomapper.Debugging;

namespace TestAutomapper
{
    public class TestAutomapperConsts
    {
        public const string LocalizationSourceName = "TestAutomapper";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "1d9633f7bbd3446196f4310237bab94a";
    }
}

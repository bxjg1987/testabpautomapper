using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TestAutomapper.Localization
{
    public static class TestAutomapperLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TestAutomapperConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TestAutomapperLocalizationConfigurer).GetAssembly(),
                        "TestAutomapper.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

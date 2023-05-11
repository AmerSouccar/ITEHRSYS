using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HRSystem.Localization
{
    public static class HRSystemLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HRSystemConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HRSystemLocalizationConfigurer).GetAssembly(),
                        "HRSystem.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

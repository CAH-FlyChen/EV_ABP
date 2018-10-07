using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace EV.Localization
{
    public static class EVLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            var ass = typeof(EVLocalizationConfigurer).GetAssembly();
            var p = new XmlEmbeddedFileLocalizationDictionaryProvider(ass, "EV.Localization.SourceFiles");
            var x = new DictionaryBasedLocalizationSource(EVConsts.LocalizationSourceName,p);
            localizationConfiguration.Sources.Add(x);
        }
    }
}

using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAnalyticsProfileBinding
{
    public class CsvserverAnalyticsProfileBindingAddRequestData : INitroRequestData
    {
        public string Name { get; set; }
        public string AnalyticsProfile { get; set; }
    }
}
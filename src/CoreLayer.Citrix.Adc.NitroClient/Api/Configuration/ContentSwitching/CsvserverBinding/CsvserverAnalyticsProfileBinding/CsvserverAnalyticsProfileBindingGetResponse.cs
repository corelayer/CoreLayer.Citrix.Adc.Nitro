using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAnalyticsProfileBinding
{
    public class CsvserverAnalyticsProfileBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("csvserver_analyticsprofile_binding")]
        public CsvserverAnalyticsProfileBindingConfiguration[] CsvserverAnalyticsProfileBindingConfigurations { get; set; }
    }
}
using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAnalyticsProfileBinding
{
    public class CsvserverAnalyticsProfileBindingRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/csvserver_analyticsprofile_binding";
        public override INitroRequestDataRoot DataRoot => new CsvserverAnalyticsProfileBindingRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverAnalyticsProfileBindingRemoveRequestOptions();
    }
}
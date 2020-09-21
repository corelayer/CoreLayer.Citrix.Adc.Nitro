using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAnalyticsProfileBinding
{
    public class CsvserverAnalyticsProfileBindingAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/csvserver_analyticsprofile_binding";
        public override INitroRequestOptions Options => new CsvserverAnalyticsProfileBindingAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsvserverAnalyticsProfileBindingAddRequestConfiguration(CsvserverAnalyticsProfileBindingAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
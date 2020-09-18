using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverCsPolicyBinding
{
    public class CsvserverBindingRemoveCsPolicyRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/csvserver_cspolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsvserverBindingRemoveCsPolicyRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverBindingRemoveCsPolicyRequestOptions();
    }
}
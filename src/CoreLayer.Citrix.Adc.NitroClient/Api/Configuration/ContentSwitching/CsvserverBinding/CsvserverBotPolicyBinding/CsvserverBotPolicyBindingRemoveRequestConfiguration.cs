using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverBotPolicyBinding
{
    public class CsvserverBotPolicyBindingRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/csvserver_botpolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsvserverBotPolicyBindingRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverBotPolicyBindingRemoveRequestOptions();
    }
}
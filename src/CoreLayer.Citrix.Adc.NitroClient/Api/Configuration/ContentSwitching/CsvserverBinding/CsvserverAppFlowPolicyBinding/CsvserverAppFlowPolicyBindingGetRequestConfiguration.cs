using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFlowPolicyBinding
{
    public class CsvserverAppFlowPolicyBindingGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/csvserver_appflowpolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsvserverAppFlowPolicyBindingGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverAppFlowPolicyBindingGetRequestOptions();
    }
}
using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverBotPolicyBinding
{
    public class CsvserverBotPolicyBindingAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/csvserver_botpolicy_binding";
        public override INitroRequestOptions Options => new CsvserverBotPolicyBindingAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsvserverBotPolicyBindingAddRequestConfiguration(CsvserverBotPolicyBindingAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
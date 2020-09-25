using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppQoePolicyBinding
{
    public class CsvserverAppQoePolicyBindingAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/csvserver_appqoepolicy_binding";
        public override INitroRequestOptions Options => new CsvserverAppQoePolicyBindingAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsvserverAppQoePolicyBindingAddRequestConfiguration(CsvserverAppQoePolicyBindingAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
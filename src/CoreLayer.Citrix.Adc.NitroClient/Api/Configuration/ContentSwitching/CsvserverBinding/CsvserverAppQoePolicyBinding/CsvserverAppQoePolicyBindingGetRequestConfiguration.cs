using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppQoePolicyBinding
{
    public class CsvserverAppQoePolicyBindingGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/csvserver_appqoepolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsvserverAppQoePolicyBindingGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverAppQoePolicyBindingGetRequestOptions();
    }
}
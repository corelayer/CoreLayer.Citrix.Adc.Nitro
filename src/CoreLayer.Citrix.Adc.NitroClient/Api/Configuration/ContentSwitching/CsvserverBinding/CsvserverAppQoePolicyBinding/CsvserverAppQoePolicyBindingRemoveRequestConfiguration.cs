using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppQoePolicyBinding
{
    public class CsvserverAppQoePolicyBindingRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/csvserver_appqoepolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsvserverAppQoePolicyBindingRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverAppQoePolicyBindingRemoveRequestOptions();
    }
}
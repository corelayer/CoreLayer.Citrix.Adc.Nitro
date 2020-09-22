using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFwPolicyBinding
{
    public class CsvserverAppFwPolicyBindingAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/csvserver_appfwpolicy_binding";
        public override INitroRequestOptions Options => new CsvserverAppFwPolicyBindingAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsvserverAppFwPolicyBindingAddRequestConfiguration(CsvserverAppFwPolicyBindingAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingAddLbvserverRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/csvserver_lbvserver_binding";
        public override INitroRequestOptions Options => new CsvserverBindingAddLbvserverRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsvserverBindingAddLbvserverRequestConfiguration(CsvserverBindingAddLbvserverRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
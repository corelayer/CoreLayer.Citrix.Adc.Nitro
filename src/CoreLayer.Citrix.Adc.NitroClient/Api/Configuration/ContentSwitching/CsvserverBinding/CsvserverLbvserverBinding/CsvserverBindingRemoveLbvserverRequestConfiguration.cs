using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverLbvserverBinding
{
    public class CsvserverBindingRemoveLbvserverRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/csvserver_lbvserver_binding";
        public override INitroRequestDataRoot DataRoot => new CsvserverBindingRemoveLbvserverRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverBindingRemoveLbvserverRequestOptions();
    }
}
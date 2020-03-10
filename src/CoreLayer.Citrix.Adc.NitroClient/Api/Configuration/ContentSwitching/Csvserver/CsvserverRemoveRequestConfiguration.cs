using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverRemoveRequestConfiguration: NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/csvserver";
        public override INitroRequestDataRoot DataRoot => new CsvserverRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverRemoveRequestOptions();
    }
}
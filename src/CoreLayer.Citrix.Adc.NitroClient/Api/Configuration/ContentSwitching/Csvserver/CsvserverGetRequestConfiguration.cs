using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/csvserver";
        public override INitroRequestOptions Options { get; set; } = new CsvserverGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new CsvserverGetRequestDataRoot();
    }
}
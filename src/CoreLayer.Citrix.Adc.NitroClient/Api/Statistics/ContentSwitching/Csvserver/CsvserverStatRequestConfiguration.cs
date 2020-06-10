using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.ContentSwitching.Csvserver
{
    public class CsvserverStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/csvserver";
        public override INitroRequestDataRoot DataRoot => new CsvserverStatRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverStatRequestOptions();
    }
}
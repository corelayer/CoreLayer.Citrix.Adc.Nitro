using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/csvserver";
        public override INitroRequestOptions Options => new CsvserverAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsvserverAddRequestConfiguration(CsvserverAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
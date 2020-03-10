using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/csvserver";
        public override INitroRequestOptions Options => new CsvserverUpdateRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsvserverUpdateRequestConfiguration(CsvserverUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
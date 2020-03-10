using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server
{
    public class ServerUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/server";
        public override INitroRequestOptions Options => new ServerUpdateRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public ServerUpdateRequestConfiguration(ServerUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
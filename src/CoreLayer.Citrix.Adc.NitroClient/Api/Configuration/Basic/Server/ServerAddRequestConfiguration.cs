using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server
{
    public class ServerAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/server";
        public override INitroRequestDataRoot DataRoot { get; } 
        public override INitroRequestOptions Options => new ServerAddRequestOptions();
        
        public ServerAddRequestConfiguration(ServerAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server
{
    public class ServerGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/server";
        public override INitroRequestOptions Options { get; set; } = new ServerGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new ServerGetRequestDataRoot();


    }
}
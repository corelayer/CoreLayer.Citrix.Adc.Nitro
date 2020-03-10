using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemFile
{
    public class SystemFileAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/systemfile";
        public override INitroRequestOptions Options => new SystemFileAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public SystemFileAddRequestConfiguration(SystemFileAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
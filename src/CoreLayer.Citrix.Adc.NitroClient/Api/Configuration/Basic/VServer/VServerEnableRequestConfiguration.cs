using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.VServer
{
    public class VServerEnableRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/vserver";
        public override INitroRequestDataRoot DataRoot { get; }
        public override INitroRequestOptions Options => new VServerEnableRequestOptions(){Action = "enable"};
                
        public VServerEnableRequestConfiguration(VServerEnableRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
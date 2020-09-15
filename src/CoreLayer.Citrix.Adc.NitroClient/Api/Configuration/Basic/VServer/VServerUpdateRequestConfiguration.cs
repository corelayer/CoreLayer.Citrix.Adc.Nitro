using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.VServer
{
    public class VServerUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/vserver";
        public override INitroRequestDataRoot DataRoot { get; } 
        public override INitroRequestOptions Options => new VServerUpdateRequestOptions();
        
        public VServerUpdateRequestConfiguration(VServerUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
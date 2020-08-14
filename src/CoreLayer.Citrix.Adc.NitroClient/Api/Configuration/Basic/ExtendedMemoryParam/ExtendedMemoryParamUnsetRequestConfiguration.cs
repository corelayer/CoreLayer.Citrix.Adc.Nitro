using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamUnsetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/extendedmemoryparam";
        public override INitroRequestDataRoot DataRoot => new ExtendedMemoryParamUnsetRequestDataRoot(); 
        public override INitroRequestOptions Options  => new ExtendedMemoryParamUnsetRequestOptions(){Action = "unset"};
                
        public ExtendedMemoryParamUnsetRequestConfiguration()
        {
            
        }
    }
}
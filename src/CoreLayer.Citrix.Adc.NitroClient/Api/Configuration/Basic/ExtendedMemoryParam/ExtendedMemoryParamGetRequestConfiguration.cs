using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/extendedmemoryparam";
        public override INitroRequestDataRoot DataRoot => new ExtendedMemoryParamGetRequestDataRoot(); 
        public override INitroRequestOptions Options { get; set; } = new ExtendedMemoryParamGetRequestOptions();
                
        public ExtendedMemoryParamGetRequestConfiguration()
        {
            
        }
    }
}
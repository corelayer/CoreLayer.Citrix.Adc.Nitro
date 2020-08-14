using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamUpdateRequestConfiguration : NitroRequestConfiguration
    {
         public override HttpMethod Method => HttpMethod.Put;
         public override string ResourcePath => "/nitro/v1/config/extendedmemoryparam";
         public override INitroRequestDataRoot DataRoot { get; } 
         public override INitroRequestOptions Options => new ExtendedMemoryParamUpdateRequestOptions();
                        
         public ExtendedMemoryParamUpdateRequestConfiguration(ExtendedMemoryParamUpdateRequestDataRoot dataroot)
         {
             DataRoot = dataroot;
         }
    }
}
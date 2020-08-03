using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsAcl6
{
    public class NsAcl6StatRequestConfiguration : NitroRequestConfiguration
    {
         public override HttpMethod Method => HttpMethod.Get;
         public override string ResourcePath => "/nitro/v1/stat/nsacl6";
         public override INitroRequestOptions Options { get; set; } = new NsAcl6StatRequestOptions();
         public override INitroRequestDataRoot DataRoot => new NsAcl6StatRequestDataRoot();
                
         public NsAcl6StatRequestConfiguration() {}
    }
}
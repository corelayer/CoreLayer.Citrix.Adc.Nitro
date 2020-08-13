using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsSimpleAcl
{
    public class NsSimpleAclStatRequestConfiguration : NitroRequestConfiguration
    {
         public override HttpMethod Method => HttpMethod.Get;
         public override string ResourcePath => "/nitro/v1/stat/nssimpleacl";
         public override INitroRequestOptions Options { get; set; } = new NsSimpleAclStatRequestOptions();
         public override INitroRequestDataRoot DataRoot => new NsSimpleAclStatRequestDataRoot();
                                
         public NsSimpleAclStatRequestConfiguration() {}
    }
}
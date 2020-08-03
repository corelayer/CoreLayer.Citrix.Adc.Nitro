using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsAcl
{
    public class NsAclStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/nsacl";
        public override INitroRequestOptions Options { get; set; } = new NsAclStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new NsAclStatRequestDataRoot();
        
        public NsAclStatRequestConfiguration() {}
    }
}
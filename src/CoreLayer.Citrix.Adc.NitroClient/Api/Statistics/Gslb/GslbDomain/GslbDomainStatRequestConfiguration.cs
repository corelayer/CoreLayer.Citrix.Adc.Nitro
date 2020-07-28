using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbDomain
{
    public class GslbDomainStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/gslbdomain";
        public override INitroRequestOptions Options { get; set; } = new GslbDomainStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new GslbDomainStatRequestDataRoot();
                        
        public GslbDomainStatRequestConfiguration() {}
    }
}
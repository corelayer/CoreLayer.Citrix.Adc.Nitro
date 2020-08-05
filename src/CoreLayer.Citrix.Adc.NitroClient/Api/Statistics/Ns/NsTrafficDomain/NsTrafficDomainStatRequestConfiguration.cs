using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsTrafficDomain
{
    public class NsTrafficDomainStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/nstrafficdomain";
        public override INitroRequestOptions Options { get; set; } = new NsTrafficDomainStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new NsTrafficDomainStatRequestDataRoot();
                                        
        public NsTrafficDomainStatRequestConfiguration() {}
    }
}
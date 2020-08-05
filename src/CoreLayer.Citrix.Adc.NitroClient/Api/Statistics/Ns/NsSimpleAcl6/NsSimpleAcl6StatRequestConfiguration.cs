using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsSimpleAcl6
{
    public class NsSimpleAcl6StatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/nssimpleacl6";
        public override INitroRequestOptions Options { get; set; } = new NsSimpleAcl6StatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new NsSimpleAcl6StatRequestDataRoot();
                                        
        public NsSimpleAcl6StatRequestConfiguration() {}
    }
}
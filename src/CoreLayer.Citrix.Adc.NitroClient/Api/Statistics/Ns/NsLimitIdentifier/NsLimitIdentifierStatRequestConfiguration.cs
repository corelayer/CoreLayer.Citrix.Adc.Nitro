using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsLimitIdentifier
{
    public class NsLimitIdentifierStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/nslimitidentifier";
        public override INitroRequestOptions Options { get; set; } = new NsLimitIdentifierStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new NsLimitIdentifierStatRequestDataRoot();
                        
        public NsLimitIdentifierStatRequestConfiguration() {}
    }
}
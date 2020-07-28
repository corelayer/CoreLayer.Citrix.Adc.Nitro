using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ica.IcaPolicy
{
    public class IcaPolicyStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/icapolicy";
        public override INitroRequestOptions Options { get; set; } = new IcaPolicyStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new IcaPolicyStatRequestDataRoot();
                        
        public IcaPolicyStatRequestConfiguration() {}
    }
}
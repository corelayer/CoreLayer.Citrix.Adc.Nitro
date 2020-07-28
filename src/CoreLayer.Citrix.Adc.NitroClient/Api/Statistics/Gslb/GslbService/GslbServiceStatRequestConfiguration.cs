using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbService
{
    public class GslbServiceStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/gslbservice";
        public override INitroRequestOptions Options { get; set; } = new GslbServiceStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new GslbServiceStatRequestDataRoot();
                        
        public GslbServiceStatRequestConfiguration() {}
    }
}
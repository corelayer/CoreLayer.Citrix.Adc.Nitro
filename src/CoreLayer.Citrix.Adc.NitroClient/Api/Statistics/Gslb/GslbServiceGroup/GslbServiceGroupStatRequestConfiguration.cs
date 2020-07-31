using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbServiceGroup
{
    public class GslbServiceGroupStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/gslbservicegroup";
        public override INitroRequestOptions Options { get; set; } = new GslbServiceGroupStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new GslbServiceGroupStatRequestDataRoot();
                        
        public GslbServiceGroupStatRequestConfiguration() {}
    }
}
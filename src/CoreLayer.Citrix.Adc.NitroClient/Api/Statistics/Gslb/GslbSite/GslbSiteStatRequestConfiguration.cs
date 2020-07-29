using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbSite
{
    public class GslbSiteStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/gslbsite";
        public override INitroRequestOptions Options { get; set; } = new GslbSiteStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new GslbSiteStatRequestDataRoot();
                        
        public GslbSiteStatRequestConfiguration() {}
    }
}
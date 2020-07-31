using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbVserver
{
    public class GslbVserverStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/gslbvserver";
        public override INitroRequestOptions Options { get; set; } = new GslbVserverStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new GslbVserverStatRequestDataRoot();
                        
        public GslbVserverStatRequestConfiguration() {}
    }
}
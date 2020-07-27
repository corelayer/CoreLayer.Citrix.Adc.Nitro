using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.AppFirewall.AppFw
{
    public class AppFwStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/appfw";
        public override INitroRequestOptions Options { get; set; } = new AppFwStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new AppFwStatRequestDataRoot();
                        
        public AppFwStatRequestConfiguration() {}
    }
}
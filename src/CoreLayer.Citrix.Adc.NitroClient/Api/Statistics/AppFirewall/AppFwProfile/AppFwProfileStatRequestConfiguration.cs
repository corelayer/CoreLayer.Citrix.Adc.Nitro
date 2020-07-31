using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.AppFirewall.AppFwProfile
{
    public class AppFwProfileStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/appfwprofile";
        public override INitroRequestOptions Options { get; set; } = new AppFwProfileStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new AppFwProfileStatRequestDataRoot();
                                
        public AppFwProfileStatRequestConfiguration() {}
    }
}
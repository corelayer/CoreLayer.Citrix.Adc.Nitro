using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.AppFirewall.AppFwPolicy
{
    public class AppFwPolicyStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/appfwpolicy";
        public override INitroRequestOptions Options { get; set; } = new AppFwPolicyStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new AppFwPolicyStatRequestDataRoot();
                        
        public AppFwPolicyStatRequestConfiguration() {}
    }
}
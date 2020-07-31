using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.AppFirewall.AppFwPolicyLabel
{
    public class AppFwPolicyLabelStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/appfwpolicylabel";
        public override INitroRequestOptions Options { get; set; } = new AppFwPolicyLabelStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new AppFwPolicyLabelStatRequestDataRoot();
                                
        public AppFwPolicyLabelStatRequestConfiguration() {}
    }
}
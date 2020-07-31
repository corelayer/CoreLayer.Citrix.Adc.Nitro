using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbServiceGroupMember
{
    public class GslbServiceGroupMemberStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/gslbservicegroupmember";
        public override INitroRequestOptions Options { get; set; } = new GslbServiceGroupMemberStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new GslbServiceGroupMemberStatRequestDataRoot();
                        
        public GslbServiceGroupMemberStatRequestConfiguration() {}
    }
}
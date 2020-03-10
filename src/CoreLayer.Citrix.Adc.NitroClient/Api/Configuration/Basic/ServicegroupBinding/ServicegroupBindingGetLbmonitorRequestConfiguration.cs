using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingGetLbmonitorRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/servicegroup_lbmonitor_binding";
        public override INitroRequestDataRoot DataRoot => new ServicegroupBindingGetLbmonitorRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServicegroupBindingGetLbmonitorRequestOptions();
        
    }
}
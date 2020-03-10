using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupGetRequestConfiguration :NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/servicegroup";
        public override INitroRequestOptions Options { get; set; } = new ServicegroupGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new ServicegroupGetRequestDataRoot();
    }
}
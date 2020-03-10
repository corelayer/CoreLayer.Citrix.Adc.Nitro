using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/servicegroup";
        public override INitroRequestDataRoot DataRoot => new ServicegroupRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServicegroupRemoveRequestOptions();
    }
}
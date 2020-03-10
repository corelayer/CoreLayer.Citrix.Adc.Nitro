using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Basic.Servicegroup
{
    public class ServicegroupStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/servicegroup";
        public override INitroRequestDataRoot DataRoot => new ServicegroupStatRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServicegroupStatRequestOptions();
    }
}
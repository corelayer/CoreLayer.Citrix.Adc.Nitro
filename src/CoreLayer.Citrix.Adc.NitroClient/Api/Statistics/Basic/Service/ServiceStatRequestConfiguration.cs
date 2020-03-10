using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Basic.Service
{
    public class ServiceStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/service";
        public override INitroRequestDataRoot DataRoot => new ServiceStatRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServiceStatRequestOptions();
    }
}
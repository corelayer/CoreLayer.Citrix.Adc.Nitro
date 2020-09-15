using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBindings
{
    public class ServiceBindingsGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/svcbindings";
        public override INitroRequestDataRoot DataRoot => new ServiceBindingsGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServiceBindingsGetRequestOptions();
    }
}
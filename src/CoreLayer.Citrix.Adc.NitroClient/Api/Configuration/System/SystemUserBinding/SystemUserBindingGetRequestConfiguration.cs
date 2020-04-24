using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserBinding
{
    public class SystemUserBindingGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/systemuser_binding";
        public override INitroRequestDataRoot DataRoot => new SystemUserBindingGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new SystemUserBindingGetRequestOptions();
    }
}
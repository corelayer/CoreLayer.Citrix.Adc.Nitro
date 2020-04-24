using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUser
{
    public class SystemUserRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/systemuser";
        public override INitroRequestDataRoot DataRoot => new SystemUserRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new SystemUserRemoveRequestOptions();
    }
}
using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUser
{
    public class SystemUserUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/systemuser";
        public override INitroRequestOptions Options => new SystemUserUpdateRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public SystemUserUpdateRequestConfiguration(SystemUserUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUser
{
    public class SystemUserAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/systemuser";
        public override INitroRequestOptions Options => new SystemUserAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public SystemUserAddRequestConfiguration(SystemUserAddRequestDataRoot dataroot)
        {
            DataRoot = dataroot;
        }
    }
}
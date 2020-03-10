using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/service";
        public override INitroRequestOptions Options => new ServiceAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public ServiceAddRequestConfiguration(ServiceAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
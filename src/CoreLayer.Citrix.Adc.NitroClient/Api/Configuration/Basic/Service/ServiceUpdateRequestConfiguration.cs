using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/service";
        public override INitroRequestOptions Options => new ServiceUpdateRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public ServiceUpdateRequestConfiguration(ServiceUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
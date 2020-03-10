using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/servicegroup";
        public override INitroRequestOptions Options => new ServicegroupUpdateRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public ServicegroupUpdateRequestConfiguration(ServicegroupUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
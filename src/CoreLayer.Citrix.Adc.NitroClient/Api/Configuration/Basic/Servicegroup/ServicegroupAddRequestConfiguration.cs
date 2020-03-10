using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/servicegroup";
        public override INitroRequestOptions Options => new ServicegroupAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get;  }
        
        public ServicegroupAddRequestConfiguration(ServicegroupAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
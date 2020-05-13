using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBindings
{
    public class ServicegroupBindingsGetResponse : NitroResponse
    {
        public ServicegroupBindingsConfiguration[] ServicegroupBindings { get; set; }
    }
}
using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBindings
{
    public class ServiceBindingsGetResponse : NitroResponse
    {
        [JsonPropertyName("svcbindings")]
        public ServiceBindingsConfiguration[] ServiceBindingsConfigurations { get; set; }
    }
}
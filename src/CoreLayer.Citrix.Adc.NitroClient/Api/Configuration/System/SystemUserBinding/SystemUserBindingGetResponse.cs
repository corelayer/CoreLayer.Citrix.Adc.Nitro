using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserBinding
{
    public class SystemUserBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("systemuser_binding")]
        public SystemUserBindingConfiguration[] SystemUserBindings { get; set; }
    }
}
using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUser
{
    public class SystemUserGetResponse : NitroResponse
    {
        [JsonPropertyName("systemuser")]
        public SystemUserConfiguration[] SystemUsers { get; set; }
    }
}
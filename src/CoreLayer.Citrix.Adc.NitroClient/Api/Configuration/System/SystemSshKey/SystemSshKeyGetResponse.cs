using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemSshKey
{
    public class SystemSshKeyGetResponse
    {
        [JsonPropertyName("systemsshkey")]
        public SystemSshKeyConfiguration[] SystemSshKeys { get; set; }
    }
}
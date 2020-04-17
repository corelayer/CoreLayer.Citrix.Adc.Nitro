using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup
{
    public class SystemBackupGetResponse
    {
        [JsonPropertyName("systembackup")]
        public SystemBackupConfiguration[] SystemBackups { get; set; }
    }
}
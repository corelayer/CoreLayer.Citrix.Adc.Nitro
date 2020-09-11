using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.DbsMonitors
{
    public class DbsMonitorsRestartRequestDataRoot : INitroRequestDataRoot
    {
        [JsonPropertyName("dbsmonitors")]public DbsMonitorsRestartRequestData DbsMonitors => new DbsMonitorsRestartRequestData();
    }
}
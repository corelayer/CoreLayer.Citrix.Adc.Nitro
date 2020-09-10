using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Reporting
{
    public class ReportingGetResponse : NitroResponse
    {
        [JsonPropertyName("reporting")]public ReportingConfiguration[] ReportingConfigurations { get; set; }
    }
}
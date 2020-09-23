using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditNsLogPolicyBinding
{
    public class CsvserverAuditNsLogPolicyBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("csvserver_auditnslogpolicy_binding")]
        public CsvserverAuditNsLogPolicyBindingConfiguration[] CsvserverAuditNsLogPolicyBindingConfigurations { get; set; }
    }
}
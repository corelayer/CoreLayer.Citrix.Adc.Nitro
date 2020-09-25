using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching.CsvserverBinding;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditSysLogPolicyBinding
{
    public class CsvserverAuditSysLogPolicyBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("csvserver_auditsyslogpolicy_binding")]
        public CsvserverAuditSysLogPolicyBindingConfiguration[] CsvserverAuditSysLogPolicyBindingConfigurations { get; set; }
    }
}
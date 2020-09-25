using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditSysLogPolicyBinding
{
    public class CsvserverAuditSysLogPolicyBindingRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/csvserver_auditsyslogpolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsvserverAuditSysLogPolicyBindingRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverAuditSysLogPolicyBindingRemoveRequestOptions();
    }
}
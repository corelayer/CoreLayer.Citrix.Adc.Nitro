using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditSysLogPolicyBinding
{
    public class CsvserverAuditSysLogPolicyBindingAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/csvserver_auditsyslogpolicy_binding";
        public override INitroRequestOptions Options => new CsvserverAuditSysLogPolicyBindingAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsvserverAuditSysLogPolicyBindingAddRequestConfiguration(CsvserverAuditSysLogPolicyBindingAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
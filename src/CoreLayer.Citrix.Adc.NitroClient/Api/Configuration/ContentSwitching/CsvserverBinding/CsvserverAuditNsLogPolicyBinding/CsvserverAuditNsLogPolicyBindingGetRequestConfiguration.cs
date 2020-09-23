using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditNsLogPolicyBinding
{
    public class CsvserverAuditNsLogPolicyBindingGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/csvserver_auditnslogpolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsvserverAuditNsLogPolicyBindingGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverAuditNsLogPolicyBindingGetRequestOptions();
    }
}
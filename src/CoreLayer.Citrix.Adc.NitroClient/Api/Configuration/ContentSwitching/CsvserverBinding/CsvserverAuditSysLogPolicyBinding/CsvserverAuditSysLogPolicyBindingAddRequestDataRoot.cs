using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditSysLogPolicyBinding
{
    public class CsvserverAuditSysLogPolicyBindingAddRequestDataRoot : INitroRequestDataRoot
    {
        public CsvserverAuditSysLogPolicyBindingAddRequestDataRoot(dynamic data)
        {
            Csvserver_AuditSysLogPolicy_Binding = new dynamic[]{data};
        }

        public CsvserverAuditSysLogPolicyBindingAddRequestDataRoot(dynamic[] data)
        {
            Csvserver_AuditSysLogPolicy_Binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Csvserver_AuditSysLogPolicy_Binding { get; set; }
    }
}
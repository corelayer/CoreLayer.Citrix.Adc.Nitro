using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditNsLogPolicyBinding
{
    public class CsvserverAuditNsLogPolicyBindingAddRequestDataRoot : INitroRequestDataRoot
    {
        public CsvserverAuditNsLogPolicyBindingAddRequestDataRoot(dynamic data)
        {
            Csvserver_AuditNsLogPolicy_Binding = new dynamic[]{data};
        }

        public CsvserverAuditNsLogPolicyBindingAddRequestDataRoot(dynamic[] data)
        {
            Csvserver_AuditNsLogPolicy_Binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Csvserver_AuditNsLogPolicy_Binding { get; set; }
    }
}
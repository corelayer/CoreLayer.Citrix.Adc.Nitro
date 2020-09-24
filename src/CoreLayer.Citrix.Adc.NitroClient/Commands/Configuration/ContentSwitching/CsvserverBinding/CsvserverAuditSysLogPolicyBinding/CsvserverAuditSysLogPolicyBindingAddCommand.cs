using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditSysLogPolicyBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditSysLogPolicyBinding
{
    public class CsvserverAuditSysLogPolicyBindingAddCommand : NitroCommand<CsvserverAuditSysLogPolicyBindingAddResponse>
    {
        public CsvserverAuditSysLogPolicyBindingAddCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            : base(serviceClient, requestConfiguration) { }
    }
}
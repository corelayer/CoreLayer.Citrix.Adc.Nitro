using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding
{
    public class CsvserverAuthorizationPolicyBindingGetCommand : NitroCommand<CsvserverAuthorizationPolicyBindingGetResponse>
    {
        public CsvserverAuthorizationPolicyBindingGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            : base(serviceClient, requestConfiguration) { }
    }
}
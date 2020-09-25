using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppQoePolicyBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppQoePolicyBinding
{
    public class CsvserverAppQoePolicyBindingRemoveCommand : NitroCommand<CsvserverAppQoePolicyBindingRemoveResponse>
    {
        public CsvserverAppQoePolicyBindingRemoveCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            : base(serviceClient, requestConfiguration) { }
    }
}
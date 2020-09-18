using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsvserverBinding.CsvserverCsPolicyBinding
{
    public class CsvserverBindingAddCsPolicyCommand : NitroCommand<CsvserverBindingAddResponse>
    {
        public CsvserverBindingAddCsPolicyCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            : base(serviceClient, requestConfiguration) { }
    }
}
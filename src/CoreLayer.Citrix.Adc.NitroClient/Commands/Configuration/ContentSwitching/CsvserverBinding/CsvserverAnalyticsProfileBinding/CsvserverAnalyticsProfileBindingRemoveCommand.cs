using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAnalyticsProfileBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsvserverBinding.CsvserverAnalyticsProfileBinding
{
    public class CsvserverAnalyticsProfileBindingRemoveCommand : NitroCommand<CsvserverAnalyticsProfileBindingRemoveResponse>
    {
        public CsvserverAnalyticsProfileBindingRemoveCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            : base(serviceClient, requestConfiguration) { }
    }
}
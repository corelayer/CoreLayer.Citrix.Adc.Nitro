using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingAddCsPolicyCommand : NitroCommand<NitroResponse>
    {
        public CsvserverBindingAddCsPolicyCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration)
            : base(httpClient, requestConfiguration) { }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingRemoveCsPolicyCommand : NitroCommand
    {
        public CsvserverBindingRemoveCsPolicyCommand(INitroHttpClient httpClient,
            INitroRequestConfiguration requestConfiguration) : base(httpClient, requestConfiguration)
        {
            
        }
    }
}
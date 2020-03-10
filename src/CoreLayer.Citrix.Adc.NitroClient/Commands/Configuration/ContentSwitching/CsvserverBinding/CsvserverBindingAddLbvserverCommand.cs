using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingAddLbvserverCommand : NitroCommand
    {
        public CsvserverBindingAddLbvserverCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration)
            :base(httpClient, requestConfiguration) { }
    }
}
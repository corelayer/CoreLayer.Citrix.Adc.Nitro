using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverRemoveCommand : NitroCommand<CsvserverRemoveResponse>
    {
        public CsvserverRemoveCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}
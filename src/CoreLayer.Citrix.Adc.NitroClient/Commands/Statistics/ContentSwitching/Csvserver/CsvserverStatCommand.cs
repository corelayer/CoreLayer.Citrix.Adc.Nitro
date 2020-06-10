using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.ContentSwitching.Csvserver;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.ContentSwitching.Csvserver
{
    public class CsvserverStatCommand : NitroCommand<CsvserverStatResponse>
    {
        public CsvserverStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
                                               
        }
    }
}
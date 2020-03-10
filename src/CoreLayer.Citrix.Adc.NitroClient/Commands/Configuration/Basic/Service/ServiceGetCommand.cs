using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Service
{
    public class ServiceGetCommand : NitroCommand
    {
        public ServiceGetCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) 
            :base(httpClient, requestConfiguration) { }
    }
}
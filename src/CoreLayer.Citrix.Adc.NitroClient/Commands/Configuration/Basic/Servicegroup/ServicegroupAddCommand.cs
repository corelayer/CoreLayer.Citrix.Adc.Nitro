using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Servicegroup
{
    public class ServicegroupAddCommand : NitroCommand
    {
        public ServicegroupAddCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) 
            :base(httpClient, requestConfiguration) { }
    }
}
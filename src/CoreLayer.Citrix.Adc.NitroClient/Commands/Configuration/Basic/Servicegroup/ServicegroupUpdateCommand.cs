using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Servicegroup
{
    public class ServicegroupUpdateCommand : NitroCommand
    {
        public ServicegroupUpdateCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) :
            base(httpClient, requestConfiguration)
        {
            
        }
    }
}
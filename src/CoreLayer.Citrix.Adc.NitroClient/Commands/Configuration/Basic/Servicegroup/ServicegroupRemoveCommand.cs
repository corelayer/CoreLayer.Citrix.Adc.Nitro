using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Servicegroup
{
    public class ServicegroupRemoveCommand : NitroCommand
    {
        public ServicegroupRemoveCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) :
            base(httpClient, requestConfiguration) { }
    }
}
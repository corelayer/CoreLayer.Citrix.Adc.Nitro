using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Servicegroup
{
    public class ServicegroupGetCommand :NitroCommand
    {
        public ServicegroupGetCommand (INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration)
            :base(httpClient, requestConfiguration){}
    }
}
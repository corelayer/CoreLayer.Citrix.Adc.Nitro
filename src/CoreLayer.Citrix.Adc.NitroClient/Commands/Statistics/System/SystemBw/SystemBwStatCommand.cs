using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.System.SystemBw;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.System.SystemBw
{
    public class SystemBwStatCommand : NitroCommand<SystemBwStatResponse>
    {
        public SystemBwStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}
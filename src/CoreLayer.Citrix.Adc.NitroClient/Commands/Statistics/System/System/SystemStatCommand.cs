using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.System.System;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.System.System
{
    public class SystemStatCommand : NitroCommand<SystemStatResponse>
    {
        public SystemStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}
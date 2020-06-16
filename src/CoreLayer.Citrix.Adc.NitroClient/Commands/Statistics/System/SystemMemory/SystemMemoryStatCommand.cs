using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.System.SystemMemory;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.System.SystemMemory
{
    public class SystemMemoryStatCommand : NitroCommand<SystemMemoryStatResponse>
    {
        public SystemMemoryStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}
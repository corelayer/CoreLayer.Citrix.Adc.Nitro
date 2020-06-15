using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.System.SystemCpu;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.System.SystemCpu
{
    public class SystemCpuStatCommand : NitroCommand<SystemCpuStatResponse>
    {
        public SystemCpuStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}
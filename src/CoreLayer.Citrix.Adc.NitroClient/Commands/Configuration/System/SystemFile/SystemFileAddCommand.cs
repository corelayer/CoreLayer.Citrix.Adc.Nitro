using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemFile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemFile
{
    public class SystemFileAddCommand : NitroCommand<SystemFileAddResponse>
    {
        public SystemFileAddCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}
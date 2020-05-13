using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemFile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemFile
{
    public class SystemFileRemoveCommand : NitroCommand<SystemFileRemoveResponse>
    {
        public SystemFileRemoveCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}
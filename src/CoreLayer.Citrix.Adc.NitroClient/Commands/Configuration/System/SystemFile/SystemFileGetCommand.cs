using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemFile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemFile
{
    public class SystemFileGetCommand : NitroCommand<SystemFileGetResponse>
    {
        public SystemFileGetCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) : base(
            httpClient, requestConfiguration)
        {
            
        }
    }
}
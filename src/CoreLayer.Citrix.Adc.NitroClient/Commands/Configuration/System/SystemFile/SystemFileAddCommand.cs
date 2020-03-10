using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemFile
{
    public class SystemFileAddCommand : NitroCommand
    {
        public SystemFileAddCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) : base(
            httpClient, requestConfiguration)
        {
            
        }
    }
}
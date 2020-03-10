using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.NS.NsTcpProfile
{
    public class NsTcpProfileUpdateCommand : NitroCommand
    {
        public NsTcpProfileUpdateCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) :
            base(httpClient, requestConfiguration)
        {
            
        }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsTcpProfile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.NS.NsTcpProfile
{
    public class NsTcpProfileGetCommand : NitroCommand<NsTcpProfileGetResponse>
    {
        public NsTcpProfileGetCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) :
            base(httpClient, requestConfiguration)
        {
            
        }
    }
}
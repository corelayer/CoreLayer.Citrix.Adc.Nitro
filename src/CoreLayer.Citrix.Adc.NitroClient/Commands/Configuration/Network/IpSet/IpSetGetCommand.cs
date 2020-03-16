using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.IpSet;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Network.IpSet
{
    public class IpSetGetCommand : NitroCommand<IpSetGetResponse>
    {
        public IpSetGetCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) : base(
            httpClient, requestConfiguration)
        {
            
        }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.IpSet;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Network.IpSet
{
    public class IpSetAddCommand : NitroCommand<IpSetAddResponse>
    {
        public IpSetAddCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}
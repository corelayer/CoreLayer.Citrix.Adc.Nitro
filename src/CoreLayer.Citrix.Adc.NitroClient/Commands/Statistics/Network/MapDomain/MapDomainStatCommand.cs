using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.MapDomain;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.MapDomain
{
    public class MapDomainStatCommand : NitroCommand<MapDomainStatResponse>
    {
        public MapDomainStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}
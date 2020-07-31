using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.MapBmr;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.MapBmr
{
    public class MapBmrStatCommand : NitroCommand<MapBmrStatResponse>
    {
        public MapBmrStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}
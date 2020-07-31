using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.RNat6;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.RNat6
{
    public class RNat6StatCommand : NitroCommand<RNat6StatResponse>
    {
        public RNat6StatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}
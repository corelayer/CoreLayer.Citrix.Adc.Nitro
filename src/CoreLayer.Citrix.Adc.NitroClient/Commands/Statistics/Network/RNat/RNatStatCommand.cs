using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.RNat;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.RNat
{
    public class RNatStatCommand : NitroCommand<RNatStatResponse>
    {
        public RNatStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}
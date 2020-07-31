using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.Nat64;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Network.Nat64
{
    public class Nat64StatCommand : NitroCommand<Nat64StatResponse>
    {
        public Nat64StatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsPbr6;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ns.NsPbr6
{
    public class NsPbr6StatCommand : NitroCommand<NsPbr6StatResponse>
    {
        public NsPbr6StatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration) { }
    }
}
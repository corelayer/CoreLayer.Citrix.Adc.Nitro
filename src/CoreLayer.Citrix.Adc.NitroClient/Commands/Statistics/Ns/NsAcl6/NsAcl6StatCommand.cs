using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsAcl6;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ns.NsAcl6
{
    public class NsAcl6StatCommand : NitroCommand<NsAcl6StatResponse>
    {
        public NsAcl6StatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration) { }
    }
}
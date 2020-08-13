using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsSimpleAcl6;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ns.NsSimpleAcl6
{
    public class NsSimpleAcl6StatCommand : NitroCommand<NsSimpleAcl6StatResponse>
    {
        public NsSimpleAcl6StatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration) { }
    }
}
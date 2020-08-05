using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsSimpleAcl;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ns.NsSimpleAcl
{
    public class NsSimpleAclStatCommand : NitroCommand<NsSimpleAclStatResponse>
    {
        public NsSimpleAclStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration) { }
    }
}
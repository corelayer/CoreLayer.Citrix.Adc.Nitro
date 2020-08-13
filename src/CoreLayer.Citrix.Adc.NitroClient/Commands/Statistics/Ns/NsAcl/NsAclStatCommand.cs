using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsAcl;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ns.NsAcl
{
    public class NsAclStatCommand : NitroCommand<NsAclStatResponse>
    {
        public NsAclStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsTrafficDomain;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ns.NsTrafficDomain
{
    public class NsTrafficDomainStatCommand : NitroCommand<NsTrafficDomainStatResponse>
    {
        public NsTrafficDomainStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration) { }
    }
}
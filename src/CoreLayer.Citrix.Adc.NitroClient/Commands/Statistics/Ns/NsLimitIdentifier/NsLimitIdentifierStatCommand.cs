using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsLimitIdentifier;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ns.NsLimitIdentifier
{
    public class NsLimitIdentifierStatCommand : NitroCommand<NsLimitIdentifierStatResponse>
    {
        public NsLimitIdentifierStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration) { }
    }
}
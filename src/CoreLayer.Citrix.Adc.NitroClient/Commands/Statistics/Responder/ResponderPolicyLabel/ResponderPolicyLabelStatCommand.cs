using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Responder.ResponderPolicyLabel;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Responder.ResponderPolicyLabel
{
    public class ResponderPolicyLabelStatCommand : NitroCommand<ResponderPolicyLabelStatResponse>
    {
        public ResponderPolicyLabelStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Responder.ResponderPolicy;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Responder.ResponderPolicy
{
    public class ResponderPolicyStatCommand : NitroCommand<ResponderPolicyStatResponse>
    {
        public ResponderPolicyStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
        base(serviceClient, requestConfiguration) { }
    }
}
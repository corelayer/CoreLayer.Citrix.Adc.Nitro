using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMapBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Policy.PolicyStringMapBinding
{
    public class PolicyStringMapBindingRemoveCommand : NitroCommand<PolicyStringMapBindingRemoveResponse>
    {
        public PolicyStringMapBindingRemoveCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) 
            : base(serviceClient, requestConfiguration)
        {
            
        }
    }
}
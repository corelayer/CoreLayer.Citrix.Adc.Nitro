using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMapBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Policy.PolicyStringMapBinding
{
    public class PolicyStringMapBindingAddCommand : NitroCommand<PolicyStringMapBindingAddResponse>
    {
        public PolicyStringMapBindingAddCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) 
            : base(serviceClient, requestConfiguration)
        {
            
        }
    }
}
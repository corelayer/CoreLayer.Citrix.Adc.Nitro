using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Policy.PolicyStringMapBinding
{
    public class PolicyStringMapBindingAddCommand : NitroCommand<NitroResponse>
    {
        public PolicyStringMapBindingAddCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) 
            : base(serviceClient, requestConfiguration)
        {
            
        }
    }
}
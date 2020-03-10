using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Policy.PolicyStringMapBinding
{
    public class PolicyStringMapBindingAddCommand : NitroCommand
    {
        public PolicyStringMapBindingAddCommand(INitroHttpClient httpClient,
            INitroRequestConfiguration requestConfiguration) 
            : base(httpClient, requestConfiguration)
        {
            
        }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Policy.PolicyStringMapBinding
{
    public class PolicyStringMapBindingGetCommand : NitroCommand<NitroResponse>
    {
        public PolicyStringMapBindingGetCommand(
            INitroServiceClient serviceClient, 
            INitroRequestConfiguration configuration) :
            base(serviceClient, configuration)
        { }
    }
}
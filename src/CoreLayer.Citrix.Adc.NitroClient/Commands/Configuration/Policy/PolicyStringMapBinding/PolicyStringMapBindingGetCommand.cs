using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Policy.PolicyStringMapBinding
{
    public class PolicyStringMapBindingGetCommand : NitroCommand<NitroResponse>
    {
        public PolicyStringMapBindingGetCommand(
            INitroHttpClient httpClient, 
            INitroRequestConfiguration configuration) :
            base(httpClient, configuration)
        { }
    }
}
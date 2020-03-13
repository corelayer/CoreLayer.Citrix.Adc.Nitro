using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMapPatternBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Policy.PolicyStringMapPatternBinding
{
    public class PolicyStringMapPatternBindingGetCommand : NitroCommand<PolicyStringMapPatternBindingGetResponse>
    {
        public PolicyStringMapPatternBindingGetCommand(INitroHttpClient httpClient,
            INitroRequestConfiguration requestConfiguration) : base(httpClient, requestConfiguration)
        {
            
        }
    }
}
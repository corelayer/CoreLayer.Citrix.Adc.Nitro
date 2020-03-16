using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Policy.PolicyStringMap
{
    public class PolicyStringMapGetCommand : NitroCommand<NitroResponse>
    {
        public PolicyStringMapGetCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration)
            :base(httpClient, requestConfiguration) {}
    }
}
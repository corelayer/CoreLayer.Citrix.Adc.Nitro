using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabelBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsPolicyLabelBinding
{
    public class CsPolicyLabelBindingCsPolicyGetCommand : NitroCommand<CsPolicyLabelBindingCsPolicyGetResponse>
    {
        public CsPolicyLabelBindingCsPolicyGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}
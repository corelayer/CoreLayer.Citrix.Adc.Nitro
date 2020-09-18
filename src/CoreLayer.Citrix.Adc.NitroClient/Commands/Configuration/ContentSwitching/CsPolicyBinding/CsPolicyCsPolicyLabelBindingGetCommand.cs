using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyCsPolicyLabelBindingGetCommand : NitroCommand<CsPolicyCsPolicyLabelBindingGetResponse>
    {
        public CsPolicyCsPolicyLabelBindingGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabel;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsPolicyLabel
{
    public class CsPolicyLabelRemoveCommand : NitroCommand<CsPolicyLabelRemoveResponse>
    {
        public CsPolicyLabelRemoveCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}
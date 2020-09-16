using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyUnsetCommand : NitroCommand<CsPolicyUnsetResponse>
    {
        public CspolicyUnsetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsParameter;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsParameter
{
    public class CsParameterUpdateCommand : NitroCommand<CsParameterUpdateResponse>
    {
        public CsParameterUpdateCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}
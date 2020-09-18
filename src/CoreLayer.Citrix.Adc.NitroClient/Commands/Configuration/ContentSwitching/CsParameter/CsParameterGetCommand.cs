using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsParameter;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsParameter
{
    public class CsParameterGetCommand : NitroCommand<CsParameterGetResponse>
    {
        public CsParameterGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}
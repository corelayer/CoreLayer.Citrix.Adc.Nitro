using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsParameter
{
    public class CsParameterUnsetRequestDataRoot : INitroRequestDataRoot
    {
        public CsParameterUnsetRequestDataRoot(dynamic data)
        {
            CsParameter = data;
        }
        
        public dynamic CsParameter { get; set; }
    }
}
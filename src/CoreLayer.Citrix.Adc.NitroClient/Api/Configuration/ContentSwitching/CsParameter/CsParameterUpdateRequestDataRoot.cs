using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsParameter
{
    public class CsParameterUpdateRequestDataRoot : INitroRequestDataRoot
    {
        public CsParameterUpdateRequestDataRoot(dynamic data)
        {
            CsParameter = data;
        }
        
        public dynamic CsParameter { get; set; }
    }
}
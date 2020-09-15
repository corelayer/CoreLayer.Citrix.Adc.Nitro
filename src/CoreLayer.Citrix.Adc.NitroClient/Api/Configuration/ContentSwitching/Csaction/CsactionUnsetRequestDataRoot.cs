using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionUnsetRequestDataRoot : INitroRequestDataRoot
    {
        public CsactionUnsetRequestDataRoot(dynamic data)
        {
            Csaction = data;
        }
        
        public dynamic Csaction { get; set; }
    }
}
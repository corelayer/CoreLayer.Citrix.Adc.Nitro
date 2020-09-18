using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyUnsetRequestDataRoot : INitroRequestDataRoot
    {
        public CspolicyUnsetRequestDataRoot(dynamic data)
        {
            Cspolicy = data;
        }
        
        public dynamic Cspolicy { get; set; }
    }
}
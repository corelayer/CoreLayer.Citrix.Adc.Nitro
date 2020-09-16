using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyRenameRequestDataRoot : INitroRequestDataRoot
    {
        public CspolicyRenameRequestDataRoot(dynamic data)
        {
            Cspolicy = data;
        }
        
        public dynamic Cspolicy { get; set; }
    }
}
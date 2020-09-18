using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabel
{
    public class CsPolicyLabelRenameRequestDataRoot : INitroRequestDataRoot
    {
        public CsPolicyLabelRenameRequestDataRoot(dynamic data)
        {
            CsPolicyLabel = data;
        }
        
        public dynamic CsPolicyLabel { get; set; }
    }
}
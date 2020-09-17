using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabel
{
    public class CsPolicyLabelAddRequestDataRoot : INitroRequestDataRoot
    {
        public CsPolicyLabelAddRequestDataRoot(dynamic data)
        {
            CsPolicyLabel = new dynamic[]{data};
        }

        public CsPolicyLabelAddRequestDataRoot(dynamic[] data)
        {
            CsPolicyLabel = data;
        }
        
        public dynamic[] CsPolicyLabel { get; set; }
    }
}
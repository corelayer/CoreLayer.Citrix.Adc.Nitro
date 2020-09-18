using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabelBinding
{
    public class CsPolicyLabelBindingCsPolicyAddRequestDataRoot : INitroRequestDataRoot
    {
        public CsPolicyLabelBindingCsPolicyAddRequestDataRoot(dynamic data)
        {
            CsPolicyLabel_CsPolicy_Binding = new dynamic[]{data};
        }

        public CsPolicyLabelBindingCsPolicyAddRequestDataRoot(dynamic[] data)
        {
            CsPolicyLabel_CsPolicy_Binding = data;
        }
        
        public dynamic[] CsPolicyLabel_CsPolicy_Binding { get; set; }
    }
}
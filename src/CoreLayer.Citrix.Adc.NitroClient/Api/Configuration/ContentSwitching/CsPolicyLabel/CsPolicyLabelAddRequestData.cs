using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabel
{
    public class CsPolicyLabelAddRequestData : INitroRequestData
    {
        public string LabelName { get; set; }
        public string CsPolicyLabelType { get; set; }
    }
}
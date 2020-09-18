using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabel
{
    public class CsPolicyLabelRenameRequestData : INitroRequestData
    {
        public string LabelName { get; set; }
        public string NewName { get; set; }
    }
}
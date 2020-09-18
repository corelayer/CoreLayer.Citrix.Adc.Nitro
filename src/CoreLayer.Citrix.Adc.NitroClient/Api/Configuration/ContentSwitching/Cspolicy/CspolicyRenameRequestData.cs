using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyRenameRequestData : INitroRequestData
    {
        public string Name { get; set; }
        public string NewName { get; set; }
    }
}
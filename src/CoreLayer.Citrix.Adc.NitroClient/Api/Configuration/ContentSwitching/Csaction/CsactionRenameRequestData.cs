using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionRenameRequestData : INitroRequestData
    {
        public string Name { get; set; }
        public string NewName { get; set; }
    }
}
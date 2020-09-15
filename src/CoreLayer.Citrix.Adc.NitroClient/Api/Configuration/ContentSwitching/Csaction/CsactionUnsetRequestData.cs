using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionUnsetRequestData : INitroRequestData
    {
        public string Name { get; set; }
        public bool Comment = true;
    }
}
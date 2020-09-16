using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyUnsetRequestData : INitroRequestData
    {
        public string Name { get; set; }
        public bool? LogAction { get; set; }
        public bool? Url { get; set; }
        public bool? Rule { get; set; }
        public bool? Domain { get; set; }
    }
}
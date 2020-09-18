using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsParameter
{
    public class CsParameterUpdateRequestData : INitroRequestData
    {
        public string StateUpdate { get; set; }
    }
}
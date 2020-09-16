using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsParameter
{
    public class CsParameterUnsetRequestData : INitroRequestData
    {
        public bool StateUpdate { get; } = true;
    }
}
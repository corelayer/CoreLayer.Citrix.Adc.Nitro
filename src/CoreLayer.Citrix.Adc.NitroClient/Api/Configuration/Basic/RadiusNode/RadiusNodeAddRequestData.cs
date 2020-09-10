using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.RadiusNode
{
    public class RadiusNodeAddRequestData : INitroRequestData
    {
        public string RadId { get; set; }
        public string NodePrefix { get; set; }
    }
}
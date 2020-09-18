using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.VServer
{
    public class VServerEnableRequestData : INitroRequestData
    {
        public string Name { get; set; }
    }
}
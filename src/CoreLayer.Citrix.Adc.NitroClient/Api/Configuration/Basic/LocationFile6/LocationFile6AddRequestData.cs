using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile6
{
    public class LocationFile6AddRequestData : INitroRequestData
    {
        public string LocationFile { get; set; }
        public string Format { get; set; }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile
{
    public class LocationFileAddRequestData : INitroRequestData
    {
        public string LocationFile { get; set; }
        public string Format { get; set; }
    }
}
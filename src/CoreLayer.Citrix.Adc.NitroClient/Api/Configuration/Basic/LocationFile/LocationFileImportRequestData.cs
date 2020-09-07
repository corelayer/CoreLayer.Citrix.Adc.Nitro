using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile
{
    public class LocationFileImportRequestData : INitroRequestData
    {
        public string LocationFile { get; set; }
        public string Src { get; set; }
    }
}
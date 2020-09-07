using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile
{
    public class LocationFileImportRequestDataRoot : INitroRequestDataRoot
    {
        public LocationFileImportRequestDataRoot(dynamic data)
        {
            LocationFile = new dynamic[] {data};
        }
        public LocationFileImportRequestDataRoot(dynamic[] data)
        {
            LocationFile = data;
        }
        public dynamic[] LocationFile { get; set; }
    }
}
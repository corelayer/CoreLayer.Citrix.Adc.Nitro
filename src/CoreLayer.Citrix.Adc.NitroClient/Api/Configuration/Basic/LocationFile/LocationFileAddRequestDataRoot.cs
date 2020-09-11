using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile
{
    public class LocationFileAddRequestDataRoot : INitroRequestDataRoot
    {
        public LocationFileAddRequestDataRoot(dynamic data)
        {
            LocationFile = new dynamic[] {data};
        }
        public LocationFileAddRequestDataRoot(dynamic[] data)
        {
            LocationFile = data;
        }
        public dynamic[] LocationFile { get; set; }
    }
}
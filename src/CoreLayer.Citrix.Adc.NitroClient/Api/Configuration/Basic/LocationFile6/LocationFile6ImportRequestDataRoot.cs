using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile6
{
    public class LocationFile6ImportRequestDataRoot : INitroRequestDataRoot
    {
        public LocationFile6ImportRequestDataRoot(dynamic data)
        {
            LocationFile6 = new dynamic[] {data};
        }
        public LocationFile6ImportRequestDataRoot(dynamic[] data)
        {
            LocationFile6 = data;
        }
        public dynamic[] LocationFile6 { get; set; }
    }
}
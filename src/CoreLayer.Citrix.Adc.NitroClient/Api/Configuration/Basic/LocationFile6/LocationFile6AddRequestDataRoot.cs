using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile6
{
    public class LocationFile6AddRequestDataRoot : INitroRequestDataRoot
    {
        public LocationFile6AddRequestDataRoot(dynamic data)
        {
            LocationFile6 = new dynamic[] {data};
        }
        public LocationFile6AddRequestDataRoot(dynamic[] data)
        {
            LocationFile6 = data;
        }
        public dynamic[] LocationFile6 { get; set; }
    }
}
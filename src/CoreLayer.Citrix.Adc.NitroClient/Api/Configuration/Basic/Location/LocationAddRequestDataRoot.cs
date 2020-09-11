using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Location
{
    public class LocationAddRequestDataRoot : INitroRequestDataRoot
    {
        public LocationAddRequestDataRoot(dynamic data)
        {
            Location = new dynamic[] {data};
        }
        public LocationAddRequestDataRoot(dynamic[] data)
        {
            Location = data;
        }
        public dynamic[] Location { get; set; }
    }
}
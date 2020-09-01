using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Location
{
    public class LocationAddRequestData : INitroRequestData
    {
        public LocationAddRequestData(string ipFrom, string ipTo, string preferredLocation)
        {
            IpFrom = ipFrom;
            IpTo = ipTo;
            PreferredLocation = preferredLocation;

        }
        
        public string IpFrom { get; set; }
        public string IpTo { get; set; }
        public string PreferredLocation { get; set; }
        public int? Longitude { get; set; }
        public int? Latitude { get; set; }
        
    }
}
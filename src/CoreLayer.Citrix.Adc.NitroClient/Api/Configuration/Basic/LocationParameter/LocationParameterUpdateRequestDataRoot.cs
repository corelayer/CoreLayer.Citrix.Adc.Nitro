using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationParameter
{
    public class LocationParameterUpdateRequestDataRoot : INitroRequestDataRoot
    {
        public LocationParameterUpdateRequestDataRoot(dynamic data)
        {
            LocationParameter = new dynamic[] {data};
        }
        public LocationParameterUpdateRequestDataRoot(dynamic[] data)
        {
            LocationParameter = data;
        }
        public dynamic[] LocationParameter { get; set; }
    }
}
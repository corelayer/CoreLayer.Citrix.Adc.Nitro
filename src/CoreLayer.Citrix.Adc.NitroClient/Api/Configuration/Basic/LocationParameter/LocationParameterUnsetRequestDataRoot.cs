using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationParameter
{
    public class LocationParameterUnsetRequestDataRoot : INitroRequestDataRoot
    {
        public LocationParameterUnsetRequestDataRoot(dynamic data)
        {
            LocationParameter = data;
        }

        public dynamic LocationParameter { get; set; }
    }
}
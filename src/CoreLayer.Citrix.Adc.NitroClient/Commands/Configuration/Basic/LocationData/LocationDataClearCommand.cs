using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationData;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.LocationData
{
    public class LocationDataClearCommand : NitroCommand<LocationDataClearResponse>
    {
        public LocationDataClearCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}
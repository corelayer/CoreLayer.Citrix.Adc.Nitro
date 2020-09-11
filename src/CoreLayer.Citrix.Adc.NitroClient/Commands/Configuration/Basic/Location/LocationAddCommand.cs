using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Location;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Location
{
    public class LocationAddCommand : NitroCommand<LocationAddResponse>
    {
        public LocationAddCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}
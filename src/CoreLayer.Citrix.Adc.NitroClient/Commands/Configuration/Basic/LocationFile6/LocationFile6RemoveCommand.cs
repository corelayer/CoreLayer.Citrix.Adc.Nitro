using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile6;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.LocationFile6
{
    public class LocationFile6RemoveCommand : NitroCommand<LocationFile6RemoveResponse>
    {
        public LocationFile6RemoveCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}
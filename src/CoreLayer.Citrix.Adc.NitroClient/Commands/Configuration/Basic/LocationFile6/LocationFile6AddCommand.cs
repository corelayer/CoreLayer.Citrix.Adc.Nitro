using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile6;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.LocationFile6
{
    public class LocationFile6AddCommand : NitroCommand<LocationFile6AddResponse>
    {
        public LocationFile6AddCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}
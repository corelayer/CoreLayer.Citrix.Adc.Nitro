using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.LocationFile
{
    public class LocationFileAddCommand : NitroCommand<LocationFileAddResponse>
    {
        public LocationFileAddCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.LocationFile
{
    public class LocationFileRemoveCommand : NitroCommand<LocationFileRemoveResponse>
    {
        public LocationFileRemoveCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}
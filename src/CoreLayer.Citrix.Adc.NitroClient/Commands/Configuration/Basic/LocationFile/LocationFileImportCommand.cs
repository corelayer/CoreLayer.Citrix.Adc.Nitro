using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.LocationFile
{
    public class LocationFileImportCommand : NitroCommand<LocationFileImportResponse>
    {
        public LocationFileImportCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}
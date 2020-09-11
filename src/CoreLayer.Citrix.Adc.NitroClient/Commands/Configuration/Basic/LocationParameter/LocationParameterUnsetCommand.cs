using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationParameter;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.LocationParameter
{
    public class LocationParameterUnsetCommand : NitroCommand<LocationParameterUnsetResponse>
    {
        public LocationParameterUnsetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}
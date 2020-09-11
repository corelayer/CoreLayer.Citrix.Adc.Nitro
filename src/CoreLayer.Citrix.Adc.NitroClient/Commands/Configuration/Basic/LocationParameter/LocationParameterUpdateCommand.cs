using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationParameter;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.LocationParameter
{
    public class LocationParameterUpdateCommand : NitroCommand<LocationParameterUpdateResponse>
    {
        public LocationParameterUpdateCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}
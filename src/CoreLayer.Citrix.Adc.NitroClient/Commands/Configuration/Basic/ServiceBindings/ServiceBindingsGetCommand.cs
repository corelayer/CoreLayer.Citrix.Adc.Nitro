using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBindings;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServiceBindings
{
    public class ServiceBindingsGetCommand : NitroCommand<ServiceBindingsGetResponse>
    {
        public ServiceBindingsGetCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(serviceClient, requestConfiguration)
        {
            
        }
    }
}
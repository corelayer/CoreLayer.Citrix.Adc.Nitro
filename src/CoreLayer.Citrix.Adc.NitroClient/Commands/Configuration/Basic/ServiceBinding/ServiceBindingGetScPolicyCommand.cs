using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingGetScPolicyCommand : NitroCommand<ServiceBindingGetScPolicyResponse>
    {
        public ServiceBindingGetScPolicyCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(serviceClient, requestConfiguration)
        {
            
        }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ica.IcaPolicy;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Ica.IcaPolicy
{
    public class IcaPolicyStatCommand : NitroCommand<IcaPolicyStatResponse>
    {
        public IcaPolicyStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Dns.DnsPolicyLabel;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Dns.DnsPolicyLabel
{
    public class DnsPolicyLabelStatCommand : NitroCommand<DnsPolicyLabelStatResponse>
    {
        public DnsPolicyLabelStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}
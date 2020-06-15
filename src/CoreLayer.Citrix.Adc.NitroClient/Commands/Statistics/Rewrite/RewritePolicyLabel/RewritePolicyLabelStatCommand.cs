using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Rewrite.RewritePolicyLabel;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Rewrite.RewritePolicyLabel
{
    public class RewritePolicyLabelStatCommand : NitroCommand<RewritePolicyLabelStatResponse>
    {
        public RewritePolicyLabelStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}
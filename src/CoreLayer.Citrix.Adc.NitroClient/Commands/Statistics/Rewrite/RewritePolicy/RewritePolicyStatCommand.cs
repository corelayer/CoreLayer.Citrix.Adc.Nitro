using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Rewrite.RewritePolicy;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Rewrite.RewritePolicy
{
    public class RewritePolicyStatCommand : NitroCommand<RewritePolicyStatResponse>
    {
        public RewritePolicyStatCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : 
            base(serviceClient, requestConfiguration) { }
    }
}
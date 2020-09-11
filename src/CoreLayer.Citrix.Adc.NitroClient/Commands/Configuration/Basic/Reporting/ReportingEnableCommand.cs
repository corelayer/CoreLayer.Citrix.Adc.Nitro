using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Reporting;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Reporting
{
    public class ReportingEnableCommand : NitroCommand<ReportingEnableResponse>
    {
        public ReportingEnableCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}
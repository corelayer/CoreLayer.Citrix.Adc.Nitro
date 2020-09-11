using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Reporting;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Reporting
{
    public class ReportingDisableCommand : NitroCommand<ReportingDisableResponse>
    {
        public ReportingDisableCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}
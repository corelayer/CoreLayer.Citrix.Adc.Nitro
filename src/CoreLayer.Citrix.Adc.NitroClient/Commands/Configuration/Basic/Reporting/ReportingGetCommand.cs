using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Reporting;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Reporting
{
    public class ReportingGetCommand : NitroCommand<ReportingGetResponse>
    {
        public ReportingGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}
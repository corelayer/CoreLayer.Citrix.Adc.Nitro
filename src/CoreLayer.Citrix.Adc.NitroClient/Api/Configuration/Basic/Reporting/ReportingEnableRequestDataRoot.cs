using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Reporting
{
    public class ReportingEnableRequestDataRoot : INitroRequestDataRoot
    {
        public ReportingEnableRequestData Reporting => new ReportingEnableRequestData();
    }
}
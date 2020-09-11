using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Reporting
{
    public class ReportingDisableRequestDataRoot : INitroRequestDataRoot
    {
        public ReportingDisableRequestData Reporting => new ReportingDisableRequestData();
    }
}
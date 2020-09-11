using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Reporting
{
    public class ReportingEnableRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/reporting";
        public override INitroRequestDataRoot DataRoot => new ReportingEnableRequestDataRoot();
        public override INitroRequestOptions Options => new ReportingEnableRequestOptions(){Action = "enable"};
        
        public ReportingEnableRequestConfiguration()
        {
            
        }
    }
}
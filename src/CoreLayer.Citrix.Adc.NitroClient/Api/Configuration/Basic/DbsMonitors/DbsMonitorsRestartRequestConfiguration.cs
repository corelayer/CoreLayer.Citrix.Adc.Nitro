using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.DbsMonitors
{
    public class DbsMonitorsRestartRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/dbsmonitors";
        public override INitroRequestDataRoot DataRoot => new DbsMonitorsRestartRequestDataRoot(); 
        public override INitroRequestOptions Options => new DbsMonitorsRestartRequestOptions(){Action = "restart"};
                
        public DbsMonitorsRestartRequestConfiguration()
        {
            
        }
    }
}
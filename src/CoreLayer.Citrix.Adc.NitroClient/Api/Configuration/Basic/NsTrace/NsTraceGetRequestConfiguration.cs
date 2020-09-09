using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.NsTrace
{
    public class NsTraceGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/nstrace";
        public override INitroRequestDataRoot DataRoot => new NsTraceGetRequestDataRoot(); 
        public override INitroRequestOptions Options { get; set; } = new NsTraceGetRequestOptions();
                
        public NsTraceGetRequestConfiguration()
        {
            
        }
    }
}
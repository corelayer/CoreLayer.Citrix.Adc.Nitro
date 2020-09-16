using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsParameter
{
    public class CsParameterUnsetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/csparameter";
        public override INitroRequestDataRoot DataRoot { get; }
        public override INitroRequestOptions Options => new CsParameterUnsetRequestOptions(){Action = "unset"};
                
        public CsParameterUnsetRequestConfiguration(CsParameterUnsetRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}
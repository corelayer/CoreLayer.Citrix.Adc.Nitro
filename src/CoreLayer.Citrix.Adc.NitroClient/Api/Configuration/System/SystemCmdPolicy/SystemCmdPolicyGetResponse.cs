using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyGetResponse : NitroResponse
    {
        [JsonPropertyName("systemcmdpolicy")]
        public SystemCmdPolicyConfiguration[] SystemCmdPolicies { get; set; }
    }
}
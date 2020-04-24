﻿using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/systemuser_systemcmdpolicy_binding";
        public override INitroRequestDataRoot DataRoot => new SystemUserSystemCmdPolicyBindingGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new SystemUserSystemCmdPolicyBindingGetRequestOptions();
    }
}
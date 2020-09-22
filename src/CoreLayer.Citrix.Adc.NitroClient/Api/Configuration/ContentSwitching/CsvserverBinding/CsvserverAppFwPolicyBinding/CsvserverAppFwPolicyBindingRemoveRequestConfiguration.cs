﻿using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFwPolicyBinding
{
    public class CsvserverAppFwPolicyBindingRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/csvserver_appfwpolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsvserverAppFwPolicyBindingRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverAppFwPolicyBindingRemoveRequestOptions();
    }
}
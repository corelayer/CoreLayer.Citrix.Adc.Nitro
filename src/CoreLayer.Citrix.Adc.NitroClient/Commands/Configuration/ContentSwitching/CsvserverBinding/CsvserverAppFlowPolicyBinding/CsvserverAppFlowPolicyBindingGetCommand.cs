﻿using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFlowPolicyBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFlowPolicyBinding
{
    public class CsvserverAppFlowPolicyBindingGetCommand : NitroCommand<CsvserverAppFlowPolicyBindingGetResponse>
    {
        public CsvserverAppFlowPolicyBindingGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            : base(serviceClient, requestConfiguration) { }
    }
}
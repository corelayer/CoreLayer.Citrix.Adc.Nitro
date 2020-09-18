﻿using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsPolicyBinding
{
    public class CsPolicyCrvServerBindingGetCommand : NitroCommand<CsPolicyCrvServerBindingGetResponse>
    {
        public CsPolicyCrvServerBindingGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) : base(
            serviceClient, requestConfiguration)
        {
            
        }
    }
}
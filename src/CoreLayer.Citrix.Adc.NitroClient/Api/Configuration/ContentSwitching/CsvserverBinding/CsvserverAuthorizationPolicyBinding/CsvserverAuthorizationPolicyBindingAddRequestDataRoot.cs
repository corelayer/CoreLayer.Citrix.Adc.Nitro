using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding
{
    public class CsvserverAuthorizationPolicyBindingAddRequestDataRoot : INitroRequestDataRoot
    {
        public CsvserverAuthorizationPolicyBindingAddRequestDataRoot(dynamic data)
        {
            Csvserver_AuthorizationPolicy_Binding = new dynamic[]{data};
        }

        public CsvserverAuthorizationPolicyBindingAddRequestDataRoot(dynamic[] data)
        {
            Csvserver_AuthorizationPolicy_Binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Csvserver_AuthorizationPolicy_Binding { get; set; }
    }
}
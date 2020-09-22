using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFwPolicyBinding
{
    public class CsvserverAppFwPolicyBindingAddRequestDataRoot : INitroRequestDataRoot
    {
        public CsvserverAppFwPolicyBindingAddRequestDataRoot(dynamic data)
        {
            Csvserver_AppFwPolicy_Binding = new dynamic[]{data};
        }

        public CsvserverAppFwPolicyBindingAddRequestDataRoot(dynamic[] data)
        {
            Csvserver_AppFwPolicy_Binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Csvserver_AppFwPolicy_Binding { get; set; }
    }
}
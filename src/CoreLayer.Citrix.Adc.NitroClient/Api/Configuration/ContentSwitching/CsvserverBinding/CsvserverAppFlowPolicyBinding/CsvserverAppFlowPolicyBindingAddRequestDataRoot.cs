using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFlowPolicyBinding
{
    public class CsvserverAppFlowPolicyBindingAddRequestDataRoot : INitroRequestDataRoot
    {
        public CsvserverAppFlowPolicyBindingAddRequestDataRoot(dynamic data)
        {
            Csvserver_AppFlowPolicy_Binding = new dynamic[]{data};
        }

        public CsvserverAppFlowPolicyBindingAddRequestDataRoot(dynamic[] data)
        {
            Csvserver_AppFlowPolicy_Binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Csvserver_AppFlowPolicy_Binding { get; set; }
    }
}
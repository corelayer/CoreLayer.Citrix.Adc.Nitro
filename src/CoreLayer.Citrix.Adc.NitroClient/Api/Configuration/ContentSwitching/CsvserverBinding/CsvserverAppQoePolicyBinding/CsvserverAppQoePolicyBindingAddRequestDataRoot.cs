using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppQoePolicyBinding
{
    public class CsvserverAppQoePolicyBindingAddRequestDataRoot : INitroRequestDataRoot
    {
        public CsvserverAppQoePolicyBindingAddRequestDataRoot(dynamic data)
        {
            Csvserver_AppQoePolicy_Binding = new dynamic[]{data};
        }

        public CsvserverAppQoePolicyBindingAddRequestDataRoot(dynamic[] data)
        {
            Csvserver_AppQoePolicy_Binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Csvserver_AppQoePolicy_Binding { get; set; }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingAddCsPolicyRequestDataRoot : INitroRequestDataRoot
    {
        public CsvserverBindingAddCsPolicyRequestDataRoot(dynamic data)
        {
            Csvserver_CsPolicy_Binding = new dynamic[]{data};
        }

        public CsvserverBindingAddCsPolicyRequestDataRoot(dynamic[] data)
        {
            Csvserver_CsPolicy_Binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Csvserver_CsPolicy_Binding { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Csvserver_CsPolicy_Binding)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }  
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingAddLbvserverRequestDataRoot : INitroRequestDataRoot
    {
        public CsvserverBindingAddLbvserverRequestDataRoot(dynamic data)
        {
            Csvserver_Lbvserver_Binding = new dynamic[]{data};
        }

        public CsvserverBindingAddLbvserverRequestDataRoot(dynamic[] data)
        {
            Csvserver_Lbvserver_Binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Csvserver_Lbvserver_Binding { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Csvserver_Lbvserver_Binding)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }  
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingAddServiceRequestDataRoot : INitroRequestDataRoot
    {
        public LbvserverBindingAddServiceRequestDataRoot(dynamic data)
        {
            Lbvserver_Service_Binding = new dynamic[]{data};
        }

        public LbvserverBindingAddServiceRequestDataRoot(dynamic[] data)
        {
            Lbvserver_Service_Binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Lbvserver_Service_Binding { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Lbvserver_Service_Binding)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }  
    }
}
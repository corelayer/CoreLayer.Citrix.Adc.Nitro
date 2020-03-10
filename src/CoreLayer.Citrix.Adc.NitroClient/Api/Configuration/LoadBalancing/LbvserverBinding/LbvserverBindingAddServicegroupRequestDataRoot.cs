using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingAddServicegroupRequestDataRoot : INitroRequestDataRoot
    {
        public LbvserverBindingAddServicegroupRequestDataRoot(dynamic data)
        {
            Lbvserver_Servicegroup_Binding = new dynamic[]{data};
        }

        public LbvserverBindingAddServicegroupRequestDataRoot(dynamic[] data)
        {
            Lbvserver_Servicegroup_Binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Lbvserver_Servicegroup_Binding { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Lbvserver_Servicegroup_Binding)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }  
    }
}
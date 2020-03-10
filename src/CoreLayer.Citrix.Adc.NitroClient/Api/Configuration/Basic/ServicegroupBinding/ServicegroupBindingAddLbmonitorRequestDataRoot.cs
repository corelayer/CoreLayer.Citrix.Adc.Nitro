using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingAddLbmonitorRequestDataRoot : INitroRequestDataRoot
    {
        public ServicegroupBindingAddLbmonitorRequestDataRoot(dynamic data)
        {
            Servicegroup_lbmonitor_binding = new dynamic[]{data};
        }

        public ServicegroupBindingAddLbmonitorRequestDataRoot(dynamic[] data)
        {
            Servicegroup_lbmonitor_binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Servicegroup_lbmonitor_binding { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Servicegroup_lbmonitor_binding)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }  
    }
}
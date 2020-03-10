using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingAddLbmonitorRequestDataRoot : INitroRequestDataRoot
    {
        public ServiceBindingAddLbmonitorRequestDataRoot(dynamic data)
        {
            Service_lbmonitor_binding = new dynamic[]{data};
        }

        public ServiceBindingAddLbmonitorRequestDataRoot(dynamic[] data)
        {
            Service_lbmonitor_binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Service_lbmonitor_binding { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Service_lbmonitor_binding)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }  
    }
}
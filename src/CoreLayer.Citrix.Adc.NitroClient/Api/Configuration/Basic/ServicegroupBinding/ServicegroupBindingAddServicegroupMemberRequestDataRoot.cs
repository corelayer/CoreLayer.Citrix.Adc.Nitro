using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingAddServicegroupMemberRequestDataRoot : INitroRequestDataRoot
    {
        public ServicegroupBindingAddServicegroupMemberRequestDataRoot(dynamic data)
        {
            Servicegroup_ServicegroupMember_binding = new dynamic[]{data};
        }

        public ServicegroupBindingAddServicegroupMemberRequestDataRoot(dynamic[] data)
        {
            Servicegroup_ServicegroupMember_binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Servicegroup_ServicegroupMember_binding { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Servicegroup_ServicegroupMember_binding)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }  
    }
}
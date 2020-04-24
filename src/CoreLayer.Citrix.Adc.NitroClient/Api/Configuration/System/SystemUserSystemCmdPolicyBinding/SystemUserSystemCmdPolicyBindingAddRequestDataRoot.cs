using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingAddRequestDataRoot : INitroRequestDataRoot
    {
        public SystemUserSystemCmdPolicyBindingAddRequestDataRoot(dynamic data) 
        {
            SystemUser_SystemCmdPolicy_Binding = new dynamic[] {data};
        }
        public SystemUserSystemCmdPolicyBindingAddRequestDataRoot(dynamic[] data)
        {
            SystemUser_SystemCmdPolicy_Binding = data;
        }
        public dynamic[] SystemUser_SystemCmdPolicy_Binding { get; set; }
    }
}
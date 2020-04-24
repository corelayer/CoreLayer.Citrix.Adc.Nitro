using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingAddRequestData : INitroRequestData
    {
        public string UserName { get; set; }
        public string PolicyName { get; set; }
        public double? Priority { get; set; }
    }
}
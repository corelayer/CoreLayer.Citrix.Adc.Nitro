using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyAddRequestData : INitroRequestData
    {
        public SystemCmdPolicyAddRequestData(string policyName)
        {
            PolicyName = policyName;
        }
        public string PolicyName { get; }
        public string Action { get; set; }
        public string CmdSpec { get; set; }
        
    }
}
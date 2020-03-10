using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyUpdateRequestData : INitroRequestData
    {
        public string PolicyName { get; }

        public CspolicyUpdateRequestData(string policyName)
        {
            PolicyName = policyName;
        }
        
        public string Url { get; set; }
        public string Rule { get; set; }
        public string Domain { get; set; }
        public string Action { get; set; }
        public string LogAction { get; set; }
    }
}
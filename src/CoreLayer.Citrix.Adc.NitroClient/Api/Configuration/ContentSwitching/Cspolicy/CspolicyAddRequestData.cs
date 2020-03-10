using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyAddRequestData : INitroRequestData
    {
        public string PolicyName { get; }
        public string Url { get; set; }
        public string Rule { get; set; }
        public string Domain { get; set; }
        public string Action { get; set; }
        public string LogAction { get; set; }

        public CspolicyAddRequestData(string policyName)
        {
            PolicyName = policyName;
        }
    }
}
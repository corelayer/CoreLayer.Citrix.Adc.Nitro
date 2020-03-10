using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionAddRequestData : INitroRequestData
    {
        public string Name { get; }
        public string TargetLbvserver { get; set; }
        public string TargetVserver { get; set; }
        public string TargetVserverExpr { get; set; }
        public string Comment { get; set; }

        public CsactionAddRequestData(string actionName)
        {
            Name = actionName;
        }
    }
}
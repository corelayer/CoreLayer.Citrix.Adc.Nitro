using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionUpdateRequestData : INitroRequestData
    {
        public string Name { get; }

        public CsactionUpdateRequestData(string csActionName)
        {
            Name = csActionName;
        }
        
        public string TargetLbvserver { get; set; }
        public string TargetVserver { get; set; }
        public string TargetVserverExpr { get; set; }
        public string Comment { get; set; }
    }
}
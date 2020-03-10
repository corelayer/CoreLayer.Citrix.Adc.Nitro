using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionUpdateRequestDataRoot : INitroRequestDataRoot
    {
        public CsactionUpdateRequestDataRoot(dynamic data)
        {
            Csaction = new dynamic[]{data};
        }

        public CsactionUpdateRequestDataRoot(dynamic[] data)
        {
            Csaction = data;
        }
        
        public dynamic[] Csaction { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Csaction)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        } 
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyAddRequestDataRoot : INitroRequestDataRoot
    {
        public CspolicyAddRequestDataRoot(dynamic data)
        {
            Cspolicy = new dynamic[]{data};
        }

        public CspolicyAddRequestDataRoot(dynamic[] data)
        {
            Cspolicy = data;
        }
        
        public dynamic[] Cspolicy { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Cspolicy)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}
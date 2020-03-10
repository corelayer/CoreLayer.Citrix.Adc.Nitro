using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverAddRequestDataRoot : INitroRequestDataRoot
    {
        public CsvserverAddRequestDataRoot(dynamic data)
        {
            Csvserver = new dynamic[]{data};
        }

        public CsvserverAddRequestDataRoot(dynamic[] data)
        {
            Csvserver = data;
        }
        
        public dynamic[] Csvserver { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Csvserver)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        } 
    }
}
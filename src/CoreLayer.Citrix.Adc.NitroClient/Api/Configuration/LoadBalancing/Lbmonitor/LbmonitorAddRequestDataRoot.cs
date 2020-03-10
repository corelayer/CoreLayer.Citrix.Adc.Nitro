using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorAddRequestDataRoot : INitroRequestDataRoot
    {
        public LbmonitorAddRequestDataRoot(dynamic data)
        {
            Lbmonitor = new dynamic[]{data};
        }

        public LbmonitorAddRequestDataRoot(dynamic[] data)
        {
            Lbmonitor = data;
        }
        
        public dynamic[] Lbmonitor { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Lbmonitor)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}
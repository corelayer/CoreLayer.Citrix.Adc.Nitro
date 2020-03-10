using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverAddRequestDataRoot : INitroRequestDataRoot
    {
        public LbvserverAddRequestDataRoot(dynamic data)
        {
            Lbvserver = new dynamic[]{data};
        }

        public LbvserverAddRequestDataRoot(dynamic[] data)
        {
            Lbvserver = data;
        }
        
        public dynamic[] Lbvserver { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Lbvserver)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        } 
    }
}
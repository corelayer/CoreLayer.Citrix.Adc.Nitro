using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupAddRequestDataRoot : INitroRequestDataRoot
    {
        public ServicegroupAddRequestDataRoot(dynamic data)
        {
            Servicegroup = new dynamic[]{data};
        }

        public ServicegroupAddRequestDataRoot(dynamic[] data)
        {
            Servicegroup = data;
        }
        
        public dynamic[] Servicegroup { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Servicegroup)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}
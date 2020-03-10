using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceAddRequestDataRoot : INitroRequestDataRoot
    {
        public ServiceAddRequestDataRoot(dynamic data)
        {
            Service = new dynamic[]{data};
        }

        public ServiceAddRequestDataRoot(dynamic[] data)
        {
            Service = data;
        }
        
        public dynamic[] Service { get; set; }
        
        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Service)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}
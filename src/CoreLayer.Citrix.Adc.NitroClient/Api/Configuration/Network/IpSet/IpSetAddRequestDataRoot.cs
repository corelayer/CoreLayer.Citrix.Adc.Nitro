using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.IpSet
{
    public class IpSetAddRequestDataRoot : INitroRequestDataRoot
    {
        public IpSetAddRequestDataRoot(dynamic data)
        {
            IpSet = new dynamic[] {data};
        }
        public IpSetAddRequestDataRoot(dynamic[] data)
        {
            IpSet = data;
        }
        public dynamic[] IpSet { get; set; }

        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in IpSet)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}
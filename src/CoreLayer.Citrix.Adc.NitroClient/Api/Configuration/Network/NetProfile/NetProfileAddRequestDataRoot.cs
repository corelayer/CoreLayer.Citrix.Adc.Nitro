using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.NetProfile
{
    public class NetProfileAddRequestDataRoot : INitroRequestDataRoot
    {
        public NetProfileAddRequestDataRoot(dynamic data)
        {
            NetProfile = new dynamic[] {data};
        }
        public NetProfileAddRequestDataRoot(dynamic[] data)
        {
            NetProfile = data;
        }
        public dynamic[] NetProfile { get; set; }

        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in NetProfile)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}
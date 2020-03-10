using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsTcpProfile
{
    public class NsTcpProfileAddRequestDataRoot : INitroRequestDataRoot
    {
        public NsTcpProfileAddRequestDataRoot(dynamic data)
        {
            NsTcpProfile = new dynamic[] {data};
        }
        public NsTcpProfileAddRequestDataRoot(dynamic[] data)
        {
            NsTcpProfile = data;
        }
        public dynamic[] NsTcpProfile { get; set; }

        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in NsTcpProfile)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}
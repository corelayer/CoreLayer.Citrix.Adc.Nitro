using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsHttpProfile
{
    public class NsHttpProfileAddRequestDataRoot : INitroRequestDataRoot
    {
        public NsHttpProfileAddRequestDataRoot(dynamic data)
        {
            NsHttpProfile = new dynamic[] {data};
        }
        public NsHttpProfileAddRequestDataRoot(dynamic[] data)
        {
            NsHttpProfile = data;
        }
        public dynamic[] NsHttpProfile { get; set; }

        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in NsHttpProfile)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}
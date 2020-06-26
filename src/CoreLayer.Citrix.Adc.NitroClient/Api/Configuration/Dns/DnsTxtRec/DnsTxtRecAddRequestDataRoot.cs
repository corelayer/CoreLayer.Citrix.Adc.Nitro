using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsTxtRec
{
    public class DnsTxtRecAddRequestDataRoot : INitroRequestDataRoot
    {
        public DnsTxtRecAddRequestDataRoot(dynamic data)
        {
            DnsTxtRec = new dynamic[] {data};
        }
        public DnsTxtRecAddRequestDataRoot(dynamic[] data)
        {
            DnsTxtRec = data;
        }
        public dynamic[] DnsTxtRec { get; set; }

        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in DnsTxtRec)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}
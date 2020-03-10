using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemFile
{
    public class SystemFileAddRequestDataRoot : INitroRequestDataRoot
    {
        public SystemFileAddRequestDataRoot(dynamic data)
        {
            SystemFile = new dynamic[] {data};
        }
        public SystemFileAddRequestDataRoot(dynamic[] data)
        {
            SystemFile = data;
        }
        public dynamic[] SystemFile { get; set; }

        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in SystemFile)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}
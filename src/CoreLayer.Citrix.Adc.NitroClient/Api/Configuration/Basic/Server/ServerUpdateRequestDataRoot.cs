using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server
{
    public class ServerUpdateRequestDataRoot : INitroRequestDataRoot
    {
        public ServerUpdateRequestDataRoot(dynamic data)
        {
            Server = new dynamic[] {data};
        }
        public ServerUpdateRequestDataRoot(dynamic[] data)
        {
            Server = data;
        }
        public dynamic[] Server { get; set; }

        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in Server)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}
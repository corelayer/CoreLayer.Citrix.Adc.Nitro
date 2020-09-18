using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.VServer
{
    public class VServerUpdateRequestDataRoot : INitroRequestDataRoot
    {
        public VServerUpdateRequestDataRoot(dynamic data)
        {
            VServer = data;
        }
        
        public dynamic VServer { get; set; }
    }
}
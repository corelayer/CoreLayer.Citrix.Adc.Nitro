using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.VServer
{
    public class VServerEnableRequestDataRoot : INitroRequestDataRoot
    {
        public VServerEnableRequestDataRoot(dynamic data)
        {
            VServer = data;
        }
        
        public dynamic VServer { get; set; }
    }
}
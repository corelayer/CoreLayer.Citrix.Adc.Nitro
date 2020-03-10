using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Logout
{
    public class NitroLogoutRequestDataRoot : INitroRequestDataRoot
    {
        public NitroLogoutRequestDataRoot()
        {
            Logout = new NitroLogoutRequestData();
        }
        public NitroLogoutRequestDataRoot(INitroRequestData data)
        {
            Logout = new NitroLogoutRequestData();
        }
        
        public INitroLogoutRequestData Logout { get; set; }
    }
}
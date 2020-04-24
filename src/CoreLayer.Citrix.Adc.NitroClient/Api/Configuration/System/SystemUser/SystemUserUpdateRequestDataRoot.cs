using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUser
{
    public class SystemUserUpdateRequestDataRoot : INitroRequestDataRoot
    {
        public SystemUserUpdateRequestDataRoot(dynamic data)
        {
            SystemUser = new dynamic[] {data};
        }
        public SystemUserUpdateRequestDataRoot(dynamic[] data)
        {
            SystemUser = data;
        }
        public dynamic[] SystemUser { get; set; }
    }
}
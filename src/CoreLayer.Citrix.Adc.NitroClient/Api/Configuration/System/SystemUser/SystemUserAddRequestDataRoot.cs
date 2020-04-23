using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUser
{
    public class SystemUserAddRequestDataRoot : INitroRequestDataRoot
    {
        public SystemUserAddRequestDataRoot(dynamic data)
        {
            SystemUser = new dynamic[] {data};
        }
        public SystemUserAddRequestDataRoot(dynamic[] data)
        {
            SystemUser = data;
        }
        public dynamic[] SystemUser { get; set; }
    }
}
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUser
{
    public class SystemUserAddRequestData : INitroRequestData
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ExternalAuth { get; set; }
        public string PromptString { get; set; }
        public double? Timeout { get; set; }
        public string Logging { get; set; }
        public string MaxSession { get; set; }
        public string[] AllowedManagementInterface { get; set; }
    }
}
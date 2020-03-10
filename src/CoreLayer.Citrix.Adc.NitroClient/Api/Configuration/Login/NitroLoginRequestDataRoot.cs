using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login
{
    public class NitroLoginRequestDataRoot : INitroRequestDataRoot
    {
        public NitroLoginRequestDataRoot()
        {
            Login = new NitroLoginRequestData("nsroot", "nsroot");
        }
        public NitroLoginRequestDataRoot(NitroLoginRequestData data)
        {
            Login = data;
        }
        public INitroLoginRequestData Login { get; set; }
    }
}
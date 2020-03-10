using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login
{
    public interface INitroLoginRequestData : INitroRequestData
    {
        string Username { get; }
        string Password { get; }
        int Timeout { get; }
    }
}
using System;

namespace CoreLayer.Citrix.Adc.NitroClient.Interfaces
{
    public interface INitroServiceConnectionSettings
    {
        Uri BaseAddress { get; }
        int Timeout { get; }
        NitroServiceConnectionAuthenticationMethod AuthenticationMethod { get; }
    }
}
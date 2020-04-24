using System;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public class NitroServiceConnectionSettings : INitroServiceConnectionSettings
    {
        private readonly Uri _baseAddress;
        private readonly int _timeout;
        private readonly NitroServiceConnectionAuthenticationMethod _authenticationMethod;

        public NitroServiceConnectionSettings(
            Uri baseAddress,
            int timeout,
            NitroServiceConnectionAuthenticationMethod authenticationMethod)
        {
            _baseAddress = baseAddress;
            _timeout = timeout;
            _authenticationMethod = authenticationMethod;
        }

        public Uri BaseAddress => _baseAddress;
        public int Timeout => _timeout;
        public NitroServiceConnectionAuthenticationMethod AuthenticationMethod => _authenticationMethod;
    }
}
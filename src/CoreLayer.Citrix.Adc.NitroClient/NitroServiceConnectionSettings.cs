using System;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public class NitroServiceConnectionSettings : INitroServiceConnectionSettings
    {
        private readonly Uri _baseAddress;
        private readonly bool _validateServerCertificate;
        private readonly int _timeout;
        private readonly NitroServiceConnectionAuthenticationMethod _authenticationMethod;

        public NitroServiceConnectionSettings(
            Uri baseAddress, 
            bool validateServerCertificate, 
            int timeout,
            NitroServiceConnectionAuthenticationMethod authenticationMethod)
        {
            _baseAddress = baseAddress;
            _validateServerCertificate = validateServerCertificate;
            _timeout = timeout;
            _authenticationMethod = authenticationMethod;
        }

        public Uri BaseAddress => _baseAddress;
        public bool ValidateServerCertificate => _validateServerCertificate;
        public int Timeout => _timeout;
        public NitroServiceConnectionAuthenticationMethod AuthenticationMethod => _authenticationMethod;
    }
}
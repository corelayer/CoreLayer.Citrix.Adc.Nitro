using System;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public static class NitroServiceHttpClientGenerator
    {
        public static HttpClient Generate(INitroServiceConnectionSettings settings)
        {
            var httpClient = settings.ValidateServerCertificate
                ? new HttpClient(GetInSecureHttpMessageHandler(settings))
                : new HttpClient(GetSecureHttpMessageHandler(settings));
            httpClient.BaseAddress = settings.BaseAddress;
            httpClient.Timeout = TimeSpan.FromSeconds(settings.Timeout);

            return httpClient;
        }

        private static HttpClientHandler GetInSecureHttpMessageHandler(INitroServiceConnectionSettings settings)
        {
            return new HttpClientHandler
            {
                UseCookies = false,
                SslProtocols = SslProtocols.Tls12,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                ServerCertificateCustomValidationCallback = (req, cert, chain, errors) => true
            };
        }
        
        private static HttpClientHandler GetSecureHttpMessageHandler(INitroServiceConnectionSettings settings)
        {
            return new HttpClientHandler
            {
                UseCookies = false,
                SslProtocols = SslProtocols.Tls12,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            };
        }
    }
}
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login;
using CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Login;
using CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Logout;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public class NitroHttpClient : INitroHttpClient
    {
        private const string NitroTokenCookie = "NITRO_AUTH_TOKEN=";
        private readonly INitroLoginRequestData _credentials;
        private readonly INitroServiceConnectionSettings _settings;
        private readonly HttpClient _httpClient;

        public NitroHttpClient(
            INitroLoginRequestData credentials,
            INitroServiceConnectionSettings settings)
        {
            _credentials = credentials;
            _settings = settings;
            _httpClient = NitroServiceHttpClientGenerator.Generate(settings);

            var task = ConfigureAutomaticLogin();
            task.Wait();
        }

        private async Task ConfigureAutomaticLogin()
        {
            switch (_settings.AuthenticationMethod)
            {
                case NitroServiceConnectionAuthenticationMethod.AutomaticHeaderInjection:
                    ConfigureAuthenticationHeaders();
                    break;
                case NitroServiceConnectionAuthenticationMethod.AutomaticLogin:
                    await Login(new CancellationToken());
                    break;
            }
        }

        private void ConfigureAuthenticationHeaders()
        {
            _httpClient.DefaultRequestHeaders.Add("X-NITRO-USER", _credentials.Username);
            _httpClient.DefaultRequestHeaders.Add("X-NITRO-PASS", _credentials.Password);
        }

        private void ConfigureAuthenticationCookieHeader(string token)
        {
            _httpClient.DefaultRequestHeaders.Add("Cookie", NitroTokenCookie + token);
        }

        private bool IsLoggedIn()
        {
            while (true)
            {
                // Headers are automatically injected into the HttpClient for each request
                if (_settings.AuthenticationMethod == NitroServiceConnectionAuthenticationMethod.AutomaticHeaderInjection)
                    return true;

                // Login has been executed (either manually or automatically)
                // Cookie header is automatically injected into the HttpClient
                if (_httpClient.DefaultRequestHeaders.ToString().Contains("NITRO_AUTH_TOKEN")) 
                    return true;

                // Login has not been executed
                // Cookie header is not yet injected into the HttpClient
                if (_settings.AuthenticationMethod == NitroServiceConnectionAuthenticationMethod.ManualLogin)
                    return false;
            }
        }

        public async Task Login(CancellationToken cancellationToken)
        {
            try
            {
                var loginCommand = NitroCommandFactory.Create<NitroLoginCommand>(this, _credentials);
                var response = await loginCommand.ExecuteAsync(cancellationToken);
                if (!response.IsSuccessStatusCode)
                    throw new HttpRequestException("Could not log on.\n" + response);

                await using var contentStream = await response.Content.ReadAsStreamAsync();
                var content =
                    await JsonSerializer.DeserializeAsync<NitroLoginResponse>(
                        contentStream, 
                        NitroServiceSerializerOptions.JsonSerializerOptions
                    );
                    
                ConfigureAuthenticationCookieHeader(content.SessionId);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task Logout(CancellationToken cancellationToken)
        {
            if (!IsLoggedIn())
                return;
            
            try
            {
                //was var logoutCommand = NitroCommand.Create<NitroLogoutCommand>(this, new NitroLogoutData);
                var logoutCommand = NitroCommandFactory.Create<NitroLogoutCommand>(this);
                var response = await logoutCommand.ExecuteAsync(cancellationToken);

                if (!response.IsSuccessStatusCode)
                    throw new HttpRequestException("Could not log off.\n" + response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">The request is null.</exception>
        /// <exception cref="InvalidOperationException">The request message was already sent by the HttpClient instance.</exception>
        /// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout</exception>
        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return await _httpClient.SendAsync(request, cancellationToken);
        }
    }
}
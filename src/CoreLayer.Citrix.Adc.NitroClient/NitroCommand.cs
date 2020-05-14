using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;
using FluentValidation.Results;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public abstract class NitroCommand<T> : INitroCommand<T>
    {
        private readonly INitroServiceClient _serviceClient;
        private readonly INitroRequestConfiguration _request;
        protected NitroCommand() { }

        protected NitroCommand(INitroServiceClient serviceClient, INitroRequestConfiguration request)
        {
            _serviceClient = serviceClient;
            _request = request;
        }
       
        public INitroServiceClient ServiceClient {
            get => _serviceClient;
            //set { _client = value; }
        }
        public INitroRequestConfiguration Data {
            get => _request;
            //set { _request = value; }
    }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<ValidationResult> ValidateAsync(CancellationToken cancellationToken)
        {
            var validationResult = await Data.ValidateAsync().ConfigureAwait(false);
            
            if (!validationResult.IsValid)
                throw new ArgumentOutOfRangeException(
                    "request",
                    JsonSerializer.Serialize(validationResult.Errors)
                );

            return validationResult;
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">The request is null.</exception>
        /// <exception cref="InvalidOperationException">The request message was already sent by the HttpClient instance.</exception>
        /// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout</exception>
        public async Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            try
            {
                return await _serviceClient.SendAsync(
                    await _request.GenerateHttpRequestMessageAsync().ConfigureAwait(false),
                    cancellationToken).ConfigureAwait(false);
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            catch (InvalidOperationException ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="validateCommand"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> ExecuteAsync(
            bool validateCommand, 
            CancellationToken cancellationToken)
        {
            try
            {
                if (validateCommand)
                    await ValidateAsync(cancellationToken).ConfigureAwait(false);

                return await _serviceClient.SendAsync(
                    await _request.GenerateHttpRequestMessageAsync().ConfigureAwait(false),
                    cancellationToken).ConfigureAwait(false);
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            catch (InvalidOperationException ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                throw;
            }
        }
        
        public async Task<T> GetResponse()
        {
            string resultString = string.Empty;
            try
            {
                var result = await this.ExecuteAsync(new CancellationToken()).ConfigureAwait(false);
                //if (!result.Content.Headers.ContentLength.Value.Equals(0))
                //{
                await using var contentStream = await result.Content.ReadAsStreamAsync().ConfigureAwait(false);
                var reader = new StreamReader(contentStream);

                resultString = await reader.ReadToEndAsync().ConfigureAwait(false);
                //}
                var response = NitroRequestResponseDeserializer.GenerateObject<T>(
                    "{ \"statuscode\": \"" + result.StatusCode+ "\" }" );
                if (resultString != string.Empty)
                {
                    response = NitroRequestResponseDeserializer.GenerateObject<T>(resultString);
                }
                return (T)response;
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            catch (InvalidOperationException ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                throw;
            }
        }
    }
}

using System;
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
        
       

//        public static INitroCommand Create<T>(INitroServiceClient client, INitroRequestOptions requestOptions)
//        {
//            var targetConfigurationInstance = GetTargetConfigurationInstance(typeof(T));
//            targetConfigurationInstance.Options = requestOptions;
//
//            var targetCommand = (INitroCommand) Activator.CreateInstance(
//                typeof(T),
//                new object[]
//                {
//                    client,
//                    targetConfigurationInstance
//                });
//            return targetCommand;
//        }

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
            var validationResult = await Data.ValidateAsync();
            
            if (!validationResult.IsValid)
                throw new ArgumentOutOfRangeException(
                    "request",
                    JsonSerializer.Serialize(validationResult.Errors)
                );

            return validationResult;
        }
        
        public async Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
             return await _serviceClient.SendAsync(
                await _request.GenerateHttpRequestMessageAsync(),
                cancellationToken);
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
            if (validateCommand)
                await ValidateAsync(cancellationToken);

            return await _serviceClient.SendAsync(
                await _request.GenerateHttpRequestMessageAsync(),
                cancellationToken);
        }
        
        public async Task<T> GetResponse()
        {
            string resultString = "";
            var result = await this.ExecuteAsync(new CancellationToken());
            if (!result.Content.Headers.ContentLength.Value.Equals(0))
            {
                await using (var contentStream = await result.Content.ReadAsStreamAsync())
                {
                    var reader = new StreamReader(contentStream);
                
                    resultString = reader.ReadToEnd();
                }
            }
            

            
            var response = NitroRequestResponseDeserializer.GenerateObject<T>("{}" );
            if (resultString != string.Empty)
            {
                response= NitroRequestResponseDeserializer.GenerateObject<T>(resultString);
            }
            
            
            return (T)response;
        }
    }
}
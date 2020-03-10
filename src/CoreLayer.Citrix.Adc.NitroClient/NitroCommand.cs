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
    public abstract class NitroCommand : INitroCommand
    {
        private readonly INitroHttpClient _httpClient;
        private readonly INitroRequestConfiguration _request;
        protected NitroCommand() { }

        protected NitroCommand(INitroHttpClient httpClient, INitroRequestConfiguration request)
        {
            _httpClient = httpClient;
            _request = request;
        }
        
        private static string GetConfigurationApiNamespace(string commandNamespace)
        {
            return commandNamespace.Replace("Commands", "Api");
        }

        private static string GetConfigurationTypeName(string commandNamespace)
        {
            return commandNamespace.Replace("Command", "RequestConfiguration");
        }

        private static string GetConfigurationDataRootTypeName(string commandNamespace)
        {
            return commandNamespace.Replace("Command", "RequestDataRoot");
        }
        
        private static INitroRequestConfiguration GetTargetConfigurationInstance(Type type)
        {
            var requestNameSpace = GetConfigurationApiNamespace(type.Namespace);
            var targetConfigurationTypeName = GetConfigurationTypeName(type.Name);

            var targetConfigurationType = Type.GetType(requestNameSpace + "." + targetConfigurationTypeName);
            var targetConfigurationInstance = (INitroRequestConfiguration) Activator.CreateInstance(targetConfigurationType);

            return targetConfigurationInstance;
        }

        private static INitroRequestConfiguration GetTargetConfigurationInstance(Type type,
            INitroRequestDataRoot dataRoot)
        {
            var requestNameSpace = GetConfigurationApiNamespace(type.Namespace);
            var targetConfigurationTypeName = GetConfigurationTypeName(type.Name);

            var targetConfigurationType = Type.GetType(requestNameSpace + "." + targetConfigurationTypeName);
            var targetConfigurationInstance = (INitroRequestConfiguration) Activator.CreateInstance(targetConfigurationType, dataRoot);

            return targetConfigurationInstance;
        }

        private static INitroRequestDataRoot GetTargetConfigurationDataRootInstance(Type type, INitroRequestData data)
        {
            var requestNameSpace = GetConfigurationApiNamespace(type.Namespace);
            var targetRequestDataRootTypeName = GetConfigurationDataRootTypeName(type.Name);
            var targetRequestDataRootType =
                Type.GetType(requestNameSpace + "." + targetRequestDataRootTypeName);
            
            // TODO Exception handling
            var targetDataRootInstance = (INitroRequestDataRoot) Activator.CreateInstance(targetRequestDataRootType, new object[]{ data});

            return targetDataRootInstance;
        }

        private static INitroRequestDataRoot GetTargetConfigurationDataRootInstance(Type type, dynamic[] data)
        {
            var requestNameSpace = GetConfigurationApiNamespace(type.Namespace);
            var targetRequestDataRootTypeName = GetConfigurationDataRootTypeName(type.Name);
            var targetRequestDataRootType =
                Type.GetType(requestNameSpace + "." + targetRequestDataRootTypeName);
            
            // TODO Exception handling
            var targetDataRootInstance = (INitroRequestDataRoot) Activator.CreateInstance(targetRequestDataRootType, new object[]{ data});

            return targetDataRootInstance;
        }

        private static INitroCommand GetTargetCommandInstance(Type type, INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration)
        {
            return (INitroCommand) Activator.CreateInstance(type, new object[]{httpClient, requestConfiguration});
        }
        
        public static INitroCommand Create<T>(INitroHttpClient httpClient)
        {
            return GetTargetCommandInstance(
                typeof(T), 
                httpClient, 
                GetTargetConfigurationInstance(typeof(T)));
        }

        public static INitroCommand Create<T>(INitroHttpClient httpClient, INitroRequestOptions options)
        {
            var targetConfigurationInstance = GetTargetConfigurationInstance(typeof(T));
            targetConfigurationInstance.Options = options;

            return GetTargetCommandInstance(
                typeof(T),
                httpClient,
                targetConfigurationInstance);
        }

        public static INitroCommand Create<T>(INitroHttpClient httpClient, INitroRequestData data)
        {
            var targetDataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);
            var targetConfigurationInstance = GetTargetConfigurationInstance(typeof(T), targetDataRoot);
            //targetConfigurationInstance.DataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);

            return GetTargetCommandInstance(
                typeof(T),
                httpClient,
                targetConfigurationInstance);
        }

        public static INitroCommand Create<T>(INitroHttpClient httpClient, INitroRequestData[] dataList)
        {
            dynamic[] data = dataList.Cast<dynamic>().ToArray();
            var targetDataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);
            var targetConfigurationInstance = GetTargetConfigurationInstance(typeof(T), targetDataRoot);
            //targetConfigurationInstance.DataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);

            return GetTargetCommandInstance(
                typeof(T),
                httpClient,
                targetConfigurationInstance);
            
        }

        public static INitroCommand Create<T>(INitroHttpClient httpClient, INitroRequestData data, INitroRequestOptions options)
        {
            var targetDataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);
            var targetConfigurationInstance = GetTargetConfigurationInstance(typeof(T), targetDataRoot);
            targetConfigurationInstance.Options = options;
            
            //targetConfigurationInstance.DataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);

            return GetTargetCommandInstance(
                typeof(T),
                httpClient,
                targetConfigurationInstance);
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

        public INitroHttpClient HttpClient {
            get => _httpClient;
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
             return await _httpClient.SendAsync(
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

            return await _httpClient.SendAsync(
                await _request.GenerateHttpRequestMessageAsync(),
                cancellationToken);
        }
        
        public async Task<T> GetResponse<T>()
        {
            string resultString;
            var result = await this.ExecuteAsync(new CancellationToken());
            await using (var contentStream = await result.Content.ReadAsStreamAsync())
            {
                var reader = new StreamReader(contentStream);

                resultString = reader.ReadToEnd();
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
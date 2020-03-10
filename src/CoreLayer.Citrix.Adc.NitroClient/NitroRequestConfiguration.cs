using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;
using FluentValidation.Results;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public class NitroRequestConfiguration : INitroRequestConfiguration
    {
        public virtual HttpMethod Method => HttpMethod.Get;
        public MediaTypeHeaderValue ContentType => new MediaTypeHeaderValue("application/json");
        public virtual string ResourcePath => "/nitro/v1";
        public virtual INitroRequestOptions Options { get; set; } = new NitroRequestOptionsDefault();
        public virtual INitroRequestDataRoot DataRoot { get; } 

        protected NitroRequestConfiguration() { }
        
        public async Task<ValidationResult> ValidateAsync()
        {
            // Create Generic Type Instance based on current instance
            var T = GetType();
            // Create base type of NitroRequestConfigurationValidator<>
            var objectType = typeof(NitroRequestConfigurationValidator<>);
            
            // Make a combined generic type of NitroRequestConfigurationValidator<T>
            var genericType = objectType.MakeGenericType(T);
            var genericInstance = Activator.CreateInstance(genericType);
            
            // Get the required ValidateAsync method
            var validateMethod = genericInstance.GetType().GetMethods().Single(
                m =>
                    m.Name == "ValidateAsync" 
                    && m.GetParameters()[0].Name.Equals("instance"));

            // Invoke and await the method
            var task = (Task) validateMethod.Invoke(genericInstance, new []{this, null});
            await task.ConfigureAwait(false);

            // Cast the task into Task<ValidationResult>
            var result = (Task<ValidationResult>) task;
            return result.Result;
        }

        public async Task<HttpRequestMessage> GenerateHttpRequestMessageAsync()
        {
            return await NitroRequestConfigurationSerializer.GenerateHttpRequestMessageAsync(this);
        }
    }
}
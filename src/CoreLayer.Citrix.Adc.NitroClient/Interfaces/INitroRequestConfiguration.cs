using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace CoreLayer.Citrix.Adc.NitroClient.Interfaces
{
    public interface INitroRequestConfiguration
    {
        HttpMethod Method { get; }
        MediaTypeHeaderValue ContentType { get; }
        string ResourcePath { get; }
        INitroRequestOptions Options { get; set; }
        
        INitroRequestDataRoot DataRoot { get; }

        Task<ValidationResult> ValidateAsync();
        Task<HttpRequestMessage> GenerateHttpRequestMessageAsync();
    }
}
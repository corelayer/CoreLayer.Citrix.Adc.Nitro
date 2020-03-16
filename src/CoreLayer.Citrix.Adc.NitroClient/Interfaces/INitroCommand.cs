using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace CoreLayer.Citrix.Adc.NitroClient.Interfaces
{
    public interface INitroCommand <T>
    {
        INitroHttpClient HttpClient { get; }
        INitroRequestConfiguration Data { get; }
        Task<ValidationResult> ValidateAsync(CancellationToken cancellationToken);
        Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken);
        Task<T> GetResponse();
    }
}
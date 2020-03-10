using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CoreLayer.Citrix.Adc.NitroClient.Interfaces
{
    public interface INitroHttpClient
    {
        Task Login(CancellationToken cancellationToken);
        Task Logout(CancellationToken cancellationToken);
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
    }
}
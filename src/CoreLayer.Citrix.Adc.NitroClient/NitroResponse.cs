using System.Net;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public abstract class NitroResponse : INitroResponse
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public string Severity { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
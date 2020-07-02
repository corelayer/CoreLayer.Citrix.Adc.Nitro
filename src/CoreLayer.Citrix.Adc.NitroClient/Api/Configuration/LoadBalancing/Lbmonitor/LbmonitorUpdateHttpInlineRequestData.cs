using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorUpdateHttpInlineRequestData : LbmonitorUpdateRequestData
    {
        public LbmonitorUpdateHttpInlineRequestData(string monitorName) : base(monitorName)
        {
        }

        public string Type => "HTTP-INLINE";
        public string Action { get; set; }
        [JsonPropertyName("respcode")]public string[] ResponseCodes { get; set; }
        public string HttpRequest { get; set; }
        public string CustomHeaders { get; set; }
    }
}
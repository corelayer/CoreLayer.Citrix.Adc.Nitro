using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server
{
    public class ServerUpdateRequestData : INitroRequestData
    {
        public string Name { get; }

        public ServerUpdateRequestData(string serverName)
        {
            Name = serverName;
        }
        public string IpAddress { get; set; }
        public int? DomainResolveRetry { get; set; }
        public string TranslationIp { get; set; }
        public string TranslationMask { get; set; }
        public bool? DomainResolveNow { get; set; }
        public string Comment { get; set; }
    }
}
namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceAddDnsRequestData : ServiceAddRequestData
    {
        public ServiceAddDnsRequestData(string serviceName, string targetIpOrServer, int port) : base(serviceName, targetIpOrServer)
        {
            Port = port;
        }

        public override string ServiceType { get; } = "DNS";
        public override int Port { get; }
    }
}
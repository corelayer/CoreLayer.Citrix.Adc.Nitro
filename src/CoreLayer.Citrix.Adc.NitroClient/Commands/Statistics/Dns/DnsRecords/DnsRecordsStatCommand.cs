using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Dns.DnsRecords;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Statistics.Dns.DnsRecords
{
    public class DnsRecordsStatCommand : NitroCommand<DnsRecordsStatResponse>
    {
        public DnsRecordsStatCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) :
            base(
                serviceClient, requestConfiguration)
        {
            
        }
    }
}
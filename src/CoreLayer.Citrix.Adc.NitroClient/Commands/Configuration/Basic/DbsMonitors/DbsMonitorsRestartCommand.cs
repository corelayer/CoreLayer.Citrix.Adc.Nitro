using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.DbsMonitors;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.DbsMonitors
{
    public class DbsMonitorsRestartCommand : NitroCommand<DbsMonitorsRestartResponse>
    {
        public DbsMonitorsRestartCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}
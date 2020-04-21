using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.SSL.SslCertFile
{
    public class SslCertFileImportCommand : NitroCommand<NitroResponse>
    {
        public SslCertFileImportCommand(INitroHttpClient client, INitroRequestConfiguration requestConfiguration) :
            base(client, requestConfiguration)
        {
            
        }
    }
}
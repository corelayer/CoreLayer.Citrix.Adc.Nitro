using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertFile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.SSL.SslCertFile
{
    public class SslCertFileGetCommand : NitroCommand<SslCertFileGetResponse>
    {
        public SslCertFileGetCommand(INitroServiceClient serviceClient, 
            INitroRequestConfiguration requestConfiguration) : base(serviceClient, requestConfiguration)
        {
                                                
        }
    }
}
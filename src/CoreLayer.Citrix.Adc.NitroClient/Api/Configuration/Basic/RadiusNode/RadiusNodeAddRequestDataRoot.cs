using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.RadiusNode
{
    public class RadiusNodeAddRequestDataRoot : INitroRequestDataRoot
    {
        public RadiusNodeAddRequestDataRoot(dynamic data)
        {
            RadiusNode = new dynamic[] {data};
        }
        public RadiusNodeAddRequestDataRoot(dynamic[] data)
        {
            RadiusNode = data;
        }
        public dynamic[] RadiusNode { get; set; }
    }
}
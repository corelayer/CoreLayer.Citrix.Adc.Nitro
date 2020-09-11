using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.RadiusNode
{
    public class RadiusNodeUpdateRequestDataRoot : INitroRequestDataRoot
    {
        public RadiusNodeUpdateRequestDataRoot(dynamic data)
        {
            RadiusNode = new dynamic[] {data};
        }
        public RadiusNodeUpdateRequestDataRoot(dynamic[] data)
        {
            RadiusNode = data;
        }
        public dynamic[] RadiusNode { get; set; }
    }
}